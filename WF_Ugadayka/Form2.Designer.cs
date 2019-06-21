namespace WF_Ugadayka
{
    partial class Form2
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tB_Otv = new System.Windows.Forms.TextBox();
            this.bt_play = new System.Windows.Forms.Button();
            this.lb_NameGame = new System.Windows.Forms.Label();
            this.tB_sravn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tB_Otv
            // 
            this.tB_Otv.Location = new System.Drawing.Point(355, 166);
            this.tB_Otv.Name = "tB_Otv";
            this.tB_Otv.Size = new System.Drawing.Size(100, 20);
            this.tB_Otv.TabIndex = 0;
            this.tB_Otv.Visible = false;
            this.tB_Otv.TextChanged += new System.EventHandler(this.TB_Otv_TextChanged);
            // 
            // bt_play
            // 
            this.bt_play.Location = new System.Drawing.Point(355, 92);
            this.bt_play.Name = "bt_play";
            this.bt_play.Size = new System.Drawing.Size(100, 23);
            this.bt_play.TabIndex = 1;
            this.bt_play.Text = "Играть";
            this.bt_play.UseVisualStyleBackColor = true;
            this.bt_play.Click += new System.EventHandler(this.Bt_otv_Click);
            // 
            // lb_NameGame
            // 
            this.lb_NameGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_NameGame.Location = new System.Drawing.Point(352, 24);
            this.lb_NameGame.Name = "lb_NameGame";
            this.lb_NameGame.Size = new System.Drawing.Size(103, 23);
            this.lb_NameGame.TabIndex = 3;
            this.lb_NameGame.Text = "УгадайкА";
            this.lb_NameGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tB_sravn
            // 
            this.tB_sravn.Location = new System.Drawing.Point(355, 215);
            this.tB_sravn.Name = "tB_sravn";
            this.tB_sravn.Size = new System.Drawing.Size(100, 20);
            this.tB_sravn.TabIndex = 4;
            this.tB_sravn.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tB_sravn);
            this.Controls.Add(this.lb_NameGame);
            this.Controls.Add(this.bt_play);
            this.Controls.Add(this.tB_Otv);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Угадайка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_Otv;
        private System.Windows.Forms.Button bt_play;
        private System.Windows.Forms.Label lb_NameGame;
        private System.Windows.Forms.TextBox tB_sravn;
    }
}

