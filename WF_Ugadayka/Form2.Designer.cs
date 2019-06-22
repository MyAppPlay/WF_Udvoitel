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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bt_play = new System.Windows.Forms.Button();
            this.btn_Play_Udvoitel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_play
            // 
            this.bt_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_play.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_play.Image = ((System.Drawing.Image)(resources.GetObject("bt_play.Image")));
            this.bt_play.Location = new System.Drawing.Point(-5, 12);
            this.bt_play.Name = "bt_play";
            this.bt_play.Size = new System.Drawing.Size(388, 389);
            this.bt_play.TabIndex = 1;
            this.bt_play.Text = "Играть в Угадайку ";
            this.bt_play.UseVisualStyleBackColor = true;
            this.bt_play.Click += new System.EventHandler(this.Bt_otv_Click);
            // 
            // btn_Play_Udvoitel
            // 
            this.btn_Play_Udvoitel.Location = new System.Drawing.Point(415, 162);
            this.btn_Play_Udvoitel.Name = "btn_Play_Udvoitel";
            this.btn_Play_Udvoitel.Size = new System.Drawing.Size(91, 93);
            this.btn_Play_Udvoitel.TabIndex = 2;
            this.btn_Play_Udvoitel.Text = "Играть в Удвоитель";
            this.btn_Play_Udvoitel.UseVisualStyleBackColor = true;
            this.btn_Play_Udvoitel.Visible = false;
            this.btn_Play_Udvoitel.Click += new System.EventHandler(this.Btn_Play_Udvoitel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 396);
            this.Controls.Add(this.btn_Play_Udvoitel);
            this.Controls.Add(this.bt_play);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Угадайка";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_play;
        private System.Windows.Forms.Button btn_Play_Udvoitel;
    }
}

