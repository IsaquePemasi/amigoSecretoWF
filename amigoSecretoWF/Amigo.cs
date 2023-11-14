using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amigoSecretoWF
{
    public class Amigo
    {
        public string Nome {  get; set; }
        public string Email {  get; set; }

        public Amigo(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + " : " + Email;
        }

        public override bool Equals(object? obj)
        {
            return obj is Amigo amigo && Email == amigo.Email;
        }
    }
}
