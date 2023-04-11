using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Dvd : Documento
    {
        public int Durata { get; set; }
        public Dvd(int durata, string codice, string titolo, int anno, string settore, string autore, int scaffale) : base(codice, titolo, anno, settore, autore, scaffale)
        {
            Durata = durata;
        }
    }
}
