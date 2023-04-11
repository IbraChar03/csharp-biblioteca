namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utente utente1 = new Utente("Rossi", "Mario", "mario@gmail.com", "ciao123", 34344233);
            Libro libro1 = new Libro(232, "ABCD", "Titolo1", 2003, "Fantasy", "Luigi Verdi", 4);
            Prestito prestito1 = new Prestito(utente1, "11/04/2023", "11/05/2023", libro1);
            List<Utente> listaUtenti = new List<Utente>();
            listaUtenti.Add(utente1);
            List<Documento> listaDocumenti = new List<Documento>();
            listaDocumenti.Add(libro1);
            List<Prestito> listaPrestiti = new List<Prestito>();
            listaPrestiti.Add(prestito1);

            Biblioteca biblioteca = new Biblioteca(listaUtenti, listaPrestiti, listaDocumenti);

            
        }
    }
}