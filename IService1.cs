using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService
{
  
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        public List<ItemClass> GetList(string type);

        [OperationContract]
        public List<ItemClass> GetAll();
      
    }


    
    /*
    [DataContract]
    public class CompositeType
    {
      
    
    }
     * */
}
