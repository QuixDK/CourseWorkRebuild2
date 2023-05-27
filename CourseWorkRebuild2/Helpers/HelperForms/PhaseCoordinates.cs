using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkRebuild2
{
    public partial class PhaseCoordinates : Form
    {
        public PhaseCoordinates()
        {
            InitializeComponent();
        }

        private void CheckValuesForm_Load(object sender, EventArgs e)
        {

        }

        public DataGridView GetTable()
        {
            return this.dataGridView1;
        }

        private void PhaseCoordinates_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
