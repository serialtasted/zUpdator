namespace zUpdator
{
    partial class MainUpdator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUpdator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_curFile = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_latestversion = new System.Windows.Forms.Label();
            this.txt_curversion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_releaseInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sysbtn_git = new System.Windows.Forms.PictureBox();
            this.sysbtn_close = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sysbtn_git)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysbtn_close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.txt_curFile);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 78);
            this.panel1.TabIndex = 2;
            // 
            // btn_update
            // 
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_update.Location = new System.Drawing.Point(502, 18);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(82, 42);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_curFile
            // 
            this.txt_curFile.AutoSize = true;
            this.txt_curFile.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.txt_curFile.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_curFile.Location = new System.Drawing.Point(17, 59);
            this.txt_curFile.MinimumSize = new System.Drawing.Size(250, 0);
            this.txt_curFile.Name = "txt_curFile";
            this.txt_curFile.Size = new System.Drawing.Size(250, 12);
            this.txt_curFile.TabIndex = 9;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(18, 38);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(464, 20);
            this.progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.MinimumSize = new System.Drawing.Size(220, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Waiting for orders";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Leelawadee", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(125)))));
            this.label4.Location = new System.Drawing.Point(163, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "PTrangers Arma 3 Launcher - Updator";
            // 
            // txt_latestversion
            // 
            this.txt_latestversion.AutoSize = true;
            this.txt_latestversion.BackColor = System.Drawing.Color.Transparent;
            this.txt_latestversion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_latestversion.Location = new System.Drawing.Point(118, 37);
            this.txt_latestversion.Name = "txt_latestversion";
            this.txt_latestversion.Size = new System.Drawing.Size(105, 13);
            this.txt_latestversion.TabIndex = 19;
            this.txt_latestversion.Text = "%Remote Version%";
            // 
            // txt_curversion
            // 
            this.txt_curversion.AutoSize = true;
            this.txt_curversion.BackColor = System.Drawing.Color.Transparent;
            this.txt_curversion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_curversion.Location = new System.Drawing.Point(119, 15);
            this.txt_curversion.Name = "txt_curversion";
            this.txt_curversion.Size = new System.Drawing.Size(110, 13);
            this.txt_curversion.TabIndex = 18;
            this.txt_curversion.Text = "%Installed Version%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(17, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Remote version:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(17, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Installed version:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.flowLayoutPanel1.Controls.Add(this.txt_releaseInfo);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(566, 165);
            this.flowLayoutPanel1.TabIndex = 114;
            // 
            // txt_releaseInfo
            // 
            this.txt_releaseInfo.AutoSize = true;
            this.txt_releaseInfo.Location = new System.Drawing.Point(8, 5);
            this.txt_releaseInfo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.txt_releaseInfo.MaximumSize = new System.Drawing.Size(470, 0);
            this.txt_releaseInfo.MinimumSize = new System.Drawing.Size(470, 0);
            this.txt_releaseInfo.Name = "txt_releaseInfo";
            this.txt_releaseInfo.Size = new System.Drawing.Size(470, 13);
            this.txt_releaseInfo.TabIndex = 0;
            this.txt_releaseInfo.Text = "label2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.sysbtn_git);
            this.panel2.Controls.Add(this.sysbtn_close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 30);
            this.panel2.TabIndex = 116;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 350);
            this.panel3.TabIndex = 117;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_latestversion);
            this.panel4.Controls.Add(this.txt_curversion);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(598, 240);
            this.panel4.TabIndex = 117;
            // 
            // sysbtn_git
            // 
            this.sysbtn_git.BackColor = System.Drawing.Color.Transparent;
            this.sysbtn_git.Image = global::zUpdator.Properties.Resources.bggit1;
            this.sysbtn_git.Location = new System.Drawing.Point(555, 7);
            this.sysbtn_git.Name = "sysbtn_git";
            this.sysbtn_git.Size = new System.Drawing.Size(16, 16);
            this.sysbtn_git.TabIndex = 115;
            this.sysbtn_git.TabStop = false;
            this.sysbtn_git.Click += new System.EventHandler(this.sysbtn_git_Click);
            this.sysbtn_git.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sysbtn_git_MouseDown);
            this.sysbtn_git.MouseEnter += new System.EventHandler(this.sysbtn_git_MouseEnter);
            this.sysbtn_git.MouseLeave += new System.EventHandler(this.sysbtn_git_MouseLeave);
            // 
            // sysbtn_close
            // 
            this.sysbtn_close.BackColor = System.Drawing.Color.Transparent;
            this.sysbtn_close.Image = global::zUpdator.Properties.Resources.bgclose1;
            this.sysbtn_close.Location = new System.Drawing.Point(576, 7);
            this.sysbtn_close.Name = "sysbtn_close";
            this.sysbtn_close.Size = new System.Drawing.Size(16, 16);
            this.sysbtn_close.TabIndex = 112;
            this.sysbtn_close.TabStop = false;
            this.sysbtn_close.Click += new System.EventHandler(this.sysbtn_close_Click);
            this.sysbtn_close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sysbtn_close_MouseDown);
            this.sysbtn_close.MouseEnter += new System.EventHandler(this.sysbtn_close_MouseEnter);
            this.sysbtn_close.MouseLeave += new System.EventHandler(this.sysbtn_close_MouseLeave);
            // 
            // MainUpdator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUpdator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Updator_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sysbtn_git)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysbtn_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_latestversion;
        private System.Windows.Forms.Label txt_curversion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox sysbtn_close;
        private System.Windows.Forms.Label txt_curFile;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label txt_releaseInfo;
        private System.Windows.Forms.PictureBox sysbtn_git;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}