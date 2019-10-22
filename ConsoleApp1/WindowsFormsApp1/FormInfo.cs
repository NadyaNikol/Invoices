using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entity;

namespace WindowsFormsApp1
{
    public partial class FormInfo : Form
    {
        UserContext db;
        Invoice invoice;


        public Invoice invoiceInfo { private set; get; }

        public FormInfo(int invoiceId)
        {
            InitializeComponent();
            db = new UserContext();
            invoice = db.Invoices.Where(u => u.Id == invoiceId).FirstOrDefault();
            invoice.User = db.Users.Where(u => u.Id == invoice.UserId).FirstOrDefault();
            List<string> listColumns = new List<string> { "Date", "Sum"};


            for (int i = 0; i < listColumns.Count; i++)
            {
                listViewInfo.Columns.Add(listColumns[i]);
                listViewInfo.Columns[i].Width = 130;
            }

            txtbSurname.Text = invoice.User.Surname;
            txtbName.Text = invoice.User.Name;
            txtbPatronymic.Text = invoice.User.Patronymic;

            FillListViewInfo();

        }

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            if(txtbSurname.Enabled)
            {
                btnEditUser.Text = "Edit User";
                invoice.User.Name = txtbName.Text;
                invoice.User.Surname= txtbSurname.Text;
                invoice.User.Patronymic = txtbPatronymic.Text;
            }
            else
                btnEditUser.Text = "Save changed";

            
            txtbSurname.Enabled = txtbName.Enabled = txtbPatronymic.Enabled = !txtbSurname.Enabled;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are sure? When a user is deleted, all his invoices are deleted too!", "Warning", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                User user = invoice.User;
                for (int i = 0; i < user.Invoices.Count; i++)
                {
                    db.Invoices.Remove(user.Invoices[i]);
                }
                db.Users.Remove(user);
                db.SaveChanges();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnChangeInvoice_Click(object sender, EventArgs e)
        {
            if (listViewInfo.SelectedIndices.Count==1)
            {
                if (!txtbEnterSum.Visible)
                {
                    txtbEnterSum.Text = invoice.User.Invoices[listViewInfo.SelectedItems[0].Index].Sum.ToString();
                    btnEditInvoice.Text = "Save changed";
                }
                else
                {
                    btnEditInvoice.Text = "Edit invoices";
                    invoice.User.Invoices[listViewInfo.SelectedItems[0].Index].Sum = Convert.ToDouble(txtbEnterSum.Text);

                    FillListViewInfo();
                }
                txtbEnterSum.Visible = lblEnterSum.Visible = !txtbEnterSum.Visible;
            }
        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            int index = listViewInfo.SelectedItems[0].Index;
            
            db.Invoices.Remove(invoice.User.Invoices[index]);
            listViewInfo.Items.RemoveAt(index);

            
        }

        private void EmptyListViewInfo()
        {
            if (listViewInfo.Items.Count == 0 || listViewInfo.SelectedItems.Count == 0)
            {
                btnEditInvoice.Enabled = btnDeleteInvoice.Enabled = false;
            }
            else
            {
                btnEditInvoice.Enabled = btnDeleteInvoice.Enabled = true;
            }
        }

        private void listViewInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmptyListViewInfo();
        }

     

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);}       
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillListViewInfo()
        {
            listViewInfo.Items.Clear();
            for (int i = 0; i < invoice.User.Invoices.Count; i++)
            {

                ListViewItem item = new ListViewItem(invoice.User.Invoices[i].Date.ToShortDateString());

                item.SubItems.Add(invoice.User.Invoices[i].Sum.ToString());

                listViewInfo.Items.Add(item);
            }

            EmptyListViewInfo();
        }

        private void txtbEnterSum_TextChanged(object sender, EventArgs e)
        {
            double res;

            if (!Double.TryParse(txtbEnterSum.Text, out res))
            {
                txtbEnterSum.Text = "";
            }
        }
    }
}
