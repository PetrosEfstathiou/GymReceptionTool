using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymReceptionTool
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEditMember myNewForm = new frmEditMember();
            myNewForm.Visible = true;
            this.Hide();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            frmAddMember myNewForm = new frmAddMember();
            myNewForm.Visible = true;
            this.Hide();
        }

        private void btnViewMember_Click(object sender, EventArgs e)
        {
            frmViewMember myNewForm = new frmViewMember();
            myNewForm.Visible = true;
            this.Hide();
        }

        private void btnAddNewInstructor_Click(object sender, EventArgs e)
        {
            frmAddInstructor myNewForm = new frmAddInstructor();
            myNewForm.Visible = true;
            this.Hide();
        }

        private void btnEditInstructor_Click(object sender, EventArgs e)
        {
            frmEditInstructor myNewForm = new frmEditInstructor();
            myNewForm.Visible = true;
            this.Hide();
        }

        private void btnCreateMembership_Click(object sender, EventArgs e)
        {
            frmCreateMembership myNewForm = new frmCreateMembership();
            myNewForm.Visible = true;
            this.Hide();
        }

        private void btnEditMembership_Click(object sender, EventArgs e)
        {
            frmEditMembership myNewForm = new frmEditMembership();
            myNewForm.Visible = true;
            this.Hide();
        }

        private void btwNewPayment_Click(object sender, EventArgs e)
        {
            frmAddPayment myNewForm = new frmAddPayment();
            myNewForm.Visible = true;
            this.Hide();
        }

        private void btnViewMemberPayments_Click(object sender, EventArgs e)
        {
            frmViewMember myNewForm = new frmViewMember();
            myNewForm.Visible = true;
            this.Hide();
        }

        private void btnAddtoMember_Click(object sender, EventArgs e)
        {
            frmAddMembership myNewForm = new frmAddMembership();
            myNewForm.Visible = true;
            this.Hide();
        }
    }
}
