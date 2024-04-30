using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Autorisation : Form
    {
        public Autorisation()
        {
            InitializeComponent();
        }
        private Form acriveForm = null;
        private void OpenForm(Form childForm)
        {
            if (acriveForm != null)
                acriveForm.Close();
            acriveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            GroupBoxAutorisation.Controls.Add(childForm);
            GroupBoxAutorisation.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenForm(new RegistrationForm());
        }

        private void Autorisation_Load(object sender, EventArgs e)
        {
            OpenForm(new AutorisationForm());
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(new AutorisationForm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}