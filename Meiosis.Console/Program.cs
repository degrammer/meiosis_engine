using Meiosis.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meiosis.Console
{
    public class Program
    {
        static void Main(string[] args)
        {

            using (Microsoft.Owin.Hosting.WebApp.Start
<Startup>("http://localhost:2259"))
            {
                System.Console.WriteLine("Starting OWIN Self Hosted Server on port 2259");
                System.Console.ReadKey();
            }
        }
    }
}
