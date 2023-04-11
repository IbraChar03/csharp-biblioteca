using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Prestito
    {
        public Utente Utente { get; set; }
        public string PeriodoInizio { get; set; }
        public string PeriodoFine { get; set; }
        public Documento Documento { get; set; }

        public Prestito(Utente utente, string periodoInizio, string periodoFine, Documento documento)
        {
            Utente = utente;
            PeriodoInizio = periodoInizio;
            PeriodoFine = periodoFine;
            Documento = documento;
        }
    }
}
