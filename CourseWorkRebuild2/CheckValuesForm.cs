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
    public partial class CheckValuesForm : Form
    {
        public CheckValuesForm()
        {
            InitializeComponent();
        }

        private void CheckValuesForm_Load(object sender, EventArgs e)
        {

        }

        public ListBox GetListBox1()
        {
            return listBox1;
        }
        public ListBox GetListBox2()
        {
            return listBox2;
        }
        public ListBox GetListBox3()
        {
            return listBox3;
        }
        public ListBox GetListBox4()
        {
            return listBox4;
        }
        public ListBox GetListBox5()
        {
            return listBox5;
        }
        public ListBox GetListBox6()
        {
            return listBox6;
        }
    }
}
