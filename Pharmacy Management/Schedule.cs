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
    public partial class fSchedule : Form
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
        public fSchedule()
        {
            InitializeComponent();
        }

        private void fSchedule_Load(object sender, EventArgs e)
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

        private void btReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtDateAndTime.Clear();
            txtAmount.Clear();
        }
        private void dtgvSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgvSchedule.Rows[e.RowIndex];
            txtName.Text = Convert.ToString(row.Cells["name"].Value);
            txtAmount.Text = Convert.ToString(row.Cells["amount"].Value);
            txtDateAndTime.Text = Convert.ToString(row.Cells["dateandtime"].Value);
            IdFocus = Int32.Parse(Convert.ToString(row.Cells["HideID"].Value));
            dtgvSchedule.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.White;
            dtgvSchedule.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private async void btAdd_Click(object sender, EventArgs e)
        {
            if (Checking() == true)
            {
                var Add = new Data
                {
                    Id = (IdNb + 1).ToString(),
                    Name = txtName.Text,
                    Amount = txtAmount.Text,
                    DateAndTime = txtDateAndTime.Text
                };
                SetResponse response1 = await Client.SetTaskAsync("Schedule/Item" + (IdNb + 1).ToString(), Add);
                MessageBox.Show("Đã thêm lời nhắc uống thuốc !!!");
            }    
        }

        private async void btRemove_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc chắn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                FirebaseResponse response = await Client.DeleteTaskAsync("Schedule/Item" + IdFocus.ToString());
                dt.Rows.Clear();
                MessageBox.Show("Đã xóa lời nhắc uống thuốc !!!");
            }    
        }

        private async void btEdit_Click(object sender, EventArgs e)
        {
            if(Checking()==true)
            {
                var edit = new Data
                {
                    Name = txtName.Text,
                    Amount = txtAmount.Text,
                    DateAndTime = txtDateAndTime.Text,
                    Id = IdFocus.ToString()
                };
                FirebaseResponse response3 = await Client.UpdateTaskAsync("Schedule/Item" + IdFocus.ToString(), edit);
                Data result = response3.ResultAs<Data>();
                MessageBox.Show("Đã chỉnh sửa lời nhắc !!!");
            }
        }

        private void txtDateAndTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ID = 0;
            dtgvSchedule.Rows.Clear();
            FirebaseResponse response = Client.Get("Schedule/");
            Dictionary<string, Data> result = response.ResultAs<Dictionary<string, Data>>();
            foreach (var get in result)
            {
                ID = ID + 1;
                dtgvSchedule.Rows.Add(ID, get.Value.Name, get.Value.Amount, get.Value.DateAndTime,get.Value.Id,get.Value.Daily);
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
            else if (txtDateAndTime.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống");
                txtDateAndTime.Focus();
                a = false;
            }
            else
            {
                a = true;
            }
            return a;
        }

        private async void dtgvSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((bool)this.dtgvSchedule.CurrentCell.Value == true)
                {
                    if (Checking() == true)
                    {
                        var edit = new Data
                        {
                            Name = txtName.Text,
                            Amount = txtAmount.Text,
                            DateAndTime = txtDateAndTime.Text,
                            Id = IdFocus.ToString(),
                            Daily = false
                        };
                        FirebaseResponse response3 = await Client.UpdateTaskAsync("Schedule/Item" + IdFocus.ToString(), edit);
                        Data result = response3.ResultAs<Data>();
                    }
                }
                else
                {
                    if (Checking() == true)
                    {
                        var edit = new Data
                        {
                            Name = txtName.Text,
                            Amount = txtAmount.Text,
                            DateAndTime = txtDateAndTime.Text,
                            Id = IdFocus.ToString(),
                            Daily = true
                        };
                        FirebaseResponse response3 = await Client.UpdateTaskAsync("Schedule/Item" + IdFocus.ToString(), edit);
                        Data result = response3.ResultAs<Data>();
                    }
                }
            }
            catch
            {

            }
        }
    }
}
