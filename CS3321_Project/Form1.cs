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
<<<<<<< HEAD
    public partial class FrmMain : Form
    {
        public static Database Data = new Database();
        public FrmMain()
=======
    public partial class frmProfessorDetail : Form
    {
        public frmProfessorDetail()
>>>>>>> pr/5
        {
            InitializeComponent();
        }

        private void frmProfessorDetail_Load(object sender, EventArgs e)
        {

<<<<<<< HEAD
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
=======
>>>>>>> pr/5
        }
    }
}
