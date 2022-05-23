using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Pharmacy_Management
{
    public partial class MedicalBox : Form
    {
        int IdNb = 0;
        int IdFocus = 0;
        int ID = 0;
        DataTable dt = new DataTable();
        IFirebaseConfig Config = new FirebaseConfig
        {
            AuthSecret = "fAVoFduOUhfe8PBxmFkw6K2GPvoWmMeahsjqERx4",
            BasePath = "https://fir-foresp-ad007-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient Client;
        public MedicalBox()
        {
            InitializeComponent();
        }

        private void MedicalBox_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            try
            {
                Client = new FireSharp.FirebaseClient(Config);

            }
            catch
            {
                MessageBox.Show("Problem in the internet!");
            }
        }

        private async void btAdd_Click(object sender, EventArgs e)
        {   
            if(Checking()==true)
            {
                var Add = new Medicine
                {
                    Id = (IdNb + 1).ToString(),
                    Name = txtName.Text,
                    Amount = txtAmount.Text,
                    ExpiryDate = txtExpiry.Text
                };
                SetResponse response1 = await Client.SetTaskAsync("Medicine/Item" + (IdNb + 1).ToString(), Add);
                MessageBox.Show("Đã thêm thuốc vào danh sách !!!");
            }
        }

        private async void btRemove_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc chắn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                FirebaseResponse response = await Client.DeleteTaskAsync("Medicine/Item" + IdFocus.ToString());
                dt.Rows.Clear();
                MessageBox.Show("Đã xóa thuốc khỏi danh sách !!!");
            }      
        }

        private void dtgvMedicine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgvMedicine.Rows[e.RowIndex];
            txtName.Text = Convert.ToString(row.Cells["name"].Value);
            txtAmount.Text = Convert.ToString(row.Cells["amount"].Value);
            txtExpiry.Text = Convert.ToString(row.Cells["ExpiryDate"].Value);
            IdFocus = Int32.Parse(Convert.ToString(row.Cells["HideID"].Value));
            dtgvMedicine.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.White;
            dtgvMedicine.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private async void btEdit_Click(object sender, EventArgs e)
        {
            if (Checking() == true)
            {
                var edit = new Medicine
                {
                    Name = txtName.Text,
                    Amount = txtAmount.Text,
                    ExpiryDate = txtExpiry.Text,
                    Id = IdFocus.ToString()
                };
                FirebaseResponse response3 = await Client.UpdateTaskAsync("Medicine/Item" + IdFocus.ToString(), edit);
                Medicine result = response3.ResultAs<Medicine>();
                MessageBox.Show("Đã chỉnh sửa đơn thuốc !!!");
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtExpiry.Clear();
            txtAmount.Clear();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExpiry_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ID = 0;
            dtgvMedicine.Rows.Clear();
            FirebaseResponse response = Client.Get("Medicine/");
            Dictionary<string, Medicine> result = response.ResultAs<Dictionary<string, Medicine>>();
            foreach (var get in result)
            {
                ID = ID + 1;
                dtgvMedicine.Rows.Add(ID, get.Value.Name, get.Value.Amount, get.Value.ExpiryDate,get.Value.Id);
                if (Int32.Parse(get.Value.Id) > IdNb)
                {
                    IdNb = Int32.Parse(get.Value.Id);
                }
            }
        }
        private bool Checking()
        {
            bool a;
            if (txtName.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống");
                txtName.Focus();
                a = false;
            }
            else if (txtAmount.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống");
                txtAmount.Focus();
                a = false;
            }
            else if (txtExpiry.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống");
                txtExpiry.Focus();
                a = false;
            }
            else
            {
                a = true;
            }
            return a;
        }
    }
}
