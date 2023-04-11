using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Utente
    {
        public string cognome { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int telefono { get; set; }

        public Utente(string cognome, string nome, string email, string password, int telefono)
        {
            this.cognome = cognome;
            this.nome = nome;
            this.email = email;
            this.password = password;
            this.telefono = telefono;
        }
    }
}
