using System;
using System.Windows.Forms;


namespace Test
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private int _num;
        private int _ctn;
        private int _attempts;
        private int _numEnter;

        private void StartBtn_Click(object sender, EventArgs e)
        {
            switch (_ctn)
            {
                case 0:
                    _num = GeneratorRandomNum();
                    _attempts = GetMinAttempts(100);
                    NameGame.Text = @"Компьютер загадал число";
                    StartBtn.Text = @"ДАЛЕЕ";
                    _ctn++;
                    break;
                case 1:
                    NameGame.Text = $@"У тебя есть {_attempts} попыток, что бы отгадать число";
                    StartBtn.Text = @"ДАЛЕЕ";
                    _ctn++;
                    break;
                case 2:
                    NameGame.Text = @"Твое число:";
                    NumEnter.Visible = true;
                    _ctn++;
                    break;
                case 3:
                    _numEnter = (int)NumEnter.Value;
                    if (_ctn <= _attempts + 2)
                        if (_numEnter > _num)
                            NameGame.Text = $@"Твое число больше. Осталось {--_attempts}{AttemptStr(_attempts)}";
                        else if (_numEnter < _num)
                            NameGame.Text = $@"Твое число меньше. Осталось {--_attempts}{AttemptStr(_attempts)}";
                        else
                        {
                            NameGame.Text = @"ПОБЕДА!";
                            _ctn++;
                        }
                    else
                    {
                        NameGame.Text = @"Попытки закончились. Ты проиграл. Увы...";
                        NumEnter.Visible = false;
                        _ctn++;
                    }

                    break;
                default:
                    _ctn = 0;
                    NameGame.Text = @"Угадай число";
                    StartBtn.Text = @"ИГРАТЬ";
                    NumEnter.Visible = false;
                    break;
            }
        }

        private int GeneratorRandomNum()
        {
            Random random = new Random();
            int num = random.Next(1, 101);
            return num;
        }

        private int GetMinAttempts(int maxNum)
        {
            var ctn = 0;
            while (maxNum > 1)
            {
                    maxNum /= 2;
                    ctn++;
            }
            return ++ctn;
        }

        private string AttemptStr(int val)
        {
            string s = " попыток";
            if (val % 10 == 1)
                s = " попытка";
            else if (val % 10 > 1 && val % 10 < 5)
                s = " попытки";
            return s;
        }
    }
}
