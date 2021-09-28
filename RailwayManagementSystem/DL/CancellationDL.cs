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
    class CancellationDL
    {
        private DBConnection db_connection;
        public CancellationDL()
        {
            db_connection = new DBConnection();
        }
        public DataSet GetCurrentTickets()
        {

            try
            {
                db_connection.Con.Open();
                string queryString = "Select * from CancellationTbl";
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
        public DataTable GetTicketsFromDB()
        {
            try
            {
                db_connection.Con.Open();
                string queryString = "Select TicketId from ReservationTbl";
                SqlCommand sqlCommand = new SqlCommand(queryString, db_connection.Con);
                SqlDataReader reader;
                reader = sqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("TicketId", typeof(int));
                dataTable.Load(reader);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db_connection.Con.Close();
            }
        }
        public string InsertIntoDB(CancellationDTO cancellationDTO)
        {
            try
            {
                db_connection.Con.Open();
                string queryString1 = "INSERT INTO CancellationTbl VALUES(@TickId, @CancDate);";
                SqlCommand com = new SqlCommand(queryString1, db_connection.Con);
                com.Parameters.AddWithValue("@TickId", cancellationDTO.TicketId);
                com.Parameters.AddWithValue("@CancDate", DateTime.Now);
                int rowAffected = com.ExecuteNonQuery();
                return "Ticket Cancelled";

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
        public void deleteFromReservation(CancellationDTO cancellationDTO)
        {
            try
            {
                db_connection.Con.Open();
                string queryDel = "Delete FROM ReservationTbl WHERE TicketId= @TicketId";
                SqlCommand com = new SqlCommand(queryDel, db_connection.Con);
                com.Parameters.AddWithValue("@TicketId", cancellationDTO.TicketId);
                com.CommandText = queryDel;
                int rowAffected = com.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db_connection.Con.Close();
            }
        }
    }
}
