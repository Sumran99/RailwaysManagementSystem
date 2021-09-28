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
    class TravelDL
    {
        private DBConnection db_connection;
        public TravelDL()
        {
            db_connection = new DBConnection();
        }
        public DataSet GetCurrentSchedule()
        {

            try
            {
                db_connection.Con.Open();
                string queryString = "Select * from TravelTbl";
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
        public DataTable GetTrainCode()
        {
            try
            {
                db_connection.Con.Open();
                string queryString = "Select TrainId from TrainTbl where TrainStatus=@TrainStatus";
                SqlCommand sqlCommand = new SqlCommand(queryString, db_connection.Con);
                sqlCommand.Parameters.AddWithValue("@TrainStatus", "Available");
                SqlDataReader reader;
                reader = sqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("TrainId", typeof(int));
                dataTable.Load(reader);
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

        public string InsertIntoDB(TravelDTO travelDTO)
        {
            try
            {
                db_connection.Con.Open();
                string queryString1 = "INSERT INTO TravelTbl VALUES(@TravDate, @Train , @Src, @Dest, @Cost);";

                SqlCommand com = new SqlCommand(queryString1, db_connection.Con);
                com.Parameters.AddWithValue("@TravDate", travelDTO.DateTime);
                com.Parameters.AddWithValue("@Train", Int32.Parse(travelDTO.TrainCode));
                com.Parameters.AddWithValue("@Src", travelDTO.TrainSource);
                com.Parameters.AddWithValue("@Dest", travelDTO.TrainDestination);
                com.Parameters.AddWithValue("@Cost", travelDTO.TrainCost);
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
        public string changeTrainStatusInDB(int key)
        {
            try
            {
                db_connection.Con.Open();
                string queryString = "Update TrainTbl set TrainStatus=@TrainStatus where TrainId=@TrainId";
                SqlCommand com = new SqlCommand(queryString, db_connection.Con);

                com.Parameters.AddWithValue("@TrainStatus", "Busy");
                com.Parameters.AddWithValue("@TrainId", key);
                int val = com.ExecuteNonQuery();
                return "";

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
        public string UpdateScheduleInDB(TravelDTO travelDTO, int primaryKey)
        {
            try
            {
                db_connection.Con.Open();
                string queryString = "Update TravelTbl SET TravDate=@TravDate, Train=@Train, Src=@Src, Dest=@Dest, Cost=@Cost WHERE TravCode = @TravCode";
                SqlCommand com = new SqlCommand(queryString, db_connection.Con);

                com.Parameters.AddWithValue("@TravDate", travelDTO.DateTime);
                com.Parameters.AddWithValue("@Train", Int32.Parse(travelDTO.TrainCode));
                com.Parameters.AddWithValue("@Src", travelDTO.TrainSource);
                com.Parameters.AddWithValue("@Dest", travelDTO.TrainDestination);
                com.Parameters.AddWithValue("@Cost", travelDTO.TrainCost);
                com.Parameters.AddWithValue("@TravCode", primaryKey);

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
    }
}
