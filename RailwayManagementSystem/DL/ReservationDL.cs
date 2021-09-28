using RailwayManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailwayManagementSystem.DL
{
    class ReservationDL
    {
        private DBConnection db_connection;
        public ReservationDL()
        {
            db_connection = new DBConnection();
        }
        public DataTable GetPassengerCode()
        {
            try
            {
                db_connection.Con.Open();
                string queryString = "Select Id from PassengerTbl";
                SqlCommand sqlCommand = new SqlCommand(queryString, db_connection.Con);
                SqlDataReader reader;
                reader = sqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
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
        public DataTable GetTravelCode()
        {
            try
            {
                db_connection.Con.Open();
                string queryString = "Select TravCode from TravelTbl";
                SqlCommand sqlCommand = new SqlCommand(queryString, db_connection.Con);
                SqlDataReader reader;
                reader = sqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("TravCode", typeof(int));
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
        public DataTable GetPassengerNamesFromDB(ReservationDTO reservationDTO)
        {
            try
            {
                db_connection.Con.Open();
                string queryString = "Select * from PassengerTbl where Id=@Id";
                SqlCommand sqlCommand = new SqlCommand(queryString, db_connection.Con);
                sqlCommand.Parameters.AddWithValue("@Id", reservationDTO.PID);
                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                db_connection.Con.Close();
            }
        }
        public DataTable GetTravelDetailsFromDB(ReservationDTO reservationDTO)
        {
            try
            {
                db_connection.Con.Open();
                string queryString = "Select * from TravelTbl where TravCode=@TravCode";
                SqlCommand sqlCommand = new SqlCommand(queryString, db_connection.Con);
                sqlCommand.Parameters.AddWithValue("@TravCode", reservationDTO.TravCode);
                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                db_connection.Con.Close();
            }
        }
        public string InsertIntoDB(ReservationDTO reservationDTO)
        {
            try
            {
                db_connection.Con.Open();
                string queryString1 = "INSERT INTO ReservationTbl VALUES(@Pid, @Pname , @TravCode, @TravDate, @TravSrc, @TravDest, @TravCost);";
                SqlCommand com = new SqlCommand(queryString1, db_connection.Con);
                com.Parameters.AddWithValue("@Pid", reservationDTO.PID);
                com.Parameters.AddWithValue("@Pname", reservationDTO.Name);
                com.Parameters.AddWithValue("@TravCode", reservationDTO.TravCode);
                com.Parameters.AddWithValue("@TravDate", reservationDTO.Travdate);
                com.Parameters.AddWithValue("@TravSrc", reservationDTO.TravSrc);
                com.Parameters.AddWithValue("@TravDest", reservationDTO.TravDest);
                com.Parameters.AddWithValue("@TravCost", reservationDTO.TravCost);
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
        public DataSet GetCurrentReservations()
        {

            try
            {
                db_connection.Con.Open();
                string queryString = "Select * from ReservationTbl";
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

    }
}
