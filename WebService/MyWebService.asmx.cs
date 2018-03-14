using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Summary description for MyWebService
    /// </summary>
    [WebService(Namespace = "http://meuserver.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MyWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld(string nome, int idade)
        {
            return "Olá "+nome+" sua idade é "+idade+" anos";
        }

        [WebMethod]
        public decimal Calcula(decimal n1, decimal n2, string op)
        {
            if (op == "+")
                return n1 + n2;
            else if (op == "-")
                return n1 - n2;
            else if (op == "*")
                return n1 * n2;
            else if (op == "/")
                return n1 / n2;
            else            
                throw new Exception("O operador é inválido!");            
        }

        [WebMethod]
        public double Temp(double temp, string grau)
        {
            double c = 0;
            double f = 0;
            if(grau.ToLower() == "f")
            {
                f = temp;
                c = (f - 32) / 1.8;
                return c;
            }
            else if(grau.ToLower() == "c")
            {
                c = temp;
                f = (c * 1.8) + 32;
                return f;
            }
            else
            {
                throw new Exception("A escala é inválida, valores válidos: 'F' ou 'C'");
            }
        }
    }
}
