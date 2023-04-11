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
    
        public void RicercaLibro(string titolo,Utente utente)
        {
           
       
            var ricercaLibro = Documenti.Find(x => x.Titolo == titolo);

            if (ricercaLibro != null)
            {
                Console.Write("é stato trovato il seguente libro : "); Console.WriteLine(ricercaLibro.Titolo);
                Console.WriteLine("Vuoi prenderlo in prestito? (Si/No)");
                string boolPrestitoLibro = Console.ReadLine();

                if (boolPrestitoLibro == "Si")
                {
                    Console.WriteLine("Inserisci la data di inizio prestito : ");
                    string dataInizio = Console.ReadLine();
                    Console.WriteLine("Inserisci la data di fine prestito : ");
                    string dataFine = Console.ReadLine();
                    Prestito prestito2 = new Prestito(utente, dataInizio, dataFine, ricercaLibro);
                    AggiungiPrestito(prestito2);
                    Console.WriteLine("Il tuo prestito è stato completato!");
                }

            }
            else
                Console.WriteLine("Non é stato trovato nessun libro con quel titolo");
        }
        public void RicercaPrestito(string nomePrestitoUtente, string cognomePrestitoUtente)
        {
          
            var ricercaPrestito = Prestiti.Find(x => x.Utente.Nome == nomePrestitoUtente && x.Utente.Cognome == cognomePrestitoUtente);
            if (ricercaPrestito != null)
            {
                Console.WriteLine($"Ecco le informazioni riguardo al prestito che è stato trovato : ");
                Console.WriteLine($"Titolo : {ricercaPrestito.Documento.Titolo}");
                Console.WriteLine($"Autore : {ricercaPrestito.Documento.Autore}");
                Console.WriteLine($"Anno : {ricercaPrestito.Documento.Anno}");
                Console.WriteLine($"Codice : {ricercaPrestito.Documento.Codice}");
                Console.WriteLine($"Scaffale : {ricercaPrestito.Documento.Settore}");
                Console.WriteLine($"Scaffale : {ricercaPrestito.Documento.Scaffale}");
                Console.WriteLine($"Data inizio prestito : {ricercaPrestito.PeriodoInizio}");
                Console.WriteLine($"Data fine prestito : {ricercaPrestito.PeriodoFine}");
            }
            else
                Console.Write($"Non è stato trovato nessun prestito ");
       

        }
        public void AggiungiUtente(Utente utente)
        {
            Utenti.Add(utente);
        }
        public void AggiungiPrestito(Prestito prestito)
        {
            Prestiti.Add(prestito);

        }
        public void AggiungiDocumento(Documento documento)
        {
            Documenti.Add(documento);
        }

    }
   
}
