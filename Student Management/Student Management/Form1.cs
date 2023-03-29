using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Management
{
    public partial class frmMain : Form
    {
        string flag;
        DataTable dtSV;
        int index;

        public frmMain()
        {
            InitializeComponent();
        }

        public DataTable createTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("PersonID");
            dt.Columns.Add("StudentCode");
            dt.Columns.Add("Age");
            dt.Columns.Add("Class");
            dt.Columns.Add("Email");
            return dt;
        }

        public void LockControl()
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;

            btnSave.Enabled = false;
            btnExit.Enabled = false;

            txtName.ReadOnly = true;
            txtAge.ReadOnly = true;
            txtClass.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtPersonID.ReadOnly = true;
            txtStudentCode.ReadOnly = true;

            btnAdd.Focus();
        }

        public void UnlockControl()
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            btnSave.Enabled = true;
            btnExit.Enabled = true;

            txtName.ReadOnly = false;
            txtAge.ReadOnly = false;
            txtClass.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtPersonID.ReadOnly = false;
            txtStudentCode.ReadOnly = false;

           txtName.Focus();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LockControl();
            dtSV = createTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UnlockControl();
            flag = "add";

            txtName.Text = "";
            txtAge.Text = "";
            txtClass.Text = "";
            txtEmail.Text = "";
            txtPersonID.Text = "";
            txtStudentCode.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UnlockControl();
            flag = "edit";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int nextID = dtSV.Rows.Count + 1;

            if (flag == "add")
            {
                if (CheckData())
                {
                    dtSV.Rows.Add(nextID, txtName.Text, txtPersonID.Text, txtStudentCode.Text, txtAge.Text, txtClass.Text, txtEmail.Text);
                    dataGridStudent.DataSource = dtSV;
                    dataGridStudent.RefreshEdit();
                }
            }
            else if(flag == "edit")
            {
                if (CheckData())
                {
                    dtSV.Rows[index][1] = txtName.Text;
                    dtSV.Rows[index][2] = txtPersonID.Text;
                    dtSV.Rows[index][3] = txtStudentCode.Text;
                    dtSV.Rows[index][4] = txtAge.Text;
                    dtSV.Rows[index][5] = txtClass.Text;
                    dtSV.Rows[index][6] = txtEmail.Text;
                    dataGridStudent.DataSource = dtSV;
                    dataGridStudent.RefreshEdit();
                }
            }
            LockControl();
        }

        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Ban chua nhap ten sinh vien", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtAge.Text))
            {
                MessageBox.Show("Ban chua nhap tuoi sinh vien", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAge.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtClass.Text))
            {
                MessageBox.Show("Ban chua nhap lop sinh vien", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtClass.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPersonID.Text))
            {
                MessageBox.Show("Ban chua nhap Person ID sinh vien", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPersonID.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtStudentCode.Text))
            {
                MessageBox.Show("Ban chua nhap ma sinh vien", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStudentCode.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Ban chua nhap Email sinh vien", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return false;
            }
            return true;
        }

        private void dataGridStudent_SelectionChanged(object sender, EventArgs e)
        {
            index = dataGridStudent.CurrentCell.RowIndex;
            DataTable dt = (DataTable)dataGridStudent.DataSource;
            if (dt.Rows != null || dt.Rows.Count > 0)
            {
                txtName.Text = dataGridStudent.Rows[index].Cells[1].Value.ToString();
                txtPersonID.Text = dataGridStudent.Rows[index].Cells[2].Value.ToString();
                txtStudentCode.Text = dataGridStudent.Rows[index].Cells[3].Value.ToString();
                txtAge.Text = dataGridStudent.Rows[index].Cells[4].Value.ToString();
                txtClass.Text = dataGridStudent.Rows[index].Cells[5].Value.ToString();
                txtEmail.Text = dataGridStudent.Rows[index].Cells[6].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ban co uon xoa sinh vien nay?","Canh Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dtSV.Rows.RemoveAt(index);
                dataGridStudent.DataSource = dtSV;
                dataGridStudent.RefreshEdit();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search(txtSearch.Text);
        }

        private void Search(string searchTerm)
        {
            // Clear the current selection
            dataGridStudent.ClearSelection();

            // Set a flag to track if any rows are selected
            bool found = false;

            // Loop through each row in the data table
            foreach (DataGridViewRow row in dataGridStudent.Rows)
            {
                // Loop through each cell in the row
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // If the cell contains the search term, select the row
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchTerm.ToLower()))
                    {
                        row.Selected = true;
                        found = true;
                        break;
                    }
                }

                // If a row is selected, break out of the outer loop
                if (found)
                {
                    break;
                }
            }

            // If no rows were selected, display a message
            if (!found)
            {
                MessageBox.Show("No matching records found.");
            }
        }

    }
}
