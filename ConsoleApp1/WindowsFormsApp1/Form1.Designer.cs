namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.txtbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewInvoices = new System.Windows.Forms.ListView();
            this.lblAllSum = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSearch = new System.Windows.Forms.Button();
            this.formChildBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.formChildBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbSearch
            // 
            this.txtbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbSearch.Location = new System.Drawing.Point(216, 25);
            this.txtbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtbSearch.Name = "txtbSearch";
            this.txtbSearch.Size = new System.Drawing.Size(195, 23);
            this.txtbSearch.TabIndex = 4;
            this.txtbSearch.TextChanged += new System.EventHandler(this.txtbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "All Sum:";
            // 
            // listViewInvoices
            // 
            this.listViewInvoices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewInvoices.FullRowSelect = true;
            this.listViewInvoices.GridLines = true;
            this.listViewInvoices.Location = new System.Drawing.Point(21, 65);
            this.listViewInvoices.Name = "listViewInvoices";
            this.listViewInvoices.Size = new System.Drawing.Size(420, 199);
            this.listViewInvoices.TabIndex = 11;
            this.listViewInvoices.UseCompatibleStateImageBehavior = false;
            this.listViewInvoices.View = System.Windows.Forms.View.Details;
            this.listViewInvoices.SelectedIndexChanged += new System.EventHandler(this.listViewUsers_SelectedIndexChanged);
            // 
            // lblAllSum
            // 
            this.lblAllSum.AutoSize = true;
            this.lblAllSum.Location = new System.Drawing.Point(305, 291);
            this.lblAllSum.Name = "lblAllSum";
            this.lblAllSum.Size = new System.Drawing.Size(0, 13);
            this.lblAllSum.TabIndex = 12;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(453, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(415, 25);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(26, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // formChildBindingSource
            // 
            this.formChildBindingSource.DataSource = typeof(WindowsFormsApp1.FormChild);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 328);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblAllSum);
            this.Controls.Add(this.listViewInvoices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Invoice";
            ((System.ComponentModel.ISupportInitialize)(this.formChildBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource formChildBindingSource;
        private System.Windows.Forms.ListView listViewInvoices;
        private System.Windows.Forms.Label lblAllSum;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

