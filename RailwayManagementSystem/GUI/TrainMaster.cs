using RailwayManagementSystem.BL;
using RailwayManagementSystem.DL;
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
    public partial class TrainMaster : Form
    {
        private TrainDTO trainDTO;
        private TrainBL trainBL;
        

        public TrainMaster()
        {
            InitializeComponent();
            trainDTO = new TrainDTO();
            trainBL = new TrainBL();
            populate();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string trStatus = "";
            if(txt_trainName.Text == "" || txt_trainCapacity.Text == "")
            {
                MessageBox.Show("Enter Missing Information");
            }
            else
            {
                if(rb_busy.Checked == true)
                {
                    trStatus = "Busy";
                }
                else if(rb_available.Checked == true)
                {
                    trStatus = "Available";
                }
                trainDTO.TrainName = txt_trainName.Text;
                trainDTO.TrainCapacity = int.Parse(txt_trainCapacity.Text);
                trainDTO.TrainStatus = trStatus;
                MessageBox.Show(trainBL.InsertData(trainDTO), "Train Master", MessageBoxButtons.OK);
                populate();
                reset();
            }
        }

        public void populate()
        {
            DataSet ds = trainBL.GetAllTrains();
            Train_dataGrid.DataSource = ds.Tables[0];
        }

        private void TrainMaster_Load(object sender, EventArgs e)
        {

        }

        private void reset()
        {
            txt_trainName.Clear();
            txt_trainCapacity.Clear();
            rb_available.Checked = false;
            rb_busy.Checked = false;
            key = 0;
        }
        private void btn_trainReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int key = 0;
        private void Train_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            txt_trainName.Text = Train_dataGrid.SelectedRows[0].Cells[1].Value.ToString();
            txt_trainCapacity.Text = Train_dataGrid.SelectedRows[0].Cells[2].Value.ToString();
            if (txt_trainName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(Train_dataGrid.SelectedRows[0].Cells[0].Value.ToString());
            }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_trainDelete_Click(object sender, EventArgs e)
        {
            if(key == 0)
            {
                MessageBox.Show("Select The Train to be Deleted");
            }
            else
            {
                MessageBox.Show(trainBL.RemoveTrain(key), "Train Master", MessageBoxButtons.OK);
                reset();
                populate();
            }
        }

        private void btn_trainEdit_Click(object sender, EventArgs e)
        {
            string trStatus = "";
            if (txt_trainName.Text == "" || txt_trainCapacity.Text == "")
            {
                MessageBox.Show("Enter Missing Information");
            }
            else
            {
                if (rb_busy.Checked == true)
                {
                    trStatus = "Busy";
                }
                else if (rb_available.Checked == true)
                {
                    trStatus = "Available";
                }
                trainDTO.TrainName = txt_trainName.Text;
                trainDTO.TrainCapacity = int.Parse(txt_trainCapacity.Text);
                trainDTO.TrainStatus = trStatus;
                MessageBox.Show(trainBL.UpdateTrainDetails(trainDTO, key), "Train Master", MessageBoxButtons.OK);
                populate();
                reset();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mainForm main = new mainForm();
            main.Show();
            this.Hide();
        }
    }
}
