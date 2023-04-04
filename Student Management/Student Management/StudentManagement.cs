using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            StyleDatagridView();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        void StyleDatagridView()
        {
            // Set up the DataGridView control
            dataGridStudent.BorderStyle = BorderStyle.None;
            dataGridStudent.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridStudent.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridStudent.DefaultCellStyle.SelectionBackColor = Color.FromArgb(67, 190, 105);
            dataGridStudent.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridStudent.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridStudent.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing; //optional
            dataGridStudent.EnableHeadersVisualStyles = false;
            dataGridStudent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridStudent.ColumnHeadersDefaultCellStyle.Font = new Font("MS Refernce Sans Serif", 10);
            dataGridStudent.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(61, 61, 63);
            dataGridStudent.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
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

        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtName.Texts))
            {
                MessageBox.Show("You have not entered your student name", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtAge.Texts))
            {
                MessageBox.Show("You have not entered your student age", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAge.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtClass.Texts))
            {
                MessageBox.Show("You have not entered your student classs", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtClass.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPersonID.Texts))
            {
                MessageBox.Show("You have not entered your Person ID", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPersonID.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtStudentCode.Texts))
            {
                MessageBox.Show("You have not entered your student code", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStudentCode.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Texts))
            {
                MessageBox.Show("You have not entered your student email", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtName.Texts = dataGridStudent.Rows[index].Cells[1].Value.ToString();
                txtPersonID.Texts = dataGridStudent.Rows[index].Cells[2].Value.ToString();
                txtStudentCode.Texts = dataGridStudent.Rows[index].Cells[3].Value.ToString();
                txtAge.Texts = dataGridStudent.Rows[index].Cells[4].Value.ToString();
                txtClass.Texts = dataGridStudent.Rows[index].Cells[5].Value.ToString();
                txtEmail.Texts = dataGridStudent.Rows[index].Cells[6].Value.ToString();
            }
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

                        // Update the textboxes with the values from the selected row
                        txtName.Texts = row.Cells[1].Value.ToString();
                        txtPersonID.Texts = row.Cells[2].Value.ToString();
                        txtStudentCode.Texts = row.Cells[3].Value.ToString();
                        txtAge.Texts = row.Cells[4].Value.ToString();
                        txtClass.Texts = row.Cells[5].Value.ToString();
                        txtEmail.Texts = row.Cells[6].Value.ToString();

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

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            UnlockControl();
            flag = "add";

            txtName.Texts = "";
            txtAge.Texts = "";
            txtClass.Texts = "";
            txtEmail.Texts = "";
            txtPersonID.Texts = "";
            txtStudentCode.Texts = "";
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this student?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dtSV.Rows.RemoveAt(index);
                dataGridStudent.DataSource = dtSV;
                dataGridStudent.RefreshEdit();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
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
                    dtSV.Rows.Add(nextID, txtName.Texts, txtPersonID.Texts, txtStudentCode.Texts, txtAge.Texts, txtClass.Texts, txtEmail.Texts);
                    dataGridStudent.DataSource = dtSV;
                    dataGridStudent.RefreshEdit();
                }
            }
            else if (flag == "edit")
            {
                if (CheckData())
                {
                    dtSV.Rows[index][1] = txtName.Texts;
                    dtSV.Rows[index][2] = txtPersonID.Texts;
                    dtSV.Rows[index][3] = txtStudentCode.Texts;
                    dtSV.Rows[index][4] = txtAge.Texts;
                    dtSV.Rows[index][5] = txtClass.Texts;
                    dtSV.Rows[index][6] = txtEmail.Texts;
                    dataGridStudent.DataSource = dtSV;
                    dataGridStudent.RefreshEdit();
                }
            }
            LockControl();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search(txtSearch.Texts);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void bntMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

