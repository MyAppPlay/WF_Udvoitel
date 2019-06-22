using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//    Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100,
//    а человек пытается его угадать за минимальное число попыток.
//    Компьютер говорит, больше или меньше загаданное число введенного.
//      a) Для ввода данных от человека используется элемент TextBox;
//      б) ** Реализовать отдельную форму c TextBox для ввода числа.
                         //  Гаврилов  Владимир

namespace WF_Ugadayka
{
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();
            bt_play.Text = ("Играть в Угадайку");
            btn_Play_Udvoitel.Text = "Играть в Удвоитель";
        }




        private void TB_Otv_TextChanged(object sender, EventArgs e)
        {

        }


        public void Bt_otv_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.Show();
        }

        private void Btn_Play_Udvoitel_Click(object sender, EventArgs e)
        {
           // Application.Run(new Form1());
        }
    }
}
