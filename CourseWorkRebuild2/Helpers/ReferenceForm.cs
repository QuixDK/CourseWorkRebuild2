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
        private int step2 = 1;
        private int step3 = 1;
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

        private void button1_Click(object sender, EventArgs e)
        {
            switch (step2)
            {
                case 1:
                    label2.Text = "При переключении на вкладку Уровень 2, вы увидите 2 листа, в одном все марки объекта, в другом марки блока";
                    pictureBox2.Image = Properties.Resources._2step1;
                    step2 = 2;
                    button1_Click(sender, e);
                    break;
                case 2:
                    pictureBox2.Image = Properties.Resources._2step2;
                    label2.Text = "Добавлять метки можно с помощью двойного клика или с использованием соответсвующих кнопок, блоки меняются автоматически, после добавления определенного количества марок";
                    step2 = 3;
                    break;
                case 3:
                    pictureBox2.Image = Properties.Resources._2step3;
                    label2.Text = "После распределения всех марок, автоматически загрузится таблица состояния объекта, а также меню, где можно сменить блок, или перераспределить марки";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (step2)
            {

                case 2:
                    pictureBox2.Image = Properties.Resources._2step1;
                    label2.Text = "При переключении на вкладку Уровень 2, вы увидите 2 листа, в одном все марки объекта, в другом марки блока";
                    step2 = 1;
                    break;
                case 3:
                    pictureBox2.Image = Properties.Resources._2step2;
                    label2.Text = "Добавлять метки можно с помощью двойного клика или с использованием соответсвующих кнопок, блоки меняются автоматически, после добавления определенного количества марок";
                    step2 = 2;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (step3)
            {
                case 1:
                    label3.Text = "При переключении на вкладку Уровень 4 надо убедится, что вы распределили марки на втором уровне, если да, то перед вами появится выбор блока, а так же два листа с доступными марками и отображенными";
                    pictureBox3.Image = Properties.Resources._3step3;
                    step3 = 2;
                    button3_Click(sender, e);
                    break;
                case 2:
                    pictureBox3.Image = Properties.Resources._3step2;
                    label3.Text = "Добавлять марки можно с помощью двойного клика по ней, как и убирать";
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (step3)
            {

                case 2:
                    pictureBox3.Image = Properties.Resources._3step3;
                    label3.Text = "При переключении на вкладку Уровень 4 надо убедится, что вы распределили марки на втором уровне, если да, то перед вами появится выбор блока, а так же два листа с доступными марками и отображенными";
                    step3 = 1;
                    break;
            }
        }
    }
}
