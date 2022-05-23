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
        int MedicineEnable = 0;
        int MedicineUnable = 0;
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
            FirebaseResponse response = Client.Get("Medicine/");
            Dictionary<string, Medicine> result = response.ResultAs<Dictionary<string, Medicine>>();
            foreach (var get in result)
            {
                Cutexpiry = get.Value.ExpiryDate.ToString().Split(' ');
                dateexpiry = DateTime.Parse(Cutexpiry[1]);
                if(dateexpiry>DateTime.Now)
                {
                    MedicineEnable = MedicineEnable + 1;
                }
                else
                {
                    MedicineUnable = MedicineUnable + 1;
                }
            }
            chartMedicine.Series["Số lượng"].Points.Add(MedicineEnable);
            chartMedicine.Series["Số lượng"].Points[0].Color = Color.Green;
            chartMedicine.Series["Số lượng"].Points[0].AxisLabel = "Thuốc còn hạn";

            chartMedicine.Series["Số lượng"].Points.Add(MedicineUnable);
            chartMedicine.Series["Số lượng"].Points[1].Color = Color.Red;
            chartMedicine.Series["Số lượng"].Points[1].AxisLabel = "Thuốc hết hạn";

            chartMedicine.Titles.Add("LƯỢNG THUỐC CÒN HẠN VÀ HẾT HẠN SỬ DỤNG");
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
        }
    }
}
