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
    public partial class FormAddFIOUser : Form
    {
        UserContext db;

        public FormAddFIOUser()
        {
            InitializeComponent();

            db = new UserContext();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbName.Text) || String.IsNullOrEmpty(txtbSurname.Text) ||
                String.IsNullOrEmpty(txtbPatronymic.Text))
               { MessageBox.Show("Fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }


            else
            {
                try
                {
                    db.Users.Add(new User
                    {
                        Name = txtbName.Text,
                        Surname = txtbSurname.Text,
                        Patronymic = txtbPatronymic.Text,
                        SexId = radioButtonMale.Checked ? 1 : 2
                    });
                    db.SaveChanges();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message);}

                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
