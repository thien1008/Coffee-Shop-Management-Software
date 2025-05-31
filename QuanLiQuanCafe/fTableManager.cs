using QuanLiQuanCafe.DAO;
using QuanLiQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuanLiQuanCafe
{
    public partial class fTableManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount 
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        public fTableManager(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;

            LoadTable();
            LoadCategory();
            LoadComboboxTable(cbSwitchTable);
        }
        #region Method

        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            thôngTinTàiToolStripMenuItem.Text += " (" + LoginAccount.DisplayName + ")";
        }
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource= listCategory;
            cbCategory.DisplayMember = "Name";
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource= listFood;
            cbFood.DisplayMember = "Name";
        }

        void LoadTable()
        {
            flpTable.Controls.Clear();

            List<Table> tableList = TableDAO.Instance.GetListTable();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += Btn_Click;
                btn.Tag= item;

                flpTable.Controls.Add(btn);

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
            }
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }

            CultureInfo culture = new CultureInfo("vi-VN");
            //Thread.CurrentThread.CurrentCulture = culture;

            txbTotalPrice.Text = totalPrice.ToString("c", culture);
        }

        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.GetListTable();
            cb.DisplayMember = "Name";
        }

        #endregion


        #region Events
        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCheckOut_Click(this, new EventArgs());
        }

        private void thêmMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddFood_Click(this, new EventArgs());
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.loginAccount = loginAccount;
            f.InsertFood += F_InsertFood;
            f.DeleteFood += F_DeleteFood;
            f.UpdateFood += F_UpdateFood;
            f.ShowDialog();
        }

        private void F_UpdateFood(object? sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if(lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }

        private void F_DeleteFood(object? sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
            LoadTable();
        }

        private void F_InsertFood(object? sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }

        private void đăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(LoginAccount);
            f.UpdateAccount += F_UpdateAccount;
            f.ShowDialog();
        }

        private void F_UpdateAccount(object? sender, AccountEvent e)
        {
            thôngTinTàiToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if(cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadFoodListByCategoryID(id);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cbFood.SelectedItem as Food).ID;
            int count = (int)nmFoodCount.Value;
                
            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }

            ShowBill(table.ID);

            LoadTable();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Vui Lòng chọn bàn cần thanh toán");
                return;
            }


            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);

            int discount = (int)nmDiscount.Value;

            float totalPrice = float.Parse(txbTotalPrice.Text.Split(",")[0]);
            float finalTotalPrice = totalPrice - (totalPrice / 100)*discount;
            
            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc muốn thanh toán hóa đơn cho {0}\nTổng tiền - (Tổng tiền / 100) x Giảm giá\n => {1} - ({1} / 100) x {2} = {3}",table.Name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, finalTotalPrice);
                    ShowBill(table.ID);

                    LoadTable();
                }
            }
        }


        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            if (lsvBill.Tag == null)
            {
                MessageBox.Show("Vui lòng chọn bàn cần chuyển qua bàn " + (cbSwitchTable.SelectedItem as Table).Name);
                return;
            }
            int id1 = (lsvBill.Tag as Table).ID;

            int id2 = (cbSwitchTable.SelectedItem as Table).ID;

            if (MessageBox.Show(string.Format("Bạn có thực sự muốn chuyển bàn {0} qua bàn {1}", (lsvBill.Tag as Table).Name, (cbSwitchTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(id1, id2);
                if ((lsvBill.Tag as Table).Status == "Có người" && (cbSwitchTable.SelectedItem as Table).Status == "Trống")
                {
                    DataProvider.Instance.ExecuteQuery("update dbo.TableFood set status = N'Trống' where id = " + id1);
                    DataProvider.Instance.ExecuteQuery("update dbo.TableFood set status = N'Có người' where id = " + id2);

                }
                else if ((lsvBill.Tag as Table).Status == "Trống" && (cbSwitchTable.SelectedItem as Table).Status == "Có người")
                {
                    DataProvider.Instance.ExecuteQuery("update dbo.TableFood set status = N'Có người' where id = " + id1);
                    DataProvider.Instance.ExecuteQuery("update dbo.TableFood set status = N'Trống' where id = " + id2);
                }
                else if ((lsvBill.Tag as Table).Status == "Trống" && (cbSwitchTable.SelectedItem as Table).Status == "Trống")
                {
                    DataProvider.Instance.ExecuteQuery("update dbo.TableFood set status = N'Trống' where id = " + id1);
                    DataProvider.Instance.ExecuteQuery("update dbo.TableFood set status = N'Trống' where id = " + id2);
                }
                else if ((lsvBill.Tag as Table).Status == "Có người" && (cbSwitchTable.SelectedItem as Table).Status == "Có người")
                {
                    DataProvider.Instance.ExecuteQuery("update dbo.TableFood set status = N'Có người' where id = " + id1);
                    DataProvider.Instance.ExecuteQuery("update dbo.TableFood set status = N'Có người' where id = " + id2);
                }

                ////chuyển xong sẽ update lại table ban đầu thành trống


                ////chuyển xong sẽ update lại table ban đầu thành trống
                //string query1 = "update TableFood set status = N'Trống' where id=" + id1;
                ////update table chuyển qua thành có người
                //string query2 = "update TableFood set status = N'Có người' where id=" + id2;
                //SqlCommand cmd = new SqlCommand(query1, sql);
                //cmd.ExecuteNonQuery();
                //cmd = new SqlCommand(query2, sql);
                //cmd.ExecuteNonQuery();
                //LoadTable();

                LoadTable();
            }

        }

        #endregion

        
    }
}
