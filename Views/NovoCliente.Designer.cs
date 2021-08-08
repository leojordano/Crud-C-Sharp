
namespace App1.Views
{
    partial class new_client
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
            this.c_name = new System.Windows.Forms.TextBox();
            this.c_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.c_adress = new System.Windows.Forms.TextBox();
            this.label_adress = new System.Windows.Forms.Label();
            this.c_cpf = new System.Windows.Forms.TextBox();
            this.labelCpf = new System.Windows.Forms.Label();
            this.btn_addUser = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // c_name
            // 
            this.c_name.Location = new System.Drawing.Point(48, 44);
            this.c_name.Name = "c_name";
            this.c_name.Size = new System.Drawing.Size(197, 20);
            this.c_name.TabIndex = 1;
            // 
            // c_email
            // 
            this.c_email.Location = new System.Drawing.Point(48, 88);
            this.c_email.Name = "c_email";
            this.c_email.Size = new System.Drawing.Size(197, 20);
            this.c_email.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // c_adress
            // 
            this.c_adress.Location = new System.Drawing.Point(48, 135);
            this.c_adress.Name = "c_adress";
            this.c_adress.Size = new System.Drawing.Size(197, 20);
            this.c_adress.TabIndex = 5;
            // 
            // label_adress
            // 
            this.label_adress.AutoSize = true;
            this.label_adress.Location = new System.Drawing.Point(45, 118);
            this.label_adress.Name = "label_adress";
            this.label_adress.Size = new System.Drawing.Size(53, 13);
            this.label_adress.TabIndex = 4;
            this.label_adress.Text = "Endereço";
            // 
            // c_cpf
            // 
            this.c_cpf.Location = new System.Drawing.Point(48, 183);
            this.c_cpf.Name = "c_cpf";
            this.c_cpf.Size = new System.Drawing.Size(197, 20);
            this.c_cpf.TabIndex = 7;
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Location = new System.Drawing.Point(45, 166);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(27, 13);
            this.labelCpf.TabIndex = 6;
            this.labelCpf.Text = "CPF";
            // 
            // btn_addUser
            // 
            this.btn_addUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addUser.Location = new System.Drawing.Point(48, 225);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(197, 23);
            this.btn_addUser.TabIndex = 8;
            this.btn_addUser.Text = "Adicionar Cliente";
            this.btn_addUser.UseVisualStyleBackColor = true;
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(48, 265);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(197, 23);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // new_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 346);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_addUser);
            this.Controls.Add(this.c_cpf);
            this.Controls.Add(this.labelCpf);
            this.Controls.Add(this.c_adress);
            this.Controls.Add(this.label_adress);
            this.Controls.Add(this.c_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.c_name);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "new_client";
            this.Text = "Novo Cliente";
            this.Load += new System.EventHandler(this.new_client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox c_name;
        private System.Windows.Forms.TextBox c_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox c_adress;
        private System.Windows.Forms.Label label_adress;
        private System.Windows.Forms.TextBox c_cpf;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.Button btn_addUser;
        private System.Windows.Forms.Button btn_cancel;
    }
}