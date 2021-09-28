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
    public partial class PassengerMastercs : Form
    {
        private PassengerDTO passengerDTO;
        private PassengerBL passengerBL;

        public PassengerMastercs()
        {
            InitializeComponent();
            passengerDTO = new PassengerDTO();
            passengerBL = new PassengerBL();
            populate();
        }

        private void btn_addPassenger_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (txt_pName.Text == "" || txt_pAddress.Text == "" || txt_pPhone.Text == "")
            {
                MessageBox.Show("Enter Missing Information");
            }
            else
            {
                if (rb_Male.Checked == true)
                {
                    gender = "Male";
                }
                else if (rb_female.Checked == true)
                {
                    gender = "female";
                }
                passengerDTO.PName = txt_pName.Text;
                passengerDTO.PAddress = txt_pAddress.Text;
                passengerDTO.PPhone = txt_pPhone.Text;
                passengerDTO.PGender = gender;
                MessageBox.Show(passengerBL.InsertData(passengerDTO), "Passenger Master", MessageBoxButtons.OK);
                populate();
                reset();
            }
        }
        public void populate()
        {
            DataSet ds = passengerBL.GetAllPassengers();
            Passenger_dataGrid.DataSource = ds.Tables[0];
        }
        private void reset()
        {
            txt_pAddress.Clear();
            txt_pName.Clear();
            txt_pPhone.Clear();
            key = 0;
            rb_female.Checked = false;
            rb_Male.Checked = false;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }
        int key = 0;
        private void Passenger_dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txt_pName.Text = Passenger_dataGrid.SelectedRows[0].Cells[1].Value.ToString();
                txt_pAddress.Text = Passenger_dataGrid.SelectedRows[0].Cells[2].Value.ToString();
                txt_pPhone.Text = Passenger_dataGrid.SelectedRows[0].Cells[4].Value.ToString();
                if (txt_pName.Text == "")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(Passenger_dataGrid.SelectedRows[0].Cells[0].Value.ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_editPassenger_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (txt_pName.Text == "" || txt_pAddress.Text == "" || txt_pPhone.Text == "")
            {
                MessageBox.Show("Enter Missing Information");
            }
            else
            {
                if (rb_Male.Checked == true)
                {
                    gender = "Male";
                }
                else if (rb_female.Checked == true)
                {
                    gender = "female";
                }
                passengerDTO.PName = txt_pName.Text;
                passengerDTO.PAddress = txt_pAddress.Text;
                passengerDTO.PPhone = txt_pPhone.Text;
                passengerDTO.PGender = gender;
                MessageBox.Show(passengerBL.UpdateData(passengerDTO, key), "Passenger Master", MessageBoxButtons.OK);
                populate();
                reset();
            }
        }

        private void btn_deletePassenger_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select The Train to be Deleted");
            }
            else
            {
                MessageBox.Show(passengerBL.RemovePassenger(key), "Passenger Master", MessageBoxButtons.OK);
                reset();
                populate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm main = new mainForm();
            main.Show();
            this.Hide();
        }

        private void PassengerMastercs_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
