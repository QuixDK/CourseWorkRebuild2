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
    public partial class AboutProgramForm : Form
    {
        public AboutProgramForm()
        {
            InitializeComponent();
            richTextBox1.Text = "Этa программа предназначена для " +
                "определения и контроля пространственно-временного состояния техногенного объекта на основе непрерывно-дискретного потока данных, " +
                "передаваемых с автоматизированных систем мониторинга.";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
