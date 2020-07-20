using System;
using System.Windows.Forms;


namespace WF_Ugadayka
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            tB_otvet.Text = @"ЧислО";
            bt_proverka.Text = @"ПроверитЬ";
            lb_hod.Text = @"7";

            Random ch = new Random();
            Chislo = ch.Next(1, 100);

        }
        public int Chislo;
        private void TB_otvet_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bt_proverka_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(tB_otvet.Text) < Chislo)
                {
                    MessageBox.Show(@"Больше", @"Ещё");
                }
                else if (int.Parse(tB_otvet.Text) > Chislo)
                {
                    MessageBox.Show(@"Меньше", @"Ещё");
                }
                else
                {
                    MessageBox.Show(@"Угадано", @"Победа");

                    Close();
                    return;


                }

                lb_hod.Text = (int.Parse(lb_hod.Text) - 1).ToString();

            }
            catch
            {

                MessageBox.Show(@"Нужна цифра", @"Ошибка");

            }
        }


    }
}
