
namespace App1.Views
{
    partial class ListClients
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
            this.ListViewClients = new System.Windows.Forms.ListView();
            this.HeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderAdress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderCpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ListViewClients
            // 
            this.ListViewClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HeaderId,
            this.HeaderName,
            this.HeaderEmail,
            this.HeaderAdress,
            this.HeaderCpf});
            this.ListViewClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewClients.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ListViewClients.FullRowSelect = true;
            this.ListViewClients.GridLines = true;
            this.ListViewClients.HideSelection = false;
            this.ListViewClients.Location = new System.Drawing.Point(0, 0);
            this.ListViewClients.Name = "ListViewClients";
            this.ListViewClients.Size = new System.Drawing.Size(524, 334);
            this.ListViewClients.TabIndex = 0;
            this.ListViewClients.UseCompatibleStateImageBehavior = false;
            this.ListViewClients.View = System.Windows.Forms.View.Details;
            this.ListViewClients.SelectedIndexChanged += new System.EventHandler(this.ListViewClients_SelectedIndexChanged);
            // 
            // HeaderName
            // 
            this.HeaderName.Text = "Nome";
            // 
            // HeaderAdress
            // 
            this.HeaderAdress.DisplayIndex = 2;
            this.HeaderAdress.Text = "Endereço";
            // 
            // HeaderEmail
            // 
            this.HeaderEmail.DisplayIndex = 3;
            this.HeaderEmail.Text = "Email";
            // 
            // HeaderCpf
            // 
            this.HeaderCpf.Text = "CPF";
            // 
            // HeaderId
            // 
            this.HeaderId.Text = "Id";
            // 
            // ListClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 334);
            this.Controls.Add(this.ListViewClients);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListClients";
            this.Text = "ListClients";
            this.Load += new System.EventHandler(this.ListClients_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListViewClients;
        private System.Windows.Forms.ColumnHeader HeaderName;
        private System.Windows.Forms.ColumnHeader HeaderAdress;
        private System.Windows.Forms.ColumnHeader HeaderEmail;
        private System.Windows.Forms.ColumnHeader HeaderCpf;
        private System.Windows.Forms.ColumnHeader HeaderId;
    }
}