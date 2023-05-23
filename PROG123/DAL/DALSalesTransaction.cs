using Microsoft.Extensions.Configuration;
using PROG123.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PROG123.DAL
{
    /// <summary>
    /// This class queries the SalesTransaction table
    /// </summary>
    public class DALSalesTransaction
    {
        private IConfiguration configuration;
        public DALSalesTransaction(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        /// <summary>
        /// Adds a Sale Transaction to the SalesTransaction table
        /// </summary>
        /// <param name="salesTransactionModel"></param>
        internal void AddTransaction(SalesTransactionModel salesTransactionModel)
        {
            //Step #1 - Connect to the DB
            string connStr = configuration.GetConnectionString("MyConnString");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            //Step #2 - create a command
            string query = " INSERT INTO SalesTransaction (ProductID,PersonID,SalesDataTime,PQuantity)" +
                "VALUES(@ProductID, @PersonID, @SalesDataTime, @PQuantity)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ProductID", salesTransactionModel.ProductID);
            cmd.Parameters.AddWithValue("@PersonID", salesTransactionModel.PersonID);
            cmd.Parameters.AddWithValue("@SalesDataTime", salesTransactionModel.SalesDataTime);
            cmd.Parameters.AddWithValue("@PQuantity", salesTransactionModel.PQuantity);

            //Step #3 - query the DB
            cmd.ExecuteNonQuery();

            //Step #4 - close the connection
            conn.Close();
        }

        /// <summary>
        /// Adds a Sale Transaction to the DB and decreases the InventaryAmount from the 
        /// Products table
        /// </summary>
        /// <param name="productID"></param>
        /// <param name="personID"></param>
        /// <param name="manyPurchasedProds"></param>
        /// <returns></returns>
        internal PurchaseModel OneClickBuy(string productID, string personID, int manyPurchasedProds)
        {
            // make the transaction
            SalesTransactionModel salesTransactionModel = new SalesTransactionModel();
            salesTransactionModel.PersonID = personID;
            salesTransactionModel.ProductID = productID;
            salesTransactionModel.PQuantity = manyPurchasedProds; // assuming one purchase
            salesTransactionModel.SalesDataTime = DateTime.Now;
            this.AddTransaction(salesTransactionModel);

            PurchaseModel purchaseModel = new PurchaseModel();
            purchaseModel.PersonModel = new DALPerson(configuration).getPerson(personID);
            purchaseModel.ProductModel = new DALProducts(configuration).GetProduc(productID);

            new DALProducts(configuration).UpdateInventory(productID, manyPurchasedProds * -1);
            // decrease the DB by 1

            return purchaseModel;
        }
        /// <summary>
        /// Get all the sales transaction from the SalesTransaction table based on a single user and a range of time
        /// </summary>
        /// <param name="personID">ID of the Person</param>
        /// <param name="startDate">Start date (DateTime) datatype</param>
        /// <param name="endDate">End date (DateTime) datatype</param>
        /// <returns>linked list of sales transaction</returns>
        internal LinkedList<SalesTransactionModel> GetReport(string personID, DateTime? startDate, DateTime? endDate)
        {
            //Step #1 - Connect to the DB
            string connStr = configuration.GetConnectionString("MyConnString");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            //Step #2 - create a command
            SqlCommand cmd;

            // select all records
            if (startDate == null && endDate == null && personID == null)
            {
                string query = " SELECT  [SalesID],[ProductID],[PersonID],[SalesDataTime],[PQuantity] " +
                " FROM [PROG123DB].[dbo].[SalesTransaction] ";
                cmd = new SqlCommand(query, conn);
            }
            // select all based on a user. Disregard the dates
            else if (startDate == null && endDate == null && personID != null)
            {
                string query = " SELECT  [SalesID],[ProductID],[PersonID],[SalesDataTime],[PQuantity] " +
                " FROM [PROG123DB].[dbo].[SalesTransaction] where PersonID = @PersonID ";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PersonID", personID);
            }
            // select all based on dates only
            else if (startDate != null && endDate != null && personID == null)
            {
                string query = " SELECT  [SalesID],[ProductID],[PersonID],[SalesDataTime],[PQuantity] " +
                " FROM [PROG123DB].[dbo].[SalesTransaction] " +
                " where SalesDataTime > @startDate  AND SalesDataTime<@endDate ";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate.ToString());
            }
            // select based on personID and start and end dates
            else if (startDate != null && endDate != null && personID != null)
            {
                string query = " SELECT  [SalesID],[ProductID],[PersonID],[SalesDataTime],[PQuantity] " +
                " FROM [PROG123DB].[dbo].[SalesTransaction]" +
                " where SalesDataTime > @startDate  AND SalesDataTime < @endDate ";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PersonID", personID);
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate.ToString());
            }
            else
            {
                return null;
            }
            
            

            //Step #3 - query the DB
            LinkedList<SalesTransactionModel> allTransactions = new LinkedList<SalesTransactionModel>();
            //Step #3 - query the DB
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                SalesTransactionModel salesTransactionModel = new SalesTransactionModel();
                salesTransactionModel.SalesID = reader["SalesID"].ToString();
                salesTransactionModel.PersonID = reader["PersonID"].ToString();
                salesTransactionModel.ProductID = reader["ProductID"].ToString();
                salesTransactionModel.SalesDataTime = Convert.ToDateTime(reader["SalesDataTime"]);
                salesTransactionModel.PQuantity = Convert.ToInt32(reader["PQuantity"]);

                allTransactions.AddLast(salesTransactionModel);
            }

            //Step #4 - close the connection
            conn.Close();

            return allTransactions;
        }

        /// <summary>
        /// Returns all the purchased items from a single user
        /// </summary>
        /// <param name="personID"></param>
        /// <returns></returns>
        internal LinkedList<SalesTransactionModel> GetReport(string personID)
        {
            return this.GetReport(personID, null, null);
        }

        /// <summary>
        /// Returns all the purchased items from all users
        /// </summary>
        /// <param name="personID"></param>
        /// <returns></returns>
        internal LinkedList<SalesTransactionModel> GetReport()
        {
            return this.GetReport(null, null, null);
        }

        /// <summary>
        /// Returns all the purchased items from all users on a given range of DateTime
        /// </summary>
        /// <param name="personID"></param>
        /// <returns></returns>
        internal LinkedList<SalesTransactionModel> GetReport(DateTime startDate, DateTime endDate)
        {
            return this.GetReport(null, startDate, endDate);
        }
    }
}