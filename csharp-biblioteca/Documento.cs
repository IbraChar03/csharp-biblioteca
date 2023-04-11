using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
     internal class Documento
    {
     

        public string Codice { get;private  set; }
        public string Titolo { get; set; }
        public int Anno { get; set; }
        public string Settore { get; set; }
        public string Autore { get; set; }
        public int Scaffale { get; set; }
        public Documento(string codice, string titolo, int anno, string settore, string autore, int scaffale)
        {
            Codice = codice;
            Titolo = titolo;
            Anno = anno;
            Settore = settore;
            Autore = autore;
            Scaffale = scaffale;
        }
    }
 

}
