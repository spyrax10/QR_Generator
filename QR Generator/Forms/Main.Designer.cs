
namespace QR_Generator
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.paneMain = new System.Windows.Forms.Panel();
            this.tBQR = new Updater.Controls.UCTextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.pBQR = new System.Windows.Forms.PictureBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnEmailClose = new System.Windows.Forms.Button();
            this.paneMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBQR)).BeginInit();
            this.SuspendLayout();
            // 
            // paneMain
            // 
            this.paneMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneMain.Controls.Add(this.btnEmailClose);
            this.paneMain.Controls.Add(this.btnDown);
            this.paneMain.Controls.Add(this.pBQR);
            this.paneMain.Controls.Add(this.btnGen);
            this.paneMain.Controls.Add(this.tBQR);
            this.paneMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneMain.Location = new System.Drawing.Point(0, 0);
            this.paneMain.Name = "paneMain";
            this.paneMain.Size = new System.Drawing.Size(276, 170);
            this.paneMain.TabIndex = 0;
            // 
            // tBQR
            // 
            this.tBQR.BackColor = System.Drawing.Color.Black;
            this.tBQR.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tBQR.BorderFocusColor = System.Drawing.Color.Lime;
            this.tBQR.BorderSize = 2;
            this.tBQR.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBQR.ForeColor = System.Drawing.Color.White;
            this.tBQR.Location = new System.Drawing.Point(13, 33);
            this.tBQR.Margin = new System.Windows.Forms.Padding(4);
            this.tBQR.Multiline = false;
            this.tBQR.Name = "tBQR";
            this.tBQR.Padding = new System.Windows.Forms.Padding(7);
            this.tBQR.PasswordChar = false;
            this.tBQR.Size = new System.Drawing.Size(250, 37);
            this.tBQR.TabIndex = 0;
            this.tBQR.Texts = "";
            this.tBQR.UnderlinedStyle = true;
            // 
            // btnGen
            // 
            this.btnGen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGen.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGen.ForeColor = System.Drawing.Color.Lime;
            this.btnGen.Location = new System.Drawing.Point(97, 77);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(166, 34);
            this.btnGen.TabIndex = 1;
            this.btnGen.Text = "Generate QR Code";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            this.btnGen.MouseLeave += new System.EventHandler(this.btnGen_MouseLeave);
            this.btnGen.MouseHover += new System.EventHandler(this.btnGen_MouseHover);
            // 
            // pBQR
            // 
            this.pBQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBQR.Location = new System.Drawing.Point(11, 77);
            this.pBQR.Name = "pBQR";
            this.pBQR.Size = new System.Drawing.Size(80, 78);
            this.pBQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBQR.TabIndex = 2;
            this.pBQR.TabStop = false;
            // 
            // btnDown
            // 
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnDown.Location = new System.Drawing.Point(97, 121);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(166, 34);
            this.btnDown.TabIndex = 3;
            this.btnDown.Text = "Download QR Code";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            this.btnDown.MouseLeave += new System.EventHandler(this.btnDown_MouseLeave);
            this.btnDown.MouseHover += new System.EventHandler(this.btnDown_MouseHover);
            // 
            // btnEmailClose
            // 
            this.btnEmailClose.BackColor = System.Drawing.Color.Transparent;
            this.btnEmailClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmailClose.FlatAppearance.BorderSize = 0;
            this.btnEmailClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmailClose.ForeColor = System.Drawing.Color.Red;
            this.btnEmailClose.Image = global::QR_Generator.Properties.Resources.Button_Close_icon__16_;
            this.btnEmailClose.Location = new System.Drawing.Point(250, 0);
            this.btnEmailClose.Name = "btnEmailClose";
            this.btnEmailClose.Size = new System.Drawing.Size(25, 25);
            this.btnEmailClose.TabIndex = 53;
            this.btnEmailClose.UseVisualStyleBackColor = false;
            this.btnEmailClose.Click += new System.EventHandler(this.btnEmailClose_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(276, 170);
            this.Controls.Add(this.paneMain);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Generator";
            this.paneMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneMain;
        private Updater.Controls.UCTextBox tBQR;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.PictureBox pBQR;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnEmailClose;
    }
}

