using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Libro : Documento
    {
      
        public int NumeroPagine { get; set; }
        public Libro(int numeroPagine, string codice, string titolo, int anno, string settore, string autore, int scaffale) : base(codice, titolo, anno, settore, autore, scaffale)
        {
            NumeroPagine = numeroPagine;
        }

    }
}
