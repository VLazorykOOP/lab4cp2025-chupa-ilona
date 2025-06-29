using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace LibraryManager
{
    public static class DatabaseHelper
    {
        private static readonly string connStr = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

        // Параметризований ExecuteQuery (повертає DataTable)
        public static DataTable ExecuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        // Параметризований ExecuteNonQuery (для Insert, Update, Delete)
        public static int ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable GetAllBooks()
        {
            string query = "SELECT * FROM books";
            return ExecuteQuery(query);
        }

        public static void AddBook(string author, string title, string publisher, int pageCount, string genre, decimal price, string storage, string inventory)
        {
            string query = "INSERT INTO books (author, title, publisher, page_count, genre, price, storage, inventory_number) " +
                           "VALUES (@a, @t, @p, @pc, @g, @pr, @s, @i)";
            var parameters = new Dictionary<string, object>
            {
                {"@a", author},
                {"@t", title},
                {"@p", publisher},
                {"@pc", pageCount},
                {"@g", genre},
                {"@pr", price},
                {"@s", storage},
                {"@i", inventory}
            };
            ExecuteNonQuery(query, parameters);
        }

        public static void UpdateBook(int id, string author, string title, string publisher, int pageCount, string genre, decimal price, string storage, string inventory)
        {
            string query = "UPDATE books SET author=@a, title=@t, publisher=@p, page_count=@pc, genre=@g, price=@pr, storage=@s, inventory_number=@i WHERE id=@id";
            var parameters = new Dictionary<string, object>
            {
                {"@a", author},
                {"@t", title},
                {"@p", publisher},
                {"@pc", pageCount},
                {"@g", genre},
                {"@pr", price},
                {"@s", storage},
                {"@i", inventory},
                {"@id", id}
            };
            ExecuteNonQuery(query, parameters);
        }

        public static void DeleteBook(int id)
        {
            string query = "DELETE FROM books WHERE id=@id";
            var parameters = new Dictionary<string, object>
            {
                {"@id", id}
            };
            ExecuteNonQuery(query, parameters);
        }
    }
}
