﻿namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            Utente utente1 = new Utente("Rossi", "Mario", "mario@gmail.com", "ciao123", 34344233);
            Libro libro1 = new Libro(232, "ABCD45", "Titolo1", 2003, "Fantasy", "Luigi Verdi", 4);
            Libro libro2 = new Libro(123, "GFGE32", "Titolo2", 2006, "Horror", "Mario Rossi", 7);
            Libro libro3 = new Libro(443, "DGFS12", "Titolo3", 2013, "Fantasy", "Paolo Gialli ", 2);
            Prestito prestito1 = new Prestito(utente1, "11/04/2023", "11/05/2023", libro1);
            biblioteca.AggiungiUtente(utente1);
            biblioteca.AggiungiDocumento(libro1);
            biblioteca.AggiungiDocumento(libro2);
            biblioteca.AggiungiDocumento(libro3);
            biblioteca.AggiungiPrestito(prestito1);
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
            biblioteca.Utenti.Add(nuovoUtente);

            Console.WriteLine("Ti sei registrato correttamente!");
            Console.Write("Scrivi il titolo di un libro : ");
            string titolo = Console.ReadLine();
            biblioteca.RicercaLibro(titolo,nuovoUtente);
            Console.WriteLine("Vuoi cercare il prestito di un utente? (Si/No)");
            string boolPrestitoUtente = Console.ReadLine();
            if (boolPrestitoUtente == "Si")
            {
                Console.WriteLine("Inserisci il nome dell`utente");
                string nomePrestitoUtente = Console.ReadLine();
                Console.WriteLine("Inserisci il cognome dell`utente");
                string cognomePrestitoUtente = Console.ReadLine();
                biblioteca.RicercaPrestito(nomePrestitoUtente, cognomePrestitoUtente);
            }
            
        } 
    }
}