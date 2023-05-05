using EntityLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDevelopmentInN_TierArchitectureWithOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtList_Click(object sender, EventArgs e)
        {
            List<Employee> employees = LogicEmployee.LLEmployeeList();
            DgvEmployeeList.DataSource = employees;
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee
            {
                Name = TbxName.Text,
                Surname = TbxSurname.Text,
                City = TbxCity.Text,
                Salary = Convert.ToInt16(TbxSalary.Text),
                State = (RbtT.Checked == true) ? true : (RbtF.Checked) == true ? false : false,
                Job = TbxJop.Text
            };
            LogicEmployee.LLAddEmployee(employee);
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee
            {
                Id = Convert.ToInt32(TbxId.Text)
            };
            LogicEmployee.LLDeleteEmployee(employee.Id);
        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee
            {
                Id = Convert.ToInt32(TbxId.Text),
                Name = TbxName.Text,
                Surname = TbxSurname.Text,
                City = TbxCity.Text,
                Salary = Convert.ToInt16(TbxSalary.Text),
                State = (RbtT.Checked == true) ? true : (RbtF.Checked == true) ? false : false,
                Job = TbxJop.Text
            };
            LogicEmployee.LLUpdateEmployee(employee);
        }

        private void DgvEmployeeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TbxId.Text = DgvEmployeeList.Rows[e.RowIndex].Cells[0].Value.ToString();
            TbxName.Text = DgvEmployeeList.Rows[e.RowIndex].Cells[1].Value.ToString();
            TbxSurname.Text = DgvEmployeeList.Rows[e.RowIndex].Cells[2].Value.ToString();
            TbxCity.Text = DgvEmployeeList.Rows[e.RowIndex].Cells[3].Value.ToString();
            TbxSalary.Text = DgvEmployeeList.Rows[e.RowIndex].Cells[4].Value.ToString();
            if ((Boolean)DgvEmployeeList.Rows[e.RowIndex].Cells[5].Value == true)
            {
                RbtT.Checked = true;
                RbtF.Checked = !RbtT.Checked;
            }
            else
            {
                RbtF.Checked = true;
                RbtT.Checked = !RbtF.Checked;
            }
            TbxJop.Text = DgvEmployeeList.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
