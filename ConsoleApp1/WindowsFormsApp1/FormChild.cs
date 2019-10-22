using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entity;

namespace WindowsFormsApp1
{
    public partial class FormChild : Form
    {
        UserContext db;
        List<User> users = null;
        public DateTime DataInvoice { private set; get; }
        public int idUser { get; set; }
        public int selectedUser;
        public double Amount
        {
            private set { value =Convert.ToDouble( txtbInvoiceAmount.Text); }
            get { return Convert.ToDouble(txtbInvoiceAmount.Text); }
        }


        public FormChild(int IdUser=0)
        {
            db = new UserContext();
            users = db.Users.ToList();
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Id==IdUser)
                {
                    selectedUser = i;
                    break;
                }
            }
            InitializeComponent();
            
            FillComboBoxFIO();
        }

        private void FillComboBoxFIO()
        {
            users = db.Users.ToList();

            bool isNewUser = comboBoxFIO.Items.Count == users.Count ? true : false;
            comboBoxFIO.Items.Clear();
            for (int i = 0; i < users.Count; i++)
            {
                comboBoxFIO.Items.Add(users[i].Surname + " " + users[i].Name + " " + users[i].Patronymic);
            }

            if (comboBoxFIO.Items.Count > 0)
            {
                comboBoxFIO.SelectedIndex = isNewUser ? comboBoxFIO.Items.Count - 1 : selectedUser;
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(comboBoxFIO.Text) || String.IsNullOrEmpty(txtbInvoiceAmount.Text))
                MessageBox.Show("Fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                DataInvoice = DateTime.Now;
                idUser = users[comboBoxFIO.SelectedIndex].Id;

                try
                {
                    db.Invoices.Add(new Invoice
                    {
                        UserId = idUser,
                        Date = DataInvoice,
                        Sum = Convert.ToDouble(txtbInvoiceAmount.Text)
                    });
                    db.SaveChanges();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message);}

                this.DialogResult = DialogResult.OK;
            }
        }

        //проверка на ввод числа
        private void txtbInvoiceAmount_TextChanged(object sender, EventArgs e)
        {
            double res;

            if (!Double.TryParse(txtbInvoiceAmount.Text, out res))
            {
                txtbInvoiceAmount.Text = "";
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUserFIO_Click(object sender, EventArgs e)
        {
            FormAddFIOUser formAddFIOUser = new FormAddFIOUser();
            if (formAddFIOUser.ShowDialog() == DialogResult.OK)
            {
                FillComboBoxFIO();
            }
        }
    }
}
