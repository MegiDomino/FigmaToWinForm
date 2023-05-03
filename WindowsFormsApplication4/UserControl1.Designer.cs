namespace WindowsFormsApplication4
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.passTxBx = new System.Windows.Forms.TextBox();
            this.eMailTxBx = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.signInLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.chocoB = new System.Windows.Forms.Label();
            this.createAcc = new System.Windows.Forms.LinkLabel();
            this.newHere = new System.Windows.Forms.Label();
            this.signIN = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // passTxBx
            // 
            this.passTxBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passTxBx.Location = new System.Drawing.Point(288, 272);
            this.passTxBx.Name = "passTxBx";
            this.passTxBx.Size = new System.Drawing.Size(160, 20);
            this.passTxBx.TabIndex = 18;
            // 
            // eMailTxBx
            // 
            this.eMailTxBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eMailTxBx.Location = new System.Drawing.Point(288, 225);
            this.eMailTxBx.Name = "eMailTxBx";
            this.eMailTxBx.Size = new System.Drawing.Size(160, 20);
            this.eMailTxBx.TabIndex = 17;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.BackColor = System.Drawing.Color.White;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(285, 253);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(71, 16);
            this.pass.TabIndex = 16;
            this.pass.Text = "Password:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.White;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(285, 206);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(45, 16);
            this.email.TabIndex = 15;
            this.email.Text = "Email:";
            // 
            // signInLabel
            // 
            this.signInLabel.AutoSize = true;
            this.signInLabel.BackColor = System.Drawing.Color.White;
            this.signInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInLabel.Location = new System.Drawing.Point(298, 146);
            this.signInLabel.Name = "signInLabel";
            this.signInLabel.Size = new System.Drawing.Size(141, 16);
            this.signInLabel.TabIndex = 14;
            this.signInLabel.Text = "Sign in to your account";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::WindowsFormsApplication4.Properties.Resources.pngwing_com;
            this.pictureBox2.Location = new System.Drawing.Point(25, 223);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(705, 658);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // chocoB
            // 
            this.chocoB.AutoSize = true;
            this.chocoB.BackColor = System.Drawing.Color.White;
            this.chocoB.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chocoB.Location = new System.Drawing.Point(280, 102);
            this.chocoB.Name = "chocoB";
            this.chocoB.Size = new System.Drawing.Size(181, 44);
            this.chocoB.TabIndex = 22;
            this.chocoB.Text = "Choco Bliss";
            // 
            // createAcc
            // 
            this.createAcc.AutoSize = true;
            this.createAcc.BackColor = System.Drawing.Color.White;
            this.createAcc.LinkColor = System.Drawing.Color.Red;
            this.createAcc.Location = new System.Drawing.Point(350, 355);
            this.createAcc.Name = "createAcc";
            this.createAcc.Size = new System.Drawing.Size(98, 13);
            this.createAcc.TabIndex = 21;
            this.createAcc.TabStop = true;
            this.createAcc.Text = "Create an account.";
            // 
            // newHere
            // 
            this.newHere.AutoSize = true;
            this.newHere.BackColor = System.Drawing.Color.White;
            this.newHere.Location = new System.Drawing.Point(285, 355);
            this.newHere.Name = "newHere";
            this.newHere.Size = new System.Drawing.Size(59, 13);
            this.newHere.TabIndex = 20;
            this.newHere.Text = "New here?";
            // 
            // signIN
            // 
            this.signIN.Location = new System.Drawing.Point(336, 323);
            this.signIN.Name = "signIN";
            this.signIN.Size = new System.Drawing.Size(63, 20);
            this.signIN.TabIndex = 19;
            this.signIN.Text = "Sign in";
            this.signIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(267, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 308);
            this.panel1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApplication4.Properties.Resources.pngegg;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(758, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.passTxBx);
            this.Controls.Add(this.eMailTxBx);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.email);
            this.Controls.Add(this.signInLabel);
            this.Controls.Add(this.chocoB);
            this.Controls.Add(this.createAcc);
            this.Controls.Add(this.newHere);
            this.Controls.Add(this.signIN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(758, 568);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passTxBx;
        private System.Windows.Forms.TextBox eMailTxBx;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label signInLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label chocoB;
        private System.Windows.Forms.LinkLabel createAcc;
        private System.Windows.Forms.Label newHere;
        private System.Windows.Forms.TextBox signIN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;


    }
}
