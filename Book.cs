using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuovaBibliotecaDB
{
    internal class Book : Document
    {

        public Book( string title, string author) : base(title, author)
        {
        
        }

    }
}
