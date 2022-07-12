using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NuovaBibliotecaDB
{
    internal class Guest
    {
        private static int StoreViews = 1;

        public Guest()
        {
            Guest.StoreViews++;
        }


        //public User GuestRegistration()
        //{
            

            
        //}


        //deve poter eseguire delle ricerche per codice o per titolo e, eventualmente

        public List<Document> SearchInDocuments(List<Document> documents)
        {
            List<Document> filteredList = new List<Document>();
            Console.Write("***** Ricerca documenti *****\n\nCome si vuole cercare il documento?\n1 - codice identificativo\n2 - nome del documento");
            int validator = Int32.Parse(Console.ReadLine());
            switch (validator)
            {
                case 1:
                    int documentCode = SearchByCode();
                    break;

                case 2:
                    string documentName = SearchByTitle();

                    break;

            }
            return documents;
        }

        // metodi ricerca documento
        public string SearchByTitle()
        {
            Console.Write("\nInserire il titolo che si vuole cercare: ");
            string titoloCercato = Console.ReadLine();
            Console.Clear();
            return titoloCercato;
        }
        public int SearchByCode()
        {
            Console.Write("Cerca per codice: ");
            int codiceCercato = Int32.Parse(Console.ReadLine());
            Console.Clear();
            return codiceCercato;
        }
    }
}
