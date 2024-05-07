using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private Form acriveForm = null;
        private void openForm(Form childForm)
        {
            if (acriveForm != null)
                acriveForm.Close();
            acriveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            openForm(new UserForm());
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            openForm(new ClientForm());
        }

        private void AbonementButton_Click(object sender, EventArgs e)
        {
            openForm(new AbonementForm());
        }

        private void TrainerButton_Click(object sender, EventArgs e)
        {
            openForm(new TrainerForm());
        }
    }
}
