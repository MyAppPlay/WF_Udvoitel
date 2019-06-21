namespace WF_Ugadayka
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tB_otvet = new System.Windows.Forms.TextBox();
            this.bt_proverka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tB_otvet
            // 
            this.tB_otvet.Location = new System.Drawing.Point(85, 106);
            this.tB_otvet.Name = "tB_otvet";
            this.tB_otvet.Size = new System.Drawing.Size(116, 20);
            this.tB_otvet.TabIndex = 0;
            this.tB_otvet.Text = "Напиши здесь число";
            this.tB_otvet.TextChanged += new System.EventHandler(this.TB_otvet_TextChanged);
            // 
            // bt_proverka
            // 
            this.bt_proverka.Location = new System.Drawing.Point(85, 178);
            this.bt_proverka.Name = "bt_proverka";
            this.bt_proverka.Size = new System.Drawing.Size(116, 23);
            this.bt_proverka.TabIndex = 1;
            this.bt_proverka.Text = "Проверить";
            this.bt_proverka.UseVisualStyleBackColor = true;
            this.bt_proverka.Click += new System.EventHandler(this.Bt_proverka_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 272);
            this.Controls.Add(this.bt_proverka);
            this.Controls.Add(this.tB_otvet);
            this.Name = "Form3";
            this.Text = "Ввод числа";
            this.Controls.SetChildIndex(this.tB_otvet, 0);
            this.Controls.SetChildIndex(this.bt_proverka, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_otvet;
        private System.Windows.Forms.Button bt_proverka;
    }
}