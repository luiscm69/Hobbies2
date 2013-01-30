using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HobbiesServices
{
    [ServiceContract]
    public interface IHobbies
    {
        [OperationContract]
        void registrarHobby(int codigo, string descripcion);

        [OperationContract]
        List<string> listarHobbies();

    }
}
