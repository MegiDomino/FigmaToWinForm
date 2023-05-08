namespace WindowsFormsApplication4
{
    partial class Form1
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
            this.pass = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.signInLabel = new System.Windows.Forms.Label();
            this.eMailTxBx = new System.Windows.Forms.TextBox();
            this.passTxBx = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.signIN = new System.Windows.Forms.TextBox();
            this.newHere = new System.Windows.Forms.Label();
            this.chocoB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toReg = new System.Windows.Forms.Button();
            this.regPanel1 = new WindowsFormsApplication4.regPanel();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.BackColor = System.Drawing.Color.White;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(20, 161);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(70, 16);
            this.pass.TabIndex = 4;
            this.pass.Text = "Password:";
            this.pass.Click += new System.EventHandler(this.pass_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.White;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(20, 114);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(44, 16);
            this.email.TabIndex = 3;
            this.email.Text = "Email:";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // signInLabel
            // 
            this.signInLabel.AutoSize = true;
            this.signInLabel.BackColor = System.Drawing.Color.White;
            this.signInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInLabel.Location = new System.Drawing.Point(366, 199);
            this.signInLabel.Name = "signInLabel";
            this.signInLabel.Size = new System.Drawing.Size(140, 16);
            this.signInLabel.TabIndex = 2;
            this.signInLabel.Text = "Sign in to your account";
            this.signInLabel.Click += new System.EventHandler(this.signInLabel_Click);
            // 
            // eMailTxBx
            // 
            this.eMailTxBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eMailTxBx.Location = new System.Drawing.Point(23, 133);
            this.eMailTxBx.Name = "eMailTxBx";
            this.eMailTxBx.Size = new System.Drawing.Size(160, 20);
            this.eMailTxBx.TabIndex = 5;
            // 
            // passTxBx
            // 
            this.passTxBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passTxBx.Location = new System.Drawing.Point(23, 180);
            this.passTxBx.Name = "passTxBx";
            this.passTxBx.Size = new System.Drawing.Size(160, 20);
            this.passTxBx.TabIndex = 6;
            this.passTxBx.TextChanged += new System.EventHandler(this.passTxBx_TextChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // signIN
            // 
            this.signIN.Location = new System.Drawing.Point(404, 376);
            this.signIN.Name = "signIN";
            this.signIN.Size = new System.Drawing.Size(63, 20);
            this.signIN.TabIndex = 7;
            this.signIN.Text = "Sign in";
            this.signIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.signIN.TextChanged += new System.EventHandler(this.signIN_TextChanged);
            // 
            // newHere
            // 
            this.newHere.AutoSize = true;
            this.newHere.BackColor = System.Drawing.Color.White;
            this.newHere.Location = new System.Drawing.Point(20, 265);
            this.newHere.Name = "newHere";
            this.newHere.Size = new System.Drawing.Size(59, 13);
            this.newHere.TabIndex = 8;
            this.newHere.Text = "New here?";
            this.newHere.Click += new System.EventHandler(this.newHere_Click);
            // 
            // chocoB
            // 
            this.chocoB.AutoSize = true;
            this.chocoB.BackColor = System.Drawing.Color.White;
            this.chocoB.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chocoB.Location = new System.Drawing.Point(348, 155);
            this.chocoB.Name = "chocoB";
            this.chocoB.Size = new System.Drawing.Size(180, 44);
            this.chocoB.TabIndex = 10;
            this.chocoB.Text = "Choco Bliss";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.toReg);
            this.panel1.Controls.Add(this.newHere);
            this.panel1.Controls.Add(this.passTxBx);
            this.panel1.Controls.Add(this.eMailTxBx);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Location = new System.Drawing.Point(335, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 308);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApplication4.Properties.Resources.pngegg;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(913, 321);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::WindowsFormsApplication4.Properties.Resources.pngwing_com;
            this.pictureBox2.Location = new System.Drawing.Point(45, 318);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(824, 794);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // toReg
            // 
            this.toReg.Location = new System.Drawing.Point(85, 260);
            this.toReg.Name = "toReg";
            this.toReg.Size = new System.Drawing.Size(108, 23);
            this.toReg.TabIndex = 15;
            this.toReg.Text = "Create an account,";
            this.toReg.UseVisualStyleBackColor = true;
            this.toReg.Click += new System.EventHandler(this.toReg_Click);
            // 
            // regPanel1
            // 
            this.regPanel1.Location = new System.Drawing.Point(0, 0);
            this.regPanel1.Name = "regPanel1";
            this.regPanel1.Size = new System.Drawing.Size(911, 576);
            this.regPanel1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(911, 576);
            this.Controls.Add(this.regPanel1);
            this.Controls.Add(this.chocoB);
            this.Controls.Add(this.signIN);
            this.Controls.Add(this.signInLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Choco Bliss";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label signInLabel;
        private System.Windows.Forms.TextBox eMailTxBx;
        private System.Windows.Forms.TextBox passTxBx;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox signIN;
        private System.Windows.Forms.Label newHere;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label chocoB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button toReg;
        private regPanel regPanel1;
    }
}

