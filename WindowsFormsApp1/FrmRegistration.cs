using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();

            comboBoxProgram.Items.Add("BSIT");
            comboBoxProgram.Items.Add("BSCS");
            comboBoxProgram.Items.Add("BSHM");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            StudentInfoClass.FirstName = textBoxFirstName.Text;
            StudentInfoClass.LastName = textBoxLastName.Text;
            StudentInfoClass.MiddleName = textBoxMiddleName.Text;
            StudentInfoClass.Address = richTextBoxAddress.Text;
            StudentInfoClass.Program = comboBoxProgram.Text;
            StudentInfoClass.Age = Convert.ToInt64(textBoxAge.Text);
            StudentInfoClass.ContactNo = Convert.ToInt64(textBoxContactNo.Text);
            StudentInfoClass.StudentNo = Convert.ToInt64(textBoxStudentNo.Text);

            FrmConfirm confirmForm = new FrmConfirm();

            confirmForm.ShowDialog();

            if (confirmForm.ShowDialog() == DialogResult.OK)
            {
                textBoxFirstName.Clear();
                textBoxLastName.Clear();
                textBoxMiddleName.Clear();
                richTextBoxAddress.Clear();
                comboBoxProgram.SelectedIndex = -1;
                textBoxAge.Clear();
                textBoxContactNo.Clear();
                textBoxStudentNo.Clear();
            }



        }
    }
}
