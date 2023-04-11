using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Biblioteca
    {
        public List<Utente> Utenti = new List<Utente>();
        public List<Prestito> Prestiti = new List<Prestito>();
        public List<Documento> Documenti = new List<Documento>();
  
        public Biblioteca(List<Utente> utenti, List<Prestito> prestiti, List<Documento> documenti)
        {
            Utenti = utenti;
            Prestiti = prestiti;
            Documenti = documenti;
        }
    }
}
