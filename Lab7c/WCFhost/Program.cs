using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFhost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(WCFlib.NoteService)))
            {
                host.Open();
                Console.WriteLine("Service is ready at {0}", host.BaseAddresses[0].AbsoluteUri);
                Console.WriteLine("Press key to stop");
                Console.ReadKey();
                host.Close();
            }
        }
    }
}
