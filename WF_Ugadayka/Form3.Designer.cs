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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.tB_otvet = new System.Windows.Forms.TextBox();
            this.bt_proverka = new System.Windows.Forms.Button();
            this.lb_hod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tB_otvet
            // 
            this.tB_otvet.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_otvet.Location = new System.Drawing.Point(45, 58);
            this.tB_otvet.Name = "tB_otvet";
            this.tB_otvet.Size = new System.Drawing.Size(230, 45);
            this.tB_otvet.TabIndex = 0;
            this.tB_otvet.Text = "Число";
            this.tB_otvet.TextChanged += new System.EventHandler(this.TB_otvet_TextChanged);
            // 
            // bt_proverka
            // 
            this.bt_proverka.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_proverka.Location = new System.Drawing.Point(45, 186);
            this.bt_proverka.Name = "bt_proverka";
            this.bt_proverka.Size = new System.Drawing.Size(230, 57);
            this.bt_proverka.TabIndex = 1;
            this.bt_proverka.Text = "Проверить";
            this.bt_proverka.UseVisualStyleBackColor = true;
            this.bt_proverka.Click += new System.EventHandler(this.Bt_proverka_Click);
            // 
            // lb_hod
            // 
            this.lb_hod.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_hod.ForeColor = System.Drawing.Color.AliceBlue;
            this.lb_hod.Image = global::WF_Ugadayka.Properties.Resources.grass500;
            this.lb_hod.Location = new System.Drawing.Point(115, 118);
            this.lb_hod.Name = "lb_hod";
            this.lb_hod.Size = new System.Drawing.Size(53, 49);
            this.lb_hod.TabIndex = 5;
            this.lb_hod.Text = "0";
            this.lb_hod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(320, 272);
            this.Controls.Add(this.lb_hod);
            this.Controls.Add(this.bt_proverka);
            this.Controls.Add(this.tB_otvet);
            this.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод числа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_otvet;
        private System.Windows.Forms.Button bt_proverka;
        private System.Windows.Forms.Label lb_hod;
    }
}