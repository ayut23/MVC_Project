using Microsoft.Extensions.Configuration;
using PROG123.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PROG123.DAL
{
    public class DALProducts
    {
        private IConfiguration configuration;
        public DALProducts(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        internal String AddNewProduc(ProductModel productsModel)
        {
            //Step #1 - Connect to the DB
            string connStr = configuration.GetConnectionString("MyConnString");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            //Step #2 - create a command
            string query = "INSERT INTO [dbo].[Products]([Name],[Description],[Price],[InventoryAmount])" +
                " VALUES(@Name,@Description,@Price,@InventoryAmount) select SCOPE_IDENTITY() as id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", productsModel.Name);
            cmd.Parameters.AddWithValue("@Description", productsModel.Description);
            cmd.Parameters.AddWithValue("@Price", productsModel.Price);
            cmd.Parameters.AddWithValue("@InventoryAmount", productsModel.InventoryAmount);

            //Step #3 - query the DB
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            //get the user ID
            string PID = reader["id"].ToString();

            //Step #4 - close the connection
            conn.Close();

            return PID;
        }

        

        /// <summary>
        /// Returns a list of all products in the database
        /// </summary>
        /// <returns></returns>
        internal LinkedList<ProductModel> GetAllProducts()
        {
            //Step #1 - Connect to the DB
            string connStr = configuration.GetConnectionString("MyConnString");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            //Step #2 - create a command
            string query = "SELECT Name,Description,PID,Price,InventoryAmount FROM Products";
            SqlCommand cmd = new SqlCommand(query, conn);

            LinkedList<ProductModel> allProds = new LinkedList<ProductModel>();
            //Step #3 - query the DB
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ProductModel productModel = new ProductModel();
                productModel.Name = reader["Name"].ToString();
                productModel.Description = reader["Description"].ToString();
                productModel.PID = reader["PID"].ToString();
                productModel.Price = Convert.ToDouble(reader["Price"]);
                productModel.InventoryAmount = Convert.ToInt32(reader["InventoryAmount"]);

                allProds.AddLast(productModel);
            }

            //Step #4 - close the connection
            conn.Close();

            return allProds;
        }
        
        internal void UpdateInventory(string pID, int inventoryDelta)
        {
            //Step #1 - Connect to the DB
            string connStr = configuration.GetConnectionString("MyConnString");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            //Step #2 - create a command
            string query = "UPDATE Products SET InventoryAmount=InventoryAmount+@inventoryDelta " +
                " WHERE PID = @PID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@inventoryDelta", inventoryDelta);
            cmd.Parameters.AddWithValue("@PID", pID);

            //Step #3 - query the DB
            cmd.ExecuteNonQuery();

            //Step #4 - close the connection
            conn.Close();
        }

        public ProductModel GetProduc(string pID)
        {
            //Step #1 - Connect to the DB
            string connStr = configuration.GetConnectionString("MyConnString");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            //Step #2 - create a command
            string query = "SELECT Name,Description,PID,Price,InventoryAmount FROM Products where PID=@PID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@PID", pID);

            //Step #3 - query the DB
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            ProductModel productModel = new ProductModel();
            productModel.PID = reader["PID"].ToString();
            productModel.Name = reader["Name"].ToString();
            productModel.Description = reader["Description"].ToString();
            productModel.Price = Convert.ToDouble(reader["Price"].ToString());
            productModel.InventoryAmount = Convert.ToInt32(reader["InventoryAmount"].ToString());

            //Step #4 - close the connection
            conn.Close();

            return productModel;
        }
    
        
    }
}
