using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.StudentInfoClass;

namespace WindowsFormsApp1
{
    public partial class FrmConfirm : Form
    {

        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;

      

        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        public FrmConfirm()
        {
            InitializeComponent();
        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            DelProgram = new DelegateText(GetProgram);
            DelLastName = new DelegateText(GetLastName);
            DelFirstName = new DelegateText(GetFirstName);
            DelMiddleName = new DelegateText(GetMiddleName);
            DelAddress = new DelegateText(GetAddress);
            DelNumAge = new DelegateNumber(GetAge);
            DelNumContactNo = new DelegateNumber(GetContactNo);
            DelStudNo = new DelegateNumber(GetStudentNo);

            labelFirstName.Text = DelFirstName(FirstName);
            labelLastName.Text = DelLastName(LastName);
            labelMiddleName.Text = DelMiddleName(MiddleName);
            labelAddress.Text = DelAddress(Address);
            labelProgram.Text = DelProgram(StudentInfoClass.Program);
            labelAge.Text = DelNumAge(Age).ToString();
            labelContactNo.Text = DelNumContactNo(ContactNo).ToString();
            labelStudentNo.Text = DelStudNo(StudentNo).ToString();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
