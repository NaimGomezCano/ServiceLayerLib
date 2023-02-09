using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPB1
{
    public partial class ServiceLayer
    {
        public global::Microsoft.OData.Client.DataServiceActionQuerySingle<global::SAPB1.B1Session> Login()
        {
            return this.Login(
                settings.companyDB,
                settings.userName,
                settings.password,
                settings.language
            );
        }
    }
}
