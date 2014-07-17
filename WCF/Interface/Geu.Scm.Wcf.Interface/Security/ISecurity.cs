using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Wcf.Interface.Security
{
    [ServiceContract]
    public interface ISecurity
    {
        [OperationContract]
        CheckUserExistOutput CheckUserExist(CheckUserExistInput checkUserExistInput);
    }
}
