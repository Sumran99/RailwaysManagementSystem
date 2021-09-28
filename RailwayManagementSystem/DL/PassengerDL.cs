using RailwayManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayManagementSystem.DL
{
    class PassengerDL
    {
        private DBConnection db_connection;
        public PassengerDL()
        {
            db_connection = new DBConnection();
        }
        public string InsertIntoDB(PassengerDTO passengerDTO)
        {
            try
            {
                db_connection.Con.Open();
                string queryString1 = "INSERT INTO PassengerTbl VALUES(@Name, @Address , @Gender, @Phone);";

                SqlCommand com = new SqlCommand(queryString1, db_connection.Con);
                com.Parameters.AddWithValue("@Name", passengerDTO.PName);
                com.Parameters.AddWithValue("@Address", passengerDTO.PAddress);
                com.Parameters.AddWithValue("@Gender", passengerDTO.PGender);
                com.Parameters.AddWithValue("@Phone", passengerDTO.PPhone);
                int rowAffected = com.ExecuteNonQuery();
                return "Added Succesfully";

            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
            finally
            {
                db_connection.Con.Close();
            }
        }
        public DataSet GetCurrentPassengers()
        {

            try
            {
                db_connection.Con.Open();
                string queryString = "Select * from PassengerTbl";
                SqlDataAdapter sda = new SqlDataAdapter(queryString, db_connection.Con);
                var ds = new DataSet();
                sda.Fill(ds);
                return ds;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                db_connection.Con.Close();
            }
        }
        public string UpdatePassengerInDB(PassengerDTO passengerDTO, int primaryKey)
        {
            try
            {
                db_connection.Con.Open();
                string queryString = "Update PassengerTbl SET Name=@Name, Address=@Address, Gender=@Gender, Phone=@Phone WHERE Id = @Id";
                SqlCommand com = new SqlCommand(queryString, db_connection.Con);
                com.Parameters.AddWithValue("@Name", passengerDTO.PName);
                com.Parameters.AddWithValue("@Address", passengerDTO.PAddress);
                com.Parameters.AddWithValue("@Gender", passengerDTO.PGender);
                com.Parameters.AddWithValue("@Phone", passengerDTO.PPhone);
                com.Parameters.AddWithValue("@Id", primaryKey);
                int val = com.ExecuteNonQuery();
                return "Updated Successfully";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db_connection.Con.Close();
            }
        }

        public string RemovePassengerFromDB(int primaryKey)
        {
            try
            {
                db_connection.Con.Open();
                string queryDel = "Delete FROM PassengerTbl WHERE Id= @PassengerId";
                SqlCommand com = new SqlCommand(queryDel, db_connection.Con);
                com.Parameters.AddWithValue("@PassengerId", primaryKey);
                com.CommandText = queryDel;
                int rowAffected = com.ExecuteNonQuery();
                return "Passenger Removed Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db_connection.Con.Close();
            }
        }

    }
}
