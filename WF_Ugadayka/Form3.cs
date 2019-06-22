using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Ugadayka
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            tB_otvet.Text = "ЧислО";
            bt_proverka.Text = "ПроверитЬ";
            lb_hod.Text = "7";

            Random ch = new Random();
            chislo = ch.Next(1, 100);

        }
        public int chislo;
        private void TB_otvet_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bt_proverka_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(tB_otvet.Text) < chislo)
                {
                    MessageBox.Show("Больше", "Ещё");
                }
                else if (int.Parse(tB_otvet.Text) > chislo)
                {
                    MessageBox.Show("Меньше", "Ещё");
                }
                else
                {
                    MessageBox.Show("Угадано", "Победа");

                    Close();
                    return;


                }

                lb_hod.Text = (int.Parse(lb_hod.Text) - 1).ToString();

            }
            catch
            {

                MessageBox.Show("Нужна цифра", "Ошибка");

            }
        }


    }
}
