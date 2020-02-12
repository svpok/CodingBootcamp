using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupportTroubleshootingTool.Core.Handlers;

namespace TestCoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
           // Console.WriteLine("Hello World!");
            //Console.ReadKey();
            ConfigXML obj = new ConfigXML(@"C:\Users\Amal Saleh\Desktop\CodingBootcamp\XML.xml");
            obj.Change("//Envelope/Cube/Cube/Cube[@rate>50 or @currency='USD']/@currency","%%%%");
            obj.Save();
            Console.ReadKey();
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
