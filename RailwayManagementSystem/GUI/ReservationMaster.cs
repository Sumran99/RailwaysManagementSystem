using RailwayManagementSystem.BL;
using RailwayManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailwayManagementSystem
{
    public partial class ReservationMaster : Form
    {
        private ReservationBL reservationBL;
        private ReservationDTO reservationDTO;
        public ReservationMaster()
        {
            InitializeComponent();
            reservationBL = new ReservationBL();
            reservationDTO = new ReservationDTO();
            AddPassengerCodes();
            AddTravelCodes();
            populate();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AddPassengerCodes()
        {
            cb_PassengerID.ValueMember = "Id";
            cb_PassengerID.DataSource = reservationBL.GetAllPassengerCode();
        }
        private void AddTravelCodes()
        {
            cb_TravelCode.ValueMember = "TravCode";
            cb_TravelCode.DataSource = reservationBL.GetAllTravelCode();
        }
       
        public void GetTravel()
        {
            reservationDTO.TravCode = Int32.Parse(cb_TravelCode.SelectedValue.ToString());
            DataTable table = reservationBL.GetTravelDetails(reservationDTO);
            foreach(DataRow dataRow in table.Rows)
            {
                Convert.ToDateTime(reservationDTO.Travdate = dataRow["TravDate"].ToString());
                reservationDTO.TravSrc = dataRow["Src"].ToString();
                reservationDTO.TravDest = dataRow["Dest"].ToString();
                reservationDTO.TravCost = Convert.ToInt32(dataRow["Cost"].ToString());

            }
        }
        public void GetNames()
        {
            
            reservationDTO.PID = Int32.Parse(cb_PassengerID.SelectedValue.ToString());
            DataTable table = reservationBL.GetPassengerNames(reservationDTO);
            foreach (DataRow dataRow in table.Rows)
            {
                reservationDTO.Name = dataRow["Name"].ToString();
                
            }
        }


        private void cb_TravelCode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTravel();
        }

        private void cb_PassengerID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetNames();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(cb_PassengerID.SelectedIndex==-1 || cb_TravelCode.SelectedIndex==-1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                MessageBox.Show(reservationBL.InsertData(reservationDTO), "Reservation Master", MessageBoxButtons.OK);
                populate();
            }
        }

        
      
        public void populate()
        {
            DataSet ds = reservationBL.GetReservation();
            Reservation_dataGrid.DataSource = ds.Tables[0];
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm main = new mainForm();
            main.Show();
            this.Hide();
        }
    }
}
