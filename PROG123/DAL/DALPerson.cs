using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using PROG123.Models;

namespace PROG123.DAL
{
    /// <summary>
    /// PROG123 Class to query the PROG123 Database
    /// Here you will find all the methods to work with the Person Table
    /// </summary>
    public class DALPerson
    {
        public IConfiguration _configuration { get; }
        public DALPerson(IConfiguration configuration)
        {
            _configuration = configuration;
            
        }

        /// <summary>
        /// This method adds a person to the database
        /// </summary>
        /// <param name="personModel"></param>
        /// <returns>a string with the PersonID of the record that was just inserted into the DB</returns>
        public string AddPerson(PersonModel personModel)
        {
            //Step #1 - Connect to the DB
            string connStr = _configuration.GetConnectionString("MyConnString");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            //Step #2 - create a command
            string query = "INSERT INTO [dbo].[Person]([FName],[LName],[email],[phone],[address],[UserName],[Password])"
                + "VALUES(@FName,@LName,@email,@phone,@address,@UserName, @Password) select SCOPE_IDENTITY() as id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@FName", personModel.FName);
            cmd.Parameters.AddWithValue("@LName", personModel.LName);
            cmd.Parameters.AddWithValue("@email", personModel.Email);
            cmd.Parameters.AddWithValue("@phone", personModel.Phone);
            cmd.Parameters.AddWithValue("@address", personModel.Address);
            cmd.Parameters.AddWithValue("@UserName", personModel.UserName);
            cmd.Parameters.AddWithValue("@password", personModel.Password);

            //Step #3 - query the DB
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            //get the user ID
            string PersonID = reader[0].ToString();

            //Step #4 - close the connection
            conn.Close();

            return PersonID;
        }

        /// <summary>
        /// Deletes the record from the database based on the PersonID
        /// </summary>
        /// <param name="personID"></param>
        internal void DeletePerson(string personID)
        {
            //Step #1 - Connect to the DB
            string connStr = _configuration.GetConnectionString("MyConnString");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            //Step #2 - create a command
            string query = "DELETE FROM [dbo].[Person] WHERE PersonID = @PersonID;";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@PersonID", personID);

            //Step #3 - query the DB
            cmd.ExecuteNonQuery();

            //Step #6 - close the connection
            conn.Close();
        }

        /// <summary>
        /// This method gets all the columns from the Person Table
        /// </summary>
        /// <param name="personID"></param>
        /// <returns>PersonModel if the personID is valid. It returns null otherwise </returns>
        public PersonModel getPerson(string personID)
        {
            //Step #1 - Connect to the DB
            string connStr = _configuration.GetConnectionString("MyConnString");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            //Step #2 - create a command
            string query = "SELECT [FName],[LName],[email],[phone],[address],[UserName], [Password] "
                + "FROM [dbo].[Person] where PersonID = @PersonID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@PersonID", personID);

            //Step #3 - query the DB
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            PersonModel personModel = new PersonModel();
            personModel.FName = reader["FName"].ToString();
            personModel.LName = reader["LName"].ToString();
            personModel.Email = reader["email"].ToString();
            personModel.Phone = reader["phone"].ToString();
            personModel.Address = reader["address"].ToString();
            personModel.UserName = reader["UserName"].ToString();
            personModel.Password = reader["Password"].ToString();
            personModel.PersonID = personID.ToString();

            //Step #4 - close the connection
            conn.Close();

            return personModel;
        }

        /// <summary>
        /// Updates the Person Table with the properties of the PersonModel passed as parameter
        /// </summary>
        /// <param name="personModel"></param>
        public void UpdatePerson(PersonModel personModel)
        {
            //Step #1 - Connect to the DB
            string connStr = _configuration.GetConnectionString("MyConnString");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            //Step #2 - create a command
            string query = "UPDATE [dbo].[Person]SET " +
                "[FName] = @FName ," +
                "[LName] = @LName ," +
                "[email] = @email," +
                "[phone] = @phone," +
                "[address] = @address," +
                "[UserName] = @UserName, " +
                "[Password] = @Password " +
                "WHERE PersonID = @PersonID;";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@FName", personModel.FName);
            cmd.Parameters.AddWithValue("@LName", personModel.LName);
            cmd.Parameters.AddWithValue("@email", personModel.Email);
            cmd.Parameters.AddWithValue("@phone", personModel.Phone);
            cmd.Parameters.AddWithValue("@address", personModel.Address);
            cmd.Parameters.AddWithValue("@UserName", personModel.UserName);
            cmd.Parameters.AddWithValue("@PersonID", personModel.PersonID);
            cmd.Parameters.AddWithValue("@Password", personModel.Password);
     
            //Step #3 - query the DB
            cmd.ExecuteNonQuery();

            //Step #4 - close the connection
            conn.Close();
        }


      
        internal PersonModel CheckLogInCredentials(LogInCredentialsModel logInCredentialsModel)
        {
            //Step #1 - Connect to the DB
            string connStr = _configuration.GetConnectionString("MyConnString");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            //Step #2 - create a command
            string query = "SELECT * from Person " +
                " where UserName = @UserName AND Password = @Password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserName", logInCredentialsModel.UserName);
            cmd.Parameters.AddWithValue("@Password", logInCredentialsModel.UserPassword);

            PersonModel personModel = null;

            //Step #3 - query the DB
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                personModel = new PersonModel();
                
                personModel.FName = reader["FName"].ToString();
                personModel.LName = reader["LName"].ToString();
                personModel.Email = reader["email"].ToString();
                personModel.Phone = reader["phone"].ToString();
                personModel.Address = reader["address"].ToString();
                personModel.UserName = reader["UserName"].ToString();
                personModel.Password = reader["Password"].ToString();
                personModel.PersonID = reader["PersonID"].ToString();
            }

            //Step 4
            conn.Close();

            return personModel;
        }

       
    }
}
