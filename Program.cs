using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Entity entity = new Entity();
            entity.LogicalName = "account";
            entity.Attributes["name"] = "Test Account";
            entity.Attributes["address1_city"] = "Redmond";
            entity.Attributes["address1_stateorprovince"] = "WA";
            entity.Attributes["address1_country"] = "US";
            entity.Id = Guid.NewGuid();
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Entity: " + entity.LogicalName);
            Console.WriteLine("Name: " + entity.Attributes["name"]);
            Console.WriteLine("City: " + entity.Attributes["address1_city"]);
            Console.WriteLine("State: " + entity.Attributes["address1_stateorprovince"]);
            Console.WriteLine("Country: " + entity.Attributes["address1_country"]);
            Console.WriteLine("Id: " + entity.Id);

        }
    }
}


