namespace WindowsFormsApp1
{
    partial class FormChild
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
            this.lblSername = new System.Windows.Forms.Label();
            this.txtbInvoiceAmount = new System.Windows.Forms.TextBox();
            this.lblInvoiceAmount = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.comboBoxFIO = new System.Windows.Forms.ComboBox();
            this.btnAddUserFIO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSername
            // 
            this.lblSername.AutoSize = true;
            this.lblSername.Location = new System.Drawing.Point(12, 43);
            this.lblSername.Name = "lblSername";
            this.lblSername.Size = new System.Drawing.Size(24, 13);
            this.lblSername.TabIndex = 0;
            this.lblSername.Text = "FIO";
            // 
            // txtbInvoiceAmount
            // 
            this.txtbInvoiceAmount.Location = new System.Drawing.Point(98, 79);
            this.txtbInvoiceAmount.Name = "txtbInvoiceAmount";
            this.txtbInvoiceAmount.Size = new System.Drawing.Size(137, 20);
            this.txtbInvoiceAmount.TabIndex = 7;
            this.txtbInvoiceAmount.TextChanged += new System.EventHandler(this.txtbInvoiceAmount_TextChanged);
            // 
            // lblInvoiceAmount
            // 
            this.lblInvoiceAmount.AutoSize = true;
            this.lblInvoiceAmount.Location = new System.Drawing.Point(12, 79);
            this.lblInvoiceAmount.Name = "lblInvoiceAmount";
            this.lblInvoiceAmount.Size = new System.Drawing.Size(80, 13);
            this.lblInvoiceAmount.TabIndex = 9;
            this.lblInvoiceAmount.Text = "Invoice amount";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(15, 129);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(106, 45);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(190, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 45);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // comboBoxFIO
            // 
            this.comboBoxFIO.FormattingEnabled = true;
            this.comboBoxFIO.Location = new System.Drawing.Point(98, 34);
            this.comboBoxFIO.Name = "comboBoxFIO";
            this.comboBoxFIO.Size = new System.Drawing.Size(137, 21);
            this.comboBoxFIO.TabIndex = 13;
            // 
            // btnAddUserFIO
            // 
            this.btnAddUserFIO.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.add;
            this.btnAddUserFIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddUserFIO.Location = new System.Drawing.Point(241, 34);
            this.btnAddUserFIO.Name = "btnAddUserFIO";
            this.btnAddUserFIO.Size = new System.Drawing.Size(25, 25);
            this.btnAddUserFIO.TabIndex = 12;
            this.btnAddUserFIO.UseVisualStyleBackColor = true;
            this.btnAddUserFIO.Click += new System.EventHandler(this.btnAddUserFIO_Click);
            // 
            // FormChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 188);
            this.Controls.Add(this.comboBoxFIO);
            this.Controls.Add(this.btnAddUserFIO);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblInvoiceAmount);
            this.Controls.Add(this.txtbInvoiceAmount);
            this.Controls.Add(this.lblSername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormChild";
            this.Text = "Add invoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSername;
        private System.Windows.Forms.TextBox txtbInvoiceAmount;
        private System.Windows.Forms.Label lblInvoiceAmount;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddUserFIO;
        private System.Windows.Forms.ComboBox comboBoxFIO;
    }
}