using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

      namespace fff
{


    internal abstract class Document
    {
        public abstract void createDocument();
    }
    class WordDocument : Document
    {
        public override void createDocument()
        {
            Console.WriteLine("Creating Concrete word");
        }

    }
    class pirepoint : Document
    {
        public override void createDocument()
        {
            Console.WriteLine("Creating Concrete pirepoint");
        }

    }
    class DocumentFactory
    {
        public static Document CreateDocument()
        {
            string word = ConfigurationManager.AppSettings["word"];
            string pirepoint = ConfigurationManager.AppSettings["pirepoint"];
            return CreateDocument(word);

        }
        public static Document CreateDocument(string type)
        {
            switch (type)
            {
                case "worddocument":
                    return new WordDocument();
                case "pirepoint":
                    return new pirepoint();
                default:
                    throw new ArgumentException("Invalid document type");
            }
        }
    }


}




