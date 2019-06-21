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
    public partial class Form3 : Form2
    {
        public Form3()
        {
            InitializeComponent();
            tB_otvet.Text = "Пиши число здесь";
            bt_proverka.Text = "Проверить";

            Random ch = new Random();
            chisl = ch.Next(1, 100);
        }

        private void TB_otvet_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bt_proverka_Click(object sender, EventArgs e)
        {
            if (int.Parse(tB_otvet.Text) < chisl )
            {
                MessageBox.Show("Больше", "Ещё");
            }
            else if (int.Parse(tB_otvet.Text) > chisl)
            {
                MessageBox.Show("Меньше", "Ещё");
            }
            else MessageBox.Show("Угадано", "Победа");
        }
    }
}
