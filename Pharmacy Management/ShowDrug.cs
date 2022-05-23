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
    public partial class ShowDrug : Form
    {
        int ID1 = 0;
        string[] Cutexpiry;
        DateTime dateexpiry;
        DataTable dt = new DataTable();
        DateTime NotificationTime = new DateTime(2022, 5, 20, 10, 30, 0);
        //int a = 0;
        IFirebaseConfig Config = new FirebaseConfig
        {
            AuthSecret = "fAVoFduOUhfe8PBxmFkw6K2GPvoWmMeahsjqERx4",
            BasePath = "https://fir-foresp-ad007-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient Client;
        public ShowDrug()
        {
            InitializeComponent();
        }

        private void ShowDrug_Load(object sender, EventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            ID1 = 0;
            dtgvShowMedicine.Rows.Clear();
            FirebaseResponse response = Client.Get("Schedule/");
            Dictionary<string, Data> result = response.ResultAs<Dictionary<string, Data>>();
            foreach (var get in result)
            {            
                if (DateTime.Now >= DateTime.Parse(get.Value.DateAndTime.ToString()).AddMinutes(-5) && DateTime.Now<= DateTime.Parse(get.Value.DateAndTime.ToString()))
                {
                    ID1 = ID1 + 1;
                    dtgvShowMedicine.Rows.Add(ID1, get.Value.Name, get.Value.Amount, get.Value.DateAndTime);
                }
            }
            charMedicine();
            DailyRemind();
        }

        private void charMedicine()
        {
            foreach (var series in chartMedicineEnable.Series)
            {
                series.Points.Clear();
            }
            int MedicineEnable = 0;
            int MedicineUnable = 0;
            FirebaseResponse response = Client.Get("Medicine/");
            Dictionary<string, Medicine> result = response.ResultAs<Dictionary<string, Medicine>>();
            foreach (var get in result)
            {
                Cutexpiry = get.Value.ExpiryDate.ToString().Split(' ');
                dateexpiry = DateTime.Parse(Cutexpiry[1]);
                if (dateexpiry > DateTime.Now)
                {
                    MedicineEnable = MedicineEnable + 1;
                }
                else
                {
                    MedicineUnable = MedicineUnable + 1;
                }
            }
            chartMedicineEnable.Series["Số lượng"].Points.Add(MedicineEnable);
            chartMedicineEnable.Series["Số lượng"].Points[0].Color = Color.Green;
            chartMedicineEnable.Series["Số lượng"].Points[0].AxisLabel = "Thuốc còn hạn";

            chartMedicineEnable.Series["Số lượng"].Points.Add(MedicineUnable);
            chartMedicineEnable.Series["Số lượng"].Points[1].Color = Color.Red;
            chartMedicineEnable.Series["Số lượng"].Points[1].AxisLabel = "Thuốc hết hạn";

        }
        private async void DailyRemind()
        {
            FirebaseResponse response = Client.Get("Schedule/");
            Dictionary<string, Data> result = response.ResultAs<Dictionary<string, Data>>();
            foreach (var get in result)
            {
                if (DateTime.Now >= DateTime.Parse(get.Value.DateAndTime.ToString()).AddSeconds(-1) && DateTime.Now <= DateTime.Parse(get.Value.DateAndTime.ToString()) && (bool)get.Value.Daily == true)
                {
                    DateTime DailyTime = DateTime.Parse(get.Value.DateAndTime).AddDays(1);
                    var edit = new Data
                    {
                        Name = get.Value.Name,
                        Amount = get.Value.Amount,
                        DateAndTime =DailyTime.ToString(),
                        Id = get.Value.Id,
                        Daily = true
                    };
                    FirebaseResponse response3 = await Client.UpdateTaskAsync("Schedule/Item" + get.Value.Id.ToString(), edit);
                }
            }
        }
    }
}
