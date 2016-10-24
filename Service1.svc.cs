using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService
{
    
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public List<ItemClass> GetList(string type)
        {
            List<ItemClass> Lista = new List<ItemClass>();
            ItemClass ic = new ItemClass();
            using(DatabaseEntitiesGo data = new DatabaseEntitiesGo())
            {
                var getitems = from p in data.Items 
                               where p.Type == type 
                               select p;
                
                foreach(var x in getitems)
                {
                    ic.Id = x.Id;
                    ic.Name = x.Name;
                    ic.Price = x.Price;
                    ic.SellerId = x.SellerId;
                    Lista.Add(ic);
                  
                }

            }


            return Lista;
        }

        public List<ItemClass> GetAll()
        {
            List<ItemClass> Lista = new List<ItemClass>();
            ItemClass ic = new ItemClass();
            using (DatabaseEntitiesGo data = new DatabaseEntitiesGo())
            {
                var getitems = from p in data.Items
                               select p;

                foreach (var x in getitems)
                {
                    ic.Id = x.Id;
                    ic.Name = x.Name;
                    ic.Price = x.Price;
                    ic.SellerId = x.SellerId;
                    Lista.Add(ic);

                }

            }


            return Lista;
        }
       
    }
}
