namespace WindowsFormsApp1
{
    partial class FormInfo
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
            this.listViewInfo = new System.Windows.Forms.ListView();
            this.txtbPatronymic = new System.Windows.Forms.TextBox();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.txtbSurname = new System.Windows.Forms.TextBox();
            this.lblPatronymic = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnEditInvoice = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblEnterSum = new System.Windows.Forms.Label();
            this.txtbEnterSum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewInfo
            // 
            this.listViewInfo.FullRowSelect = true;
            this.listViewInfo.GridLines = true;
            this.listViewInfo.Location = new System.Drawing.Point(12, 139);
            this.listViewInfo.Name = "listViewInfo";
            this.listViewInfo.Size = new System.Drawing.Size(266, 145);
            this.listViewInfo.TabIndex = 18;
            this.listViewInfo.UseCompatibleStateImageBehavior = false;
            this.listViewInfo.View = System.Windows.Forms.View.Details;
            this.listViewInfo.SelectedIndexChanged += new System.EventHandler(this.listViewInfo_SelectedIndexChanged);
            // 
            // txtbPatronymic
            // 
            this.txtbPatronymic.Enabled = false;
            this.txtbPatronymic.Location = new System.Drawing.Point(66, 98);
            this.txtbPatronymic.Name = "txtbPatronymic";
            this.txtbPatronymic.Size = new System.Drawing.Size(212, 20);
            this.txtbPatronymic.TabIndex = 26;
            // 
            // txtbName
            // 
            this.txtbName.Enabled = false;
            this.txtbName.Location = new System.Drawing.Point(66, 52);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(212, 20);
            this.txtbName.TabIndex = 25;
            // 
            // txtbSurname
            // 
            this.txtbSurname.Enabled = false;
            this.txtbSurname.Location = new System.Drawing.Point(66, 12);
            this.txtbSurname.Name = "txtbSurname";
            this.txtbSurname.Size = new System.Drawing.Size(212, 20);
            this.txtbSurname.TabIndex = 24;
            // 
            // lblPatronymic
            // 
            this.lblPatronymic.AutoSize = true;
            this.lblPatronymic.Location = new System.Drawing.Point(1, 98);
            this.lblPatronymic.Name = "lblPatronymic";
            this.lblPatronymic.Size = new System.Drawing.Size(59, 13);
            this.lblPatronymic.TabIndex = 23;
            this.lblPatronymic.Text = "Patronymic";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(1, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(1, 15);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 21;
            this.lblSurname.Text = "Surname";
            this.lblSurname.UseWaitCursor = true;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(12, 341);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(118, 35);
            this.btnEditUser.TabIndex = 27;
            this.btnEditUser.Text = "Edit user";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnChangeUser_Click);
            // 
            // btnEditInvoice
            // 
            this.btnEditInvoice.Enabled = false;
            this.btnEditInvoice.Location = new System.Drawing.Point(160, 340);
            this.btnEditInvoice.Name = "btnEditInvoice";
            this.btnEditInvoice.Size = new System.Drawing.Size(118, 35);
            this.btnEditInvoice.TabIndex = 31;
            this.btnEditInvoice.Text = "Edit invoice";
            this.btnEditInvoice.UseVisualStyleBackColor = true;
            this.btnEditInvoice.Click += new System.EventHandler(this.btnChangeInvoice_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(12, 382);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(118, 35);
            this.btnDeleteUser.TabIndex = 32;
            this.btnDeleteUser.Text = "Delete user";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.Enabled = false;
            this.btnDeleteInvoice.Location = new System.Drawing.Point(160, 381);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(118, 35);
            this.btnDeleteInvoice.TabIndex = 33;
            this.btnDeleteInvoice.Text = "Delete invoice";
            this.btnDeleteInvoice.UseVisualStyleBackColor = true;
            this.btnDeleteInvoice.Click += new System.EventHandler(this.btnDeleteInvoice_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(160, 443);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 45);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 443);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(118, 45);
            this.btnOk.TabIndex = 34;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblEnterSum
            // 
            this.lblEnterSum.AutoSize = true;
            this.lblEnterSum.Location = new System.Drawing.Point(111, 297);
            this.lblEnterSum.Name = "lblEnterSum";
            this.lblEnterSum.Size = new System.Drawing.Size(57, 13);
            this.lblEnterSum.TabIndex = 36;
            this.lblEnterSum.Text = "Enter sum:";
            this.lblEnterSum.Visible = false;
            // 
            // txtbEnterSum
            // 
            this.txtbEnterSum.Location = new System.Drawing.Point(178, 297);
            this.txtbEnterSum.Name = "txtbEnterSum";
            this.txtbEnterSum.Size = new System.Drawing.Size(100, 20);
            this.txtbEnterSum.TabIndex = 37;
            this.txtbEnterSum.Visible = false;
            this.txtbEnterSum.TextChanged += new System.EventHandler(this.txtbEnterSum_TextChanged);
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 495);
            this.Controls.Add(this.txtbEnterSum);
            this.Controls.Add(this.lblEnterSum);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnDeleteInvoice);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnEditInvoice);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.txtbPatronymic);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.txtbSurname);
            this.Controls.Add(this.lblPatronymic);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.listViewInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormInfo";
            this.Text = "Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewInfo;
        private System.Windows.Forms.TextBox txtbPatronymic;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.TextBox txtbSurname;
        private System.Windows.Forms.Label lblPatronymic;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnEditInvoice;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnDeleteInvoice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblEnterSum;
        private System.Windows.Forms.TextBox txtbEnterSum;
    }
}