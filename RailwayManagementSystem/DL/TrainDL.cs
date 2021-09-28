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
    class TrainDL
    {
        DBConnection  dbCon;
        public TrainDL()
        {
            dbCon = new DBConnection();

        }
        public string InsertIntoDB(TrainDTO trainDTO)
        {
            try
            {
                dbCon.Con.Open();
                string queryString1 = "INSERT INTO TrainTbl VALUES(@TrainName, @TrainCap , @TrainStatus);";

                SqlCommand com = new SqlCommand(queryString1, dbCon.Con);
                com.Parameters.AddWithValue("@TrainName", trainDTO.TrainName);
                com.Parameters.AddWithValue("@TrainCap", trainDTO.TrainCapacity);
                com.Parameters.AddWithValue("@TrainStatus", trainDTO.TrainStatus);
                int rowAffected = com.ExecuteNonQuery();
                return "Added Succesfully";
                
            }catch (SqlException ex)
            {
                return ex.Message;
            }
            finally
            {
                dbCon.Con.Close();
            }
          
        }
        public DataSet GetCurrentTrains()
        {
            
            try
            {
                dbCon.Con.Open();
                string queryString = "Select * from TrainTbl";
                SqlDataAdapter sda = new SqlDataAdapter(queryString, dbCon.Con);
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
                dbCon.Con.Close();
            }
        }
        public string RemoveTrainFromDB(int primaryKey)
        {
            try
            {
                dbCon.Con.Open();
                string queryDel = "Delete FROM TrainTbl WHERE TrainId= @TrainId";
                SqlCommand com = new SqlCommand(queryDel, dbCon.Con);
                com.Parameters.AddWithValue("@TrainId", primaryKey);
                com.CommandText = queryDel;
                int rowAffected = com.ExecuteNonQuery();
                return "Train Deleted Successfully";
            }catch(Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                dbCon.Con.Close();
            }
        }
        public string UpdateTrainInDB(TrainDTO trainDTO, int primaryKey)
        {
            try
            {
                dbCon.Con.Open();
                string queryString = "Update TrainTbl SET TrainName=@TrainName, TrainCap=@TrainCap, TrainStatus=@TrainStatus WHERE TrainId = @TrainId";
                SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                com.Parameters.AddWithValue("@TrainName", trainDTO.TrainName);
                com.Parameters.AddWithValue("@TrainCap", trainDTO.TrainCapacity);
                com.Parameters.AddWithValue("@TrainStatus", trainDTO.TrainStatus);
                com.Parameters.AddWithValue("@TrainId", primaryKey);
                int val = com.ExecuteNonQuery();
                return "Updated Successfully";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                dbCon.Con.Close();
            }
        }
    }
}
