using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3321_Project
{
    public partial class FrmMain : Form
    {
        public static Database Data = new Database();
        public FrmMain()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (Data.CheckUserLogin(txtUser.Text, txtPassword.Text))
            {
                MessageBox.Show(@"Login Successfully");
                FrmUserDetail frm = new FrmUserDetail
                {
                    Data = Data,
                    UserId = txtUser.Text
                };
                this.Hide();
                frm.ShowDialog();
                
            } else
            {
                MessageBox.Show(@"Login Failed");
            } 
        }
    }
}
