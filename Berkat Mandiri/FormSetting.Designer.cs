namespace Berkat_Mandiri
{
    partial class FormSetting
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbNew = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOld = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRepeat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelGantiPass = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNo = new System.Windows.Forms.Button();
            this.tbYes = new System.Windows.Forms.Button();
            this.btGantiPass = new System.Windows.Forms.Button();
            this.panelGantiPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(56, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pengguna :";
            // 
            // tbUser
            // 
            this.tbUser.Enabled = false;
            this.tbUser.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.tbUser.Location = new System.Drawing.Point(175, 55);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(245, 32);
            this.tbUser.TabIndex = 23;
            // 
            // tbNew
            // 
            this.tbNew.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.tbNew.Location = new System.Drawing.Point(187, 46);
            this.tbNew.Name = "tbNew";
            this.tbNew.Size = new System.Drawing.Size(245, 32);
            this.tbNew.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Password Lama    :";
            // 
            // tbOld
            // 
            this.tbOld.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.tbOld.Location = new System.Drawing.Point(187, 102);
            this.tbOld.Name = "tbOld";
            this.tbOld.Size = new System.Drawing.Size(245, 32);
            this.tbOld.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Password Baru    :";
            // 
            // tbRepeat
            // 
            this.tbRepeat.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.tbRepeat.Location = new System.Drawing.Point(187, 159);
            this.tbRepeat.Name = "tbRepeat";
            this.tbRepeat.Size = new System.Drawing.Size(245, 32);
            this.tbRepeat.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ulangi Password :";
            // 
            // panelGantiPass
            // 
            this.panelGantiPass.Controls.Add(this.label5);
            this.panelGantiPass.Controls.Add(this.tbNo);
            this.panelGantiPass.Controls.Add(this.tbYes);
            this.panelGantiPass.Controls.Add(this.label3);
            this.panelGantiPass.Controls.Add(this.tbRepeat);
            this.panelGantiPass.Controls.Add(this.label2);
            this.panelGantiPass.Controls.Add(this.label4);
            this.panelGantiPass.Controls.Add(this.tbNew);
            this.panelGantiPass.Controls.Add(this.tbOld);
            this.panelGantiPass.Location = new System.Drawing.Point(44, 156);
            this.panelGantiPass.Name = "panelGantiPass";
            this.panelGantiPass.Size = new System.Drawing.Size(468, 251);
            this.panelGantiPass.TabIndex = 30;
            this.panelGantiPass.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(136, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Form Ganti Password";
            // 
            // tbNo
            // 
            this.tbNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbNo.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.tbNo.Location = new System.Drawing.Point(222, 204);
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(95, 35);
            this.tbNo.TabIndex = 33;
            this.tbNo.Text = "Batal";
            this.tbNo.UseVisualStyleBackColor = false;
            this.tbNo.Click += new System.EventHandler(this.tbNo_Click);
            // 
            // tbYes
            // 
            this.tbYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbYes.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.tbYes.Location = new System.Drawing.Point(337, 204);
            this.tbYes.Name = "tbYes";
            this.tbYes.Size = new System.Drawing.Size(95, 35);
            this.tbYes.TabIndex = 32;
            this.tbYes.Text = "Ganti";
            this.tbYes.UseVisualStyleBackColor = false;
            this.tbYes.Click += new System.EventHandler(this.tbYes_Click);
            // 
            // btGantiPass
            // 
            this.btGantiPass.BackColor = System.Drawing.Color.Khaki;
            this.btGantiPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGantiPass.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.btGantiPass.Location = new System.Drawing.Point(291, 93);
            this.btGantiPass.Name = "btGantiPass";
            this.btGantiPass.Size = new System.Drawing.Size(129, 35);
            this.btGantiPass.TabIndex = 31;
            this.btGantiPass.Text = "Ganti Password";
            this.btGantiPass.UseVisualStyleBackColor = false;
            this.btGantiPass.Click += new System.EventHandler(this.btGantiPass_Click);
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btGantiPass);
            this.Controls.Add(this.panelGantiPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label1);
            this.Name = "FormSetting";
            this.Text = "FormSetting";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.panelGantiPass.ResumeLayout(false);
            this.panelGantiPass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOld;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRepeat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelGantiPass;
        private System.Windows.Forms.Button tbNo;
        private System.Windows.Forms.Button tbYes;
        private System.Windows.Forms.Button btGantiPass;
        private System.Windows.Forms.Label label5;
    }
}