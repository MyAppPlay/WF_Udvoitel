using System;
using System.Collections.Generic;
using System.Windows.Forms;

//      Задание 1
// а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
// б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.
//    Игрок должен получить это число за минимальное количество ходов.
// в) * Добавить кнопку «Отменить», которая отменяет последние ходы.Используйте обобщенный класс Stack.
//      Вся логика игры должна быть реализована в классе с удвоителем.
//                 Гаврилов Владимир

namespace WF_Udvoitel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public Stack<string> Revers = new Stack<string>();//Массив стека

        private void BtnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            lblChekC2.Text = (int.Parse(lblChekC2.Text) + 1).ToString();
            Revers.Push(lblNumber.Text);
            if (_i == int.Parse(lblChekC2.Text) && _proverka == int.Parse(lblNumber.Text))
            {
                MessageBox.Show(@"Вам это удалось", @"Победа");
                _i = 0;
            }


        }

        private void BtnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            lblChekC2.Text = (int.Parse(lblChekC2.Text) + 1).ToString();
            Revers.Push(lblNumber.Text);
            if (_i == int.Parse(lblChekC2.Text) && _proverka == int.Parse(lblNumber.Text))
            {
                MessageBox.Show(@"Вам это удалось", @"Победа");
                _i = 0;
            }
        }

        public void BtnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = @"1";
            lblChekC2.Text = @"0";
            Revers.Clear();

        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }
        int _i;//переменная для цикла подсчта минимума ходов
        int _proverka;

        private void PlayMenuItem_Click(object sender, EventArgs e)//кнопка играть
        {
            _i = 0;
            BtnReset_Click(sender, e);
            Random rnd = new Random();
            var chislo = rnd.Next(1, 100);
            var xod = chislo;
            _proverka = chislo;
            while (xod != 1)
            {

                if (xod % 2 == 0)
                {
                    _i++;
                    xod /= 2;
                }
                else
                {
                    _i++;
                    xod -= 1;
                }
            }
            MessageBox.Show($@"Создай число {chislo} за {_i} ходов", @"Задача");
        }


        private void BtnBack_Click(object sender, EventArgs e)//кнопка отмены
        {
            try
            {
                Revers.Pop();
                lblNumber.Text = Revers.Peek();//присвоение предыдущего значения

                lblChekC2.Text = (int.Parse(lblChekC2.Text) - 1).ToString();
            }
            catch
            {
                // ignored
            }

            //устранение реакции на ошибку
        }

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
