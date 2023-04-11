namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utente utente1 = new Utente("Rossi", "Mario", "mario@gmail.com", "ciao123", 34344233);
            Libro libro1 = new Libro(232, "ABCD45", "Titolo1", 2003, "Fantasy", "Luigi Verdi", 4);
            Libro libro2 = new Libro(123, "GFGE32", "Titolo2", 2006, "Horror", "Mario Rossi", 7);
            Libro libro3 = new Libro(443, "DGFS12", "Titolo3", 2013, "Fantasy", "Paolo Gialli ", 2);
            Prestito prestito1 = new Prestito(utente1, "11/04/2023", "11/05/2023", libro1);
            List<Utente> listaUtenti = new List<Utente>();
            listaUtenti.Add(utente1);
            List<Documento> listaDocumenti = new List<Documento>();
            listaDocumenti.Add(libro1);
            listaDocumenti.Add(libro2);
            listaDocumenti.Add(libro3);
            List<Prestito> listaPrestiti = new List<Prestito>();
            listaPrestiti.Add(prestito1);
            Console.WriteLine("Benvenuto nella biblioteca!");
            Console.WriteLine("Registrati per iniziare");
           
            Console.Write("Nome : ");
            string nomeUtente = Console.ReadLine();
            
            Console.Write("Cognome : ");
            string cognomeUtente = Console.ReadLine();
          
            Console.Write("Indirizzo Email : ");
            string email = Console.ReadLine();
            
            Console.Write("Password : ");
            string password = Console.ReadLine();
           
            Console.Write($"Numero di telefono : ");
            int telefono;
            while (!int.TryParse(Console.ReadLine(), out telefono))
                Console.WriteLine("Inserisci dei numeri");
            Utente nuovoUtente = new Utente(cognomeUtente, nomeUtente, email, password, telefono);
            Console.WriteLine("Ti sei registrato correttamente!");
            Console.Write("Scrivi il titolo di un libro : ");
            string titolo = Console.ReadLine();
           var ricercaLibro =  listaDocumenti.Find(x => x.Titolo == titolo);

            if (ricercaLibro != null)
            {
                Console.Write("é stato trovato il seguente libro : ");  Console.WriteLine(ricercaLibro.Titolo);
                Console.WriteLine("Vuoi prenderlo in prestito? (Si/No)");
                string boolPrestitoLibro = Console.ReadLine();
              
                 if (boolPrestitoLibro == "Si")
                {
                    Console.WriteLine("Inserisci la data di inizio prestito : ");
                    string dataInizio = Console.ReadLine();
                    Console.WriteLine("Inserisci la data di fine prestito : ");
                    string dataFine = Console.ReadLine();
                    Prestito prestito2 = new Prestito(nuovoUtente, dataInizio, dataFine, ricercaLibro);
                    listaPrestiti.Add(prestito2);
                    Console.WriteLine("Il tuo prestito è stato completato!");
                }
                
            }
            else
                Console.WriteLine("Non é stato trovato nessun libro con quel titolo");
           
            Console.WriteLine("Vuoi cercare il prestito di un utente? (Si/No)");
            string boolPrestitoUtente = Console.ReadLine();
           
          
            if (boolPrestitoUtente == "Si")
            {
                Console.WriteLine("Inserisci il nome dell`utente");
                string nomePrestitoUtente = Console.ReadLine();
                Console.WriteLine("Inserisci il cognome dell`utente");
                string cognomePrestitoUtente = Console.ReadLine();
                var ricercaPrestito = listaPrestiti.Find(x => x.Utente.Nome == nomePrestitoUtente && x.Utente.Cognome == cognomePrestitoUtente);
                if(ricercaPrestito != null)
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
            
            Biblioteca biblioteca = new Biblioteca(listaUtenti, listaPrestiti, listaDocumenti);


            
        }
    }
}