namespace SpeakSignRewrite1
{
    partial class SpeakSign
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.PTT = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.pathConfig = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.richTextBox1.Location = new System.Drawing.Point(204, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(584, 426);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // PTT
            // 
            this.PTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PTT.Location = new System.Drawing.Point(12, 12);
            this.PTT.Name = "PTT";
            this.PTT.Size = new System.Drawing.Size(186, 87);
            this.PTT.TabIndex = 2;
            this.PTT.Text = "Push to speak...";
            this.PTT.UseVisualStyleBackColor = true;
            this.PTT.Click += new System.EventHandler(this.PTT_Click);
            // 
            // quit
            // 
            this.quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.quit.Location = new System.Drawing.Point(12, 402);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(186, 36);
            this.quit.TabIndex = 3;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // pathConfig
            // 
            this.pathConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pathConfig.Location = new System.Drawing.Point(12, 302);
            this.pathConfig.Name = "pathConfig";
            this.pathConfig.Size = new System.Drawing.Size(186, 52);
            this.pathConfig.TabIndex = 5;
            this.pathConfig.Text = "Configure script path...";
            this.pathConfig.UseVisualStyleBackColor = true;
            this.pathConfig.Click += new System.EventHandler(this.pathConfig_Click);
            // 
            // info
            // 
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.info.Location = new System.Drawing.Point(12, 360);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(186, 36);
            this.info.TabIndex = 6;
            this.info.Text = "Visit page...";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // SpeakSign
            // 
            this.AccessibleDescription = "A speech to text app for use with the SpeakSign system";
            this.AccessibleName = "SpeakSign";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.info);
            this.Controls.Add(this.pathConfig);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.PTT);
            this.Controls.Add(this.richTextBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpeakSign";
            this.Text = "SpeakSign";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button PTT;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button pathConfig;
        private System.Windows.Forms.Button info;
        public System.Windows.Forms.RichTextBox richTextBox1;
    }
}

