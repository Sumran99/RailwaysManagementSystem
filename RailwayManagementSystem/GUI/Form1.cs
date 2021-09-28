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
    public partial class Form1 : Form
    {
        private LoginDTO loginDTO;
        private LoginBL loginBL;
        public Form1()
        {
            InitializeComponent();
            loginDTO = new LoginDTO();
            loginBL = new LoginBL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!(txt_username.Text == "" || txt_password.Text == "") )
            {
                loginDTO.Username = txt_username.Text;
                loginDTO.Password = txt_password.Text;
                if (loginBL.verifyUser(loginDTO))
                {
                    mainForm main = new mainForm();
                    main.Show();
                    this.Hide();
                    
                }
                else
                { 
                    MessageBox.Show("Wrong username or password");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
