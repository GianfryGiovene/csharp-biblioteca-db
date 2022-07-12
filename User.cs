using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuovaBibliotecaDB
{
    internal class User : Guest
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Telephone { get; set; }
        public string Username { get; set; }


        public User(string surname, string name, string password) : base()
        {
            this.Surname = surname;
            this.Name = name;
            this.Password = password;
            this.Username = surname + name;



        }


    }
}
