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
    public partial class CancellationMaster : Form
    {
        private CancellationBL cancellationBL;
        private CancellationDTO cancellationDTO;
        public CancellationMaster()
        {
            InitializeComponent();
            cancellationBL = new CancellationBL();
            cancellationDTO = new CancellationDTO();
            AddTickets();
            populate();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void populate()
        {
            DataSet ds = cancellationBL.GetTickets();
            Cancellation_dataGrid.DataSource = ds.Tables[0];
        }

        private void AddTickets()
        {
            cb_TicketID.ValueMember = "TicketId";
            cb_TicketID.DataSource = cancellationBL.GetTicketsFromDL();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if(cb_TicketID.SelectedIndex==-1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                AddTickets();
                cancellationDTO.TicketId = Convert.ToInt32(cb_TicketID.SelectedValue.ToString());
                MessageBox.Show(cancellationBL.InsertData(cancellationDTO));
                AddTickets();
                populate();
                RemoveFromReservation();
            }
        }
        private void RemoveFromReservation()
        {
            cancellationBL.RemoveTicketFromReservation(cancellationDTO);
        }
        private void cb_TicketID_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm main = new mainForm();
            main.Show();
            this.Hide();
        }
    }
}
