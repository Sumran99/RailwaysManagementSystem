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
    public partial class TravelMastercs : Form
    {
        private TravelBL travelBL;
        TravelDTO travelDTO;
        public TravelMastercs()
        {
            InitializeComponent();
            travelBL = new TravelBL();
            travelDTO = new TravelDTO();
            AddTrainCodes();
            populate();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void populate()
        {
            DataSet ds = travelBL.GetSchedule();
            Travel_dataGrid.DataSource = ds.Tables[0];
        }
        private void AddTrainCodes()
        {
            cb_TrainCode.ValueMember = "TrainId";
            cb_TrainCode.DataSource = travelBL.GetTrainCodes();

        }
        int key = 0;
        private void Travel_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                dateTime_Travel.Text = Travel_dataGrid.SelectedRows[0].Cells[1].Value.ToString();
                cb_TrainCode.SelectedValue = Travel_dataGrid.SelectedRows[0].Cells[2].Value.ToString();
                cb_TrainSource.SelectedItem = Travel_dataGrid.SelectedRows[0].Cells[3].Value.ToString();
                cb_TrainDestination.SelectedItem = Travel_dataGrid.SelectedRows[0].Cells[4].Value.ToString();
                txt_Cost.Text = Travel_dataGrid.SelectedRows[0].Cells[5].Value.ToString();
                if (cb_TrainCode.SelectedIndex == -1)
                {
                    key = 0;
                    
                }
                else
                {
                    key = Convert.ToInt32(Travel_dataGrid.SelectedRows[0].Cells[0].Value.ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cb_TrainSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (cb_TrainSource.SelectedItem.ToString().Equals("Lahore"))
                {
                    cb_TrainDestination.Items.Remove("Lahore");
                }
                else if (cb_TrainSource.SelectedItem.ToString().Equals("Karachi"))
                {
                    cb_TrainDestination.Items.Remove("Karachi");
                }
                else if (cb_TrainSource.SelectedItem.ToString().Equals("Islamabad"))
                {
                    cb_TrainDestination.Items.Remove("Islamabad");
                }
                else if (cb_TrainSource.SelectedItem.ToString().Equals("Jhang"))
                {
                    cb_TrainDestination.Items.Remove("Jhang");
                }
                else if (cb_TrainSource.SelectedItem.ToString().Equals("Sialkot"))
                {
                    cb_TrainDestination.Items.Remove("Sialkot");
                }
                else if (cb_TrainSource.SelectedItem.ToString().Equals("Multan"))
                {
                    cb_TrainDestination.Items.Remove("Multan");
                }
                else if (cb_TrainSource.SelectedItem.ToString().Equals("Gujrat"))
                {
                    cb_TrainDestination.Items.Remove("Gujrat");
                }
                else if (cb_TrainSource.SelectedItem.ToString().Equals("Quetta"))
                {
                    cb_TrainDestination.Items.Remove("Quetta");
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddTrainCodes();
            if (txt_Cost.Text == "" || cb_TrainCode.SelectedIndex == -1 || cb_TrainSource.SelectedIndex == -1 || cb_TrainDestination.SelectedIndex==-1)
            {
                MessageBox.Show("Enter Missing Information");
            }
            else
            {

                travelDTO.DateTime = dateTime_Travel.Value;
                travelDTO.TrainCode = cb_TrainCode.SelectedValue.ToString();
                travelDTO.TrainSource = cb_TrainSource.SelectedItem.ToString();
                travelDTO.TrainDestination = cb_TrainDestination.SelectedItem.ToString();
                travelDTO.TrainCost = txt_Cost.Text;

                MessageBox.Show(travelBL.InsertData(travelDTO), "Travel Master", MessageBoxButtons.OK);
                ChangeTrainStatusToBusy();
                AddTrainCodes();
                populate();
                
                

                reset();
            }
        }
        private void reset()
        {
            txt_Cost.Clear();
           // cb_TrainCode.SelectedIndex = -1;
            cb_TrainDestination.Text = "";
            cb_TrainSource.Text = "";
            key = 0;
        }
        private void ChangeTrainStatusToBusy()
        {
            travelBL.changeTrainStatus(Int32.Parse(cb_TrainCode.SelectedValue.ToString()));
        }
        private void brn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

            if (txt_Cost.Text == "" || cb_TrainCode.SelectedIndex == -1 || cb_TrainSource.SelectedIndex == -1 || cb_TrainDestination.SelectedIndex == -1)
            {
                MessageBox.Show("Enter Missing Information");
            }
            else
            {

                travelDTO.DateTime = dateTime_Travel.Value;
                travelDTO.TrainCode = cb_TrainCode.SelectedValue.ToString();
                travelDTO.TrainSource = cb_TrainSource.SelectedItem.ToString();
                travelDTO.TrainDestination = cb_TrainDestination.SelectedItem.ToString();
                travelDTO.TrainCost = txt_Cost.Text;

                MessageBox.Show(travelBL.UpdatSchedule(travelDTO, key), "Train Master", MessageBoxButtons.OK);
                populate();
                reset();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm main = new mainForm();
            main.Show();
            this.Hide();
        }

        private void cb_TrainCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TravelMastercs_Load(object sender, EventArgs e)
        {

        }
    }
}
