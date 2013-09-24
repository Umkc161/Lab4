using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Calculator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "add/{a1}/{a2}")]

        public Result Add(string a1, string a2)
        {
            int b1 = Convert.ToInt32(a1);
            int b2 = Convert.ToInt32(a2);
            

            return new Result()
            {
                Id = b1 + b2



            };

        }


        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "sub/{a1}/{a2}")]
        public Result Subtract(string a1, string a2)
        {
            int b1 = Convert.ToInt32(a1);
            int b2 = Convert.ToInt32(a2);
            

            return new Result()
            {
                Id = b1 - b2



            };

        }


        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "multi/{a1}/{a2}")]
        public Result Multiply(string a1, string a2)
        {
            int b1 = Convert.ToInt32(a1);
            int b2 = Convert.ToInt32(a2);
            


            return new Result()
            {
                Id = b1 * b2



            };

        }


        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "div/{a1}/{a2}")]
        public Result Divide(string a1, string a2)
        {
            Double b1 = Convert.ToDouble(a1);
            Double b2 = Convert.ToDouble(a2);
            Double c = b1 / b2;
            

            return new Result()
            {
                Id = c



            };


        }


        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


    
    
    }


    public class Result
    {

        public Double Id { get; set; }

        public string Name { get; set; }

    }
}
