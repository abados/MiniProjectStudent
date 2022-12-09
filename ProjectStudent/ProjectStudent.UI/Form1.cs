using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectStudent.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Entities.StudentsManager.LoadStudents();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        
            Entities.StudentsManager.addToHashTableOfStudent(int.Parse(txtID.Text), int.Parse(txtAge.Text), txtName.Text, txtAddress.Text);
            Entities.StudentsManager.addToStudentDB(txtID.Text, txtAge.Text, txtName.Text, txtAddress.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Model.Student s = Entities.StudentsManager.searchAndBringData(int.Parse(txtID.Text));
            if(s!=null)
            { 
            txtAge.Text = s.Age.ToString();
            txtName.Text = s.Name.ToString();
            txtAddress.Text = s.Address.ToString();
            }
            else
            {
                MessageBox.Show("there isn't a student with this ID number");
            }
        }
    }
}
