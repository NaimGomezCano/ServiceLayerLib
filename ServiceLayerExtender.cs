using Microsoft.OData;
using Microsoft.OData.Client;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace SAPB1
{
    // Own implementation.
    public partial class ServiceLayer
    {
        public ServiceLayer() :
        this(new global::System.Uri(settings.uri), global::Microsoft.OData.Client.ODataProtocolVersion.V4)
        {

        }

        private string m_strCookie = "";

        public int PageSize { get; set; } = -1;

        // An empty implementation for certificate verification.
        private static bool TLSCertificateValidate(object sender,
            X509Certificate cert,
            X509Chain chain,
            SslPolicyErrors ssl)
        {
            return true;
        }

        partial void OnContextCreated()
        {
            this.Timeout = 300;
            InitializeContext();
        }

        private void InitializeContext()
        {
            // Get the cookie if the response header containing Set-Cookie.
            this.ReceivingResponse += (sender, eventArgs) =>
            {
                if (eventArgs.ResponseMessage != null)
                {
                    string cookie = eventArgs.ResponseMessage.GetHeader("Set-Cookie");
                    if (!string.IsNullOrEmpty(cookie))
                    {
                        if (eventArgs.ResponseMessage.StatusCode == (int)HttpStatusCode.OK)
                        {
                            m_strCookie = cookie;
                        }
                    }
                }
            };

            // Set the cookie for each request.
            this.BuildingRequest += (sender, eventArgs) =>
            {
                if (eventArgs.Headers.ContainsKey("Accept") &&
                    eventArgs.Headers["Accept"].IndexOf("multipart/mixed") == -1)
                {
                    eventArgs.Headers["Accept"] = "application/json;odata.metadata=minimal;";
                }

                if (m_strCookie != null)
                {
                    eventArgs.Headers["cookie"] = m_strCookie;
                }

                // Set the page size if it is not the default value.
                if (PageSize != -1)
                {
                    // The page size header is specified like this way:
                    // Prefer:odata.maxpagesize=50
                    string preferValue;
                    eventArgs.Headers.TryGetValue("Prefer", out preferValue);
                    preferValue += string.Format("odata.maxpagesize={0}", PageSize);
                    eventArgs.Headers["Prefer"] = preferValue;
                }
            };

            // Ignore the SSL/TLS certificate check for the HTTPS connection to Service Layer.
            ServicePointManager.ServerCertificateValidationCallback = TLSCertificateValidate;

            // Filter out the null properties for some cases like entity creation.
            this.Configurations.RequestPipeline.OnEntryStarting((arg) =>
            {
                arg.Entry.Properties = FilterNullValues(arg.Entry);
            });
        }

        Action<WritingEntryArgs> m_filterNullAction = (arg) =>
        {
            arg.Entry.Properties = FilterNullValues(arg.Entry);
        };

        Action<WritingEntryArgs> m_defaultAction = (arg) =>
        {
        };

        public void SetEntryStartingAction()
        {
            this.Configurations.RequestPipeline.OnEntryStarting(m_filterNullAction);
        }

        public void ClearEntryStartingAction()
        {
            this.Configurations.RequestPipeline.OnEntryStarting(m_defaultAction);
        }

        static ODataResourceValue RebuildComplexValue(ODataResourceValue oldResourceValue)
        {
            List<ODataProperty> newProperties = new List<ODataProperty>();
            foreach (ODataProperty prop in oldResourceValue.Properties)
            {
                if (prop.Value == null || prop.Value is null)
                {
                    continue;
                }

                Type propType = prop.Value.GetType();
                switch (propType.Name)
                {
                    case "ODataPrimitiveValue":
                        {
                            newProperties.Add(prop);
                        }
                        break;

                    case "ODataEnumValue":
                        {
                            var enumProp = prop.Value as ODataEnumValue;
                            if (!(enumProp.Value is null))
                            {
                                newProperties.Add(prop);
                            }
                        }
                        break;

                    case "ODataResourceValue":
                        {
                            ODataResourceValue resourceValue = prop.Value as ODataResourceValue;
                            ODataResourceValue complexValue = RebuildComplexValue(resourceValue);
                            ICollection<ODataProperty> properties = complexValue.Properties as ICollection<ODataProperty>;
                            if (properties.Count > 0)
                            {
                                prop.Value = complexValue;
                                newProperties.Add(prop);
                            }
                        }
                        break;

                    case "ODataCollectionValue":
                        {
                            ODataCollectionValue collectionValue = RebuildCollectionValue(prop.Value as ODataCollectionValue);
                            ICollection<ODataResourceValue> items = collectionValue.Items as ICollection<ODataResourceValue>;
                            if (items.Count > 0)
                            {
                                prop.Value = items;
                                newProperties.Add(prop);
                            }
                        }
                        break;

                    default:
                        {
                            newProperties.Add(prop);
                            if (prop.Value is ODataPrimitiveValue)
                            {
                                // Console.Out.WriteLine("it is true;");
                            }
                        }
                        break;
                }
            }

            ODataResourceValue newResourceValue = new ODataResourceValue();
            newResourceValue.TypeName = oldResourceValue.TypeName;
            newResourceValue.Properties = newProperties;
            return newResourceValue;
        }


        // Create new ODataCollectionValue from the old, to discard all null/empty values
        static ODataCollectionValue RebuildCollectionValue(ODataCollectionValue oldCollectionValue)
        {
            List<ODataResourceValue> listComplexValues = new List<ODataResourceValue>();
            foreach (ODataResourceValue item in oldCollectionValue.Items)
            {
                ODataResourceValue complex = RebuildComplexValue(item);
                ICollection<ODataProperty> properties = complex.Properties as ICollection<ODataProperty>;
                if (properties.Count > 0)
                {
                    listComplexValues.Add(complex);
                }
            }
            ODataCollectionValue newCollectionValue = new ODataCollectionValue();
            newCollectionValue.TypeName = oldCollectionValue.TypeName;
            newCollectionValue.Items = listComplexValues;
            return newCollectionValue;
        }

        static List<ODataProperty> FilterNullValues(ODataResource oDataResource)
        {
            //Console.Out.WriteLine(">>>>>TypeName={0}", oDataResource.TypeName);
            List<ODataProperty> listResults = new List<ODataProperty>();
            //foreach (ODataInstanceAnnotation annotation in oDataResource.InstanceAnnotations)
            //{
            //    Console.Out.WriteLine("Name={0},Value={1},Type={2}",
            //        annotation.Name, annotation.Value, annotation.Value.GetType().Name);
            //}

            foreach (ODataProperty prop in oDataResource.Properties)
            {
                //   Console.Out.WriteLine("\tName={0},Value={1},Type={2}", prop.Name, prop.Value, prop.GetType().Name);
                if (prop.Value == null || prop.Value is null)
                {
                    continue;
                }

                Type propType = prop.Value.GetType();
                switch (propType.Name)
                {
                    case "ODataPrimitiveValue":
                        {
                            listResults.Add(prop);
                        }
                        break;

                    case "ODataEnumValue":
                        {
                            var enumProp = prop.Value as ODataEnumValue;
                            if (!(enumProp.Value is null))
                            {
                                listResults.Add(prop);
                            }
                        }
                        break;

                    case "ODataResourceValue":
                        {
                            ODataResourceValue complex = RebuildComplexValue(prop.Value as ODataResourceValue);
                            ICollection<ODataProperty> properties = complex.Properties as ICollection<ODataProperty>;
                            if (properties.Count > 0)
                            {
                                prop.Value = complex;
                                listResults.Add(prop);
                            }
                        }
                        break;

                    case "ODataCollectionValue":
                        {
                            ODataCollectionValue collectionValue = RebuildCollectionValue(prop.Value as ODataCollectionValue);
                            var items = collectionValue.Items as ICollection<ODataResourceValue>;
                            if (items.Count > 0)
                            {
                                prop.Value = collectionValue;
                                listResults.Add(prop);
                            }
                        }
                        break;

                    default:
                        {
                            if (prop.Value is ODataPrimitiveValue)
                            {
                                // Console.Out.WriteLine("it is true;");
                            }
                            listResults.Add(prop);
                        }
                        break;
                }
            }
            return listResults;
        }
    }
}
