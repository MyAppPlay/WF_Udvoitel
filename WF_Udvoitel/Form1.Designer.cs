namespace WF_Udvoitel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblChekC2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.PlayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCommand1
            // 
            this.btnCommand1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCommand1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnCommand1, "btnCommand1");
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.UseVisualStyleBackColor = false;
            this.btnCommand1.Click += new System.EventHandler(this.BtnCommand1_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCommand2.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnCommand2, "btnCommand2");
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.UseVisualStyleBackColor = false;
            this.btnCommand2.Click += new System.EventHandler(this.BtnCommand2_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.ForeColor = System.Drawing.Color.DarkRed;
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumber.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            resources.ApplyResources(this.lblNumber, "lblNumber");
            this.lblNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.UseCompatibleTextRendering = true;
            this.lblNumber.UseMnemonic = false;
            this.lblNumber.UseWaitCursor = true;
            this.lblNumber.Click += new System.EventHandler(this.lblNumber_Click);
            // 
            // lblChekC2
            // 
            this.lblChekC2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblChekC2.Cursor = System.Windows.Forms.Cursors.No;
            resources.ApplyResources(this.lblChekC2, "lblChekC2");
            this.lblChekC2.ForeColor = System.Drawing.Color.Navy;
            this.lblChekC2.Name = "lblChekC2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.BackgroundImage = global::WF_Udvoitel.Properties.Resources.ruin_wall_03_height;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // PlayMenuItem
            // 
            resources.ApplyResources(this.PlayMenuItem, "PlayMenuItem");
            this.PlayMenuItem.ForeColor = System.Drawing.Color.Red;
            this.PlayMenuItem.Name = "PlayMenuItem";
            this.PlayMenuItem.Click += new System.EventHandler(this.PlayMenuItem_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Bisque;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WF_Udvoitel.Properties.Resources.ruin_wall_03_height;
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblChekC2);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCommand2);
            this.Controls.Add(this.btnCommand1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblChekC2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem PlayMenuItem;
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.Label lblNumber;
    }
}

