using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf.IISHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Security" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Security.svc or Security.svc.cs at the Solution Explorer and start debugging.
    public class Security : Interface.Security.ISecurity
    {
       
        public Interface.Security.CheckUserExistOutput CheckUserExist(Interface.Security.CheckUserExistInput checkUserExistInput)
        {
            return new Interface.Security.CheckUserExistOutput();
        }
    }
}
