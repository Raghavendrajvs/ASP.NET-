using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer_DAL_.Model;

namespace Data_Access_Layer_DAL_.Respository
{
    public class Product_respository
    {
        public  List<Product> productslist = new List<Product>();
        public void getDetails()
        {

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\ASP.net\ASP.NET assignment\assignment ASP.net\Shopping cart\App_Data\Acuvate.mdf; Integrated Security = True";
                connection.Open();

                string sql = "select * from Product_details";
                SqlCommand sqlCommand = new SqlCommand(sql, connection);

                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        productslist.Add(new Product
                        {
                            Id = Convert.ToInt32(sqlDataReader["Id"].ToString()),
                            Name = (sqlDataReader["Name"].ToString()),
                            Price = sqlDataReader["Price"].ToString(),
                            ImageUrl = sqlDataReader["ImageUrl"].ToString(),
                            Description = sqlDataReader["Description"].ToString()


                        });
                    }
                }
            }
        }
        public void Insert(int Id, string Name, string Price, string ImageUrl)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\ASP.net\ASP.NET assignment\assignment ASP.net\Shopping cart\App_Data\Acuvate.mdf; Integrated Security = True";
                connection.Open();
                // Note the "placeholders" in the SQL query.
                string sql = "Insert Into Product_details" +
                            "(Id, Name, Price,ImageUrl) Values" +
                            "(@Id, @Name, @Price,@ImageUrl)";

                // This command will have internal parameters.
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Fill params collection.
                    SqlParameter parameter = new SqlParameter
                    {
                        ParameterName = "@Id",
                        Value = Id,
                        SqlDbType = SqlDbType.Char,
                        Size = 10
                    };
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter
                    {
                        ParameterName = "@Name",
                        Value = Name,
                        SqlDbType = SqlDbType.Char,
                        Size = 10
                    };
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter
                    {
                        ParameterName = "@Price",
                        Value = Price,
                        SqlDbType = SqlDbType.Char,
                        Size = 10
                    };
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter
                    {
                        ParameterName = "@ImageUrl",
                        Value = "~/Content/"+ImageUrl,
                        SqlDbType = SqlDbType.NVarChar,
                        Size = 10
                    };
                    command.Parameters.Add(parameter);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }


        }
        public void Delete(int Id)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\ASP.net\ASP.NET assignment\assignment ASP.net\Shopping cart\App_Data\Acuvate.mdf; Integrated Security = True";
                connection.Open();
                // Get ID of car to delete, then do so.
                string sql = $"Delete from Product_details where Id = '{Id}'";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Exception error = new Exception("Sorry! Error!", ex);
                        throw error;
                    }
                }
                connection.Close();
            }
        }
        public void Update(int Id, string Name, string ImageUrl, string Price)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\ASP.net\ASP.NET assignment\assignment ASP.net\Shopping cart\App_Data\Acuvate.mdf; Integrated Security = True";
                connection.Open();
                // Get ID of car to modify and new pet name.
                string sql = $"Update Product_details Set Id='{Id}', Name = '{Name}', ImageUrl='{"~/Content/"+ImageUrl}', Price= '{Price}' Where Id = '{Id}'";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Exception error = new Exception("Sorry! Error!", ex);
                        throw error;
                    }
                }
                   
                connection.Close();
            }

        }
        public void SearchProduct(string Name)
        {

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\ASP.net\ASP.NET assignment\assignment ASP.net\Shopping cart\App_Data\Acuvate.mdf; Integrated Security = True";
                getDetails();
                connection.Open();

                string sql = $"select * from Product_details where Name Like '%{Name}%'";
                SqlCommand sqlCommand = new SqlCommand(sql, connection);

                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        productslist.Add(new Product
                        {
                            Id = Convert.ToInt32(sqlDataReader["Id"].ToString()),
                            Name = (sqlDataReader["Name"].ToString()),
                            Price = sqlDataReader["Price"].ToString(),
                            ImageUrl = sqlDataReader["ImageUrl"].ToString(),
                            Description = sqlDataReader["Description"].ToString()
                        });
                    }
                }
            }

        }

    }
}
