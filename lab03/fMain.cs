using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace lab03
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student(); fStudent ft = new fStudent(student);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                tbStudentInfo.Text +=
                    string.Format("Ім'я: {0}, \nПрізвище: {1}, \nВік: {2}, \nНазва Університету: {3}, \nСпеціальність: {4}, \nРік навчання: {5}," +
                    " \nОцінка 1: {6}, \nОцінка 2: {7}, \nОцінка 3: {8}, \nСередній бал: {9}, \n{10}",
                    student.Name, student.Surname, student.Age, student.University, student.Specialty, student.Year, student.Rating1, student.Rating2, student.Rating3,
                    student.CalculateAverageGrade(), student.Scholarship ? "Отримує стипендію" : "Не отримує стипендію");
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку ? ", "Припинити роботу", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}
