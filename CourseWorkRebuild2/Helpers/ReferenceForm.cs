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
    public partial class ReferenceForm : Form
    {
        private int step = 2;
        public ReferenceForm()
        {
            InitializeComponent();
            label1.Text = "Для работы с программой, нужно открыть проект во вкладке Файл";
            pictureBox1.Image = Properties.Resources.step1;
        }

        private void nextStepButton_Click(object sender, EventArgs e)
        {
            switch(step)
            {
                case 1:
                    label1.Text = "Для работы с программой, нужно открыть проект во вкладке Файл";
                    pictureBox1.Image = Properties.Resources.step1;
                    step = 2;
                    nextStepButton_Click(sender, e);
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.step2;
                    label1.Text = "При нажатии по кнопке открыть, появится диалоговое окно, где можно выбрать папку с данными";
                    step = 3;
                    break;
                case 3:
                    pictureBox1.Image= Properties.Resources.step3;
                    label1.Text = "Если значки состояния загорелись зеленым, значит всё подгрузилось, можете проверить данные";
                    step = 4;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.redactorMenu;
                    label1.Text = "При необходимости можно все данные настроить во вкладке Редактирование";
                    step = 5; 
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.step4;
                    label1.Text = "Для просмотра состояния объекта на первом уровне декомпозиции, нужно перейти на соответсвующую вкладку";
                    step = 6;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.Screenshot_5;
                    label1.Text = "При необходимости можно посмотреть таблицу фазовых координат или соответсвующие графики во вкладке Окна";
                    break;
            }
        }

        private void lastStepButton_Click(object sender, EventArgs e)
        {
            switch (step)
            {
                case 2:
                    label1.Text = "Для работы с программой, нужно открыть проект во вкладке Файл";
                    pictureBox1.Image = Properties.Resources.step1;
                    step = 1;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.step2;
                    label1.Text = "При нажатии по кнопке открыть, появится диалоговое окно, где можно выбрать папку с данными";
                    step = 2;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.step3;
                    label1.Text = "Если значки состояния загорелись зеленым, значит всё подгрузилось, можете проверить данные";
                    step = 3;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.redactorMenu;
                    label1.Text = "При необходимости можно все данные настроить во вкладке Редактирование";
                    step = 4;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.step4;
                    label1.Text = "Для просмотра состояния объекта на первом уровне декомпозиции, нужно перейти на соответсвующую вкладку";
                    step = 5;
                    break;
            }
        }

        private void ReferenceForm_Load(object sender, EventArgs e)
        {

        }
    }
}
