using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NuovaBibliotecaDB
{
    internal class Db
    {

        static public void Registration(User user)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=db-biblioteca;Integrated Security=True"))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO [user] (name, surname, password) VALUES (@name,@surname,@password)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    using(SqlTransaction trans = connection.BeginTransaction("RegisterUser"))
                    {
                        cmd.Connection = connection;
                        cmd.Transaction = trans;
                        try
                        {
                            cmd.Parameters.Add(new SqlParameter("@name", user.Name));
                            
                            cmd.Parameters.Add(new SqlParameter("@surname", user.Surname));
                           
                            cmd.Parameters.Add(new SqlParameter("@password", user.Password));
                            cmd.ExecuteNonQuery();

                            trans.Commit();
                        }
                        catch(Exception ex)
                        {
                            trans.Rollback();
                        }
                    }

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }                      

        }

        static public void AddBook(Book book)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=db-biblioteca;Integrated Security=True"))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO [book] (title, year, author) VALUES (@title,@year,@author)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    using (SqlTransaction trans = connection.BeginTransaction("InsertBook"))
                    {
                        cmd.Connection = connection;
                        cmd.Transaction = trans;
                        try
                        {
                            cmd.Parameters.Add(new SqlParameter("@title", book.Title));

                            cmd.Parameters.Add(new SqlParameter("@author", book.Author));

                            cmd.ExecuteNonQuery();

                            trans.Commit();
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        static public void FindBook(string title)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=db-biblioteca;Integrated Security=True"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM book WHERE title = @title ";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.Add(new SqlParameter("@title", title));
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine(reader.GetString(1));
                            }
                        }
                    }
                    

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
