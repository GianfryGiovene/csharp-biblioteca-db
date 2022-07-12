using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuovaBibliotecaDB
{
    internal class Rent
    {
        public User User { get; private set; }
        public Document Document { get; private set; }

        string dateStartRent;
        string dateEndRent;

        public Rent(User user, Document document, string dateStartRent, string dateEndRent)
        {
            this.User = user;
            this.Document = document;
            this.dateEndRent = dateEndRent;
            this.dateStartRent = dateStartRent;
        }
    }
}
