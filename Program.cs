using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter document type (worddocument or pirepoint):");
            //string userInput = Console.ReadLine();


            //Document doc = DocumentFactory.CreateDocument(userInput);



            //doc.createDocument();
            //Console.ReadLine();
            //במקרה שמקבל

            Document doc = DocumentFactory.CreateDocument();
            doc.createDocument();
          





        }
    }
}
