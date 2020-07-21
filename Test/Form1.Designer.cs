namespace Test
{
    partial class MainForm
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
            this.StartBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NameGame = new System.Windows.Forms.Label();
            this.NumEnter = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumEnter)).BeginInit();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.Transparent;
            this.StartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.StartBtn.FlatAppearance.BorderSize = 10;
            this.StartBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.StartBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartBtn.Font = new System.Drawing.Font("MS UI Gothic", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartBtn.ForeColor = System.Drawing.Color.Red;
            this.StartBtn.Location = new System.Drawing.Point(0, 0);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(380, 131);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "ИГРАТЬ";
            this.StartBtn.UseMnemonic = false;
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.StartBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 131);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.NameGame);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 358);
            this.panel2.TabIndex = 3;
            // 
            // NameGame
            // 
            this.NameGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameGame.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameGame.ForeColor = System.Drawing.Color.Blue;
            this.NameGame.Location = new System.Drawing.Point(0, 0);
            this.NameGame.Name = "NameGame";
            this.NameGame.Size = new System.Drawing.Size(380, 358);
            this.NameGame.TabIndex = 0;
            this.NameGame.Text = "УГАДАЙ ЧИСЛО";
            this.NameGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NameGame.UseMnemonic = false;
            // 
            // NumEnter
            // 
            this.NumEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NumEnter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NumEnter.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumEnter.ForeColor = System.Drawing.Color.Green;
            this.NumEnter.Location = new System.Drawing.Point(0, 365);
            this.NumEnter.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.NumEnter.Name = "NumEnter";
            this.NumEnter.Size = new System.Drawing.Size(380, 61);
            this.NumEnter.TabIndex = 5;
            this.NumEnter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumEnter.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Test.Properties.Resources._512;
            this.ClientSize = new System.Drawing.Size(380, 557);
            this.Controls.Add(this.NumEnter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumEnter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label NameGame;
        private System.Windows.Forms.NumericUpDown NumEnter;
    }
}

