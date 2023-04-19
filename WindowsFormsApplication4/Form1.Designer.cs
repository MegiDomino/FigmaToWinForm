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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.eMailTxBx = new System.Windows.Forms.TextBox();
            this.passTxBx = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.signIN = new System.Windows.Forms.TextBox();
            this.newHere = new System.Windows.Forms.Label();
            this.createAcc = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(277, 202);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(71, 16);
            this.pass.TabIndex = 4;
            this.pass.Text = "Password:";
            this.pass.Click += new System.EventHandler(this.pass_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(277, 155);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(45, 16);
            this.email.TabIndex = 3;
            this.email.Text = "Email:";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // signInLabel
            // 
            this.signInLabel.AutoSize = true;
            this.signInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInLabel.Location = new System.Drawing.Point(290, 95);
            this.signInLabel.Name = "signInLabel";
            this.signInLabel.Size = new System.Drawing.Size(141, 16);
            this.signInLabel.TabIndex = 2;
            this.signInLabel.Text = "Sign in to your account";
            this.signInLabel.Click += new System.EventHandler(this.signInLabel_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(262, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 40);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Choco Bliss";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // eMailTxBx
            // 
            this.eMailTxBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eMailTxBx.Location = new System.Drawing.Point(280, 174);
            this.eMailTxBx.Name = "eMailTxBx";
            this.eMailTxBx.Size = new System.Drawing.Size(160, 13);
            this.eMailTxBx.TabIndex = 5;
            // 
            // passTxBx
            // 
            this.passTxBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passTxBx.Location = new System.Drawing.Point(280, 221);
            this.passTxBx.Name = "passTxBx";
            this.passTxBx.Size = new System.Drawing.Size(160, 13);
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
            this.signIN.Location = new System.Drawing.Point(328, 272);
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
            this.newHere.Location = new System.Drawing.Point(277, 304);
            this.newHere.Name = "newHere";
            this.newHere.Size = new System.Drawing.Size(59, 13);
            this.newHere.TabIndex = 8;
            this.newHere.Text = "New here?";
            this.newHere.Click += new System.EventHandler(this.newHere_Click);
            // 
            // createAcc
            // 
            this.createAcc.AutoSize = true;
            this.createAcc.LinkColor = System.Drawing.Color.Red;
            this.createAcc.Location = new System.Drawing.Point(342, 304);
            this.createAcc.Name = "createAcc";
            this.createAcc.Size = new System.Drawing.Size(98, 13);
            this.createAcc.TabIndex = 9;
            this.createAcc.TabStop = true;
            this.createAcc.Text = "Create an account.";
            this.createAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createAcc_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(755, 435);
            this.Controls.Add(this.createAcc);
            this.Controls.Add(this.newHere);
            this.Controls.Add(this.signIN);
            this.Controls.Add(this.passTxBx);
            this.Controls.Add(this.eMailTxBx);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.email);
            this.Controls.Add(this.signInLabel);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Choco Bliss";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label signInLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox eMailTxBx;
        private System.Windows.Forms.TextBox passTxBx;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox signIN;
        private System.Windows.Forms.LinkLabel createAcc;
        private System.Windows.Forms.Label newHere;


    }
}

