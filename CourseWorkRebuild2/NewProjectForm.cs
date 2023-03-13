using CourseWorkRebuild;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkRebuild2
{
    public partial class NewProjectForm : Form
    {
        private List<String> values = new List<String>();
        private Repository repository;
        private SQLiteConnection sqlConnection;
        private DataTable dataTable = new DataTable();
        public NewProjectForm()
        {
            InitializeComponent();
        }

        private void reDrawCurrentForm()
        {


            if (values[0] != null & values[0] != "")
            {
                epochCountBox.Items.Clear();
                repository = new Repository(values[0]);
                sqlConnection = repository.GetDbConnection();
                elevatorTable = repository.ShowTable(dataTable, elevatorTable);
                for (int row = 0; row < elevatorTable.Rows.Count - 1; row++)
                {
                    epochCountBox.Items.Add(elevatorTable.Rows[row].Cells[0].Value);
                }
                epochCountBox.SelectedIndex = 0;
            }
            else
            {
                elevatorTable.Rows.Clear();
                elevatorTable.Columns.Clear();
            }
            if (values[1] != null & values[1] != "")
            {
                objectPicture.Load(values[1]);
                objectPicture.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            else
            {
                objectPicture.Image = null;
            }
            if (values[2] != null & values[2] != "")
            {
                valueOfTLabel.Text = "T: " + values[2];

            }
            else
            {
                valueOfTLabel.Text = "";
            }
            if (values[3] != null & values[3] != "")
            {
                valueOfALabel.Text = "A: " + values[3];

            }
            else
            {
                valueOfALabel.Text = "";
            }
            if (values[6] != null & values[6] != "")
            {
                this.Text = values[6];
            }
            else { this.Text = ""; }


        }

        private void NewProjectForm_Load(object sender, EventArgs e)
        {
            OpenProject openProject = new OpenProject();
            values = openProject.Open();
            reDrawCurrentForm();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
