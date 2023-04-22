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
    public partial class ChooseTableForm : Form
    {
        String choosedTableName = "";
        public ChooseTableForm()
        {
            InitializeComponent();
        }

        public ComboBox GetComboBox()
        {
            return tableNamesComboBox;
        }

        public String GetApplyedTable()
        {
            return choosedTableName;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            choosedTableName = this.tableNamesComboBox.SelectedItem.ToString();
            this.Hide();
        }

        
    }
}
