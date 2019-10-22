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
    public partial class Form1 : Form
    {
        UserContext db;
        List<Invoice> invoices;
        List<User> users;
        ToolBarButton toolBarInfo = null;
        ToolBarButton toolBarAdd = null;
        ToolBarButton toolBarDelete = null;
        double allSum = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeToolBar();
            listViewInvoices.HideSelection = false;
            InitializeListViewInvoices();

            CountAllSum();
        }

        private void ToolBar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            switch (e.Button.Text)
            {
                case "Info":
                    {
                        int index = listViewInvoices.SelectedItems[0].Index;
                        FormInfo formInfo = new FormInfo(invoices[index].Id);
                        if(formInfo.ShowDialog() == DialogResult.OK)
                        {
                            FillListViewInvoices();                       
                        }
                        break;
                    }
                case "Add":
                    {
                        FormChild Add = new FormChild(
                            listViewInvoices.SelectedItems.Count>0?invoices[listViewInvoices.SelectedItems[0].Index].User.Id:0);
                        if (Add.ShowDialog() == DialogResult.OK)
                        {
                            
                            allSum += Add.Amount;
                            lblAllSum.Text = allSum.ToString();
                            FillListViewInvoices();

                        }

                        break;
                    }

                case "Delete":
                    {
                        try
                        {
                            DeleteInvoice();
                            db.SaveChanges();
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message);}                                       
                        break;
                    }
                default:
                    break;
            }
        }

        private void DeleteInvoice()
        {
            int index = listViewInvoices.SelectedItems[0].Index;

            allSum -= invoices[index].Sum;
            lblAllSum.Text = allSum.ToString();

            db.Invoices.Remove(invoices[index]);
            invoices.RemoveAt(index);
            listViewInvoices.Items.RemoveAt(index);
        }


        private void EmptyListViewInvoices()
        {
            if (listViewInvoices.Items.Count == 0 || listViewInvoices.SelectedItems.Count == 0)
            {
                toolBarInfo.Enabled = toolBarDelete.Enabled = false;
            }
            else
            {
                toolBarInfo.Enabled = toolBarDelete.Enabled = true;
            }
        }


        private void listViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmptyListViewInvoices();
        }

        private void FillListViewInvoices()
        {
            db = new UserContext();
            invoices = db.Invoices.ToList();
            users = db.Users.ToList();
            listViewInvoices.Items.Clear();

            for (int i = 0; i < invoices.Count; i++)
            {

                ListViewItem item = new ListViewItem(invoices[i].User.Surname);

                item.SubItems.Add(invoices[i].User.Name);
                item.SubItems.Add(invoices[i].User.Patronymic);
                item.SubItems.Add(invoices[i].Date.ToShortDateString());
                item.SubItems.Add(invoices[i].Sum.ToString());

                listViewInvoices.Items.Add(item);
            }
            EmptyListViewInvoices();
        }

        private void InitializeToolBar()
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(30, 30);
            imageList.Images.Add(new Bitmap("Info.bmp"));
            imageList.Images.Add(new Bitmap("Add.bmp"));
            imageList.Images.Add(new Bitmap("Delete.bmp"));

            ToolBar toolBar = new ToolBar();
            toolBar.ImageList = imageList;
            toolBarInfo = new ToolBarButton();
            toolBarAdd = new ToolBarButton();
            toolBarDelete = new ToolBarButton();


            toolBarInfo.Text = "Info";
            toolBarAdd.Text = "Add";
            toolBarDelete.Text = "Delete";


            toolBarInfo.ImageIndex = 0;
            toolBarAdd.ImageIndex = 1;
            toolBarDelete.ImageIndex = 2;

            toolBar.Buttons.Add(toolBarInfo);
            toolBar.Buttons.Add(toolBarAdd);
            toolBar.Buttons.Add(toolBarDelete);

            Controls.Add(toolBar);

            toolBar.ButtonClick += ToolBar_ButtonClick;
        }

        private void InitializeListViewInvoices()
        {
            List<string> listColumns = new List<string> { "Sername", "Name", "Patronymic", "Date", "Sum" };

            for (int i = 0; i < listColumns.Count; i++)
            {
                listViewInvoices.Columns.Add(listColumns[i]);
                listViewInvoices.Columns[i].Width = 85;
            }

            FillListViewInvoices();

            EmptyListViewInvoices();
        }

        private void CountAllSum()
        {
            for (int i = 0; i < invoices.Count; i++)
            {
                allSum += invoices[i].Sum;
            }
            lblAllSum.Text = allSum.ToString();
        }

        private void txtbSearch_TextChanged(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtbSearch.Text))
            {
                foreach (ListViewItem item in listViewInvoices.Items)
                {
                    if (item.Text.ToLower().Contains(txtbSearch.Text.ToLower()))
                    { item.Selected = true; }

                    else { listViewInvoices.Items.Remove(item); }
                }

                if (listViewInvoices.SelectedItems.Count == 1)
                { listViewInvoices.Focus(); }
            }

            else
            { FillListViewInvoices(); }

        }
    }
}
