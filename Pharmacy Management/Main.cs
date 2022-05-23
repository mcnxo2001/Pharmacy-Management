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
    public partial class Main : Form
    {
        int[] ColorButton = new int[10];
        IFirebaseConfig Config = new FirebaseConfig()
        {
            AuthSecret = "fAVoFduOUhfe8PBxmFkw6K2GPvoWmMeahsjqERx4",
            BasePath = "https://fir-foresp-ad007-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient Client;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Client = new FireSharp.FirebaseClient(Config);
            }
            catch(IndexOutOfRangeException e1)
            {
                MessageBox.Show(e1.Message);
            }
            OpenForm(new ShowDrug());
            txtTheme.Text = button1.Text;
            ColorButton[1] = 1;
            ColorButton[2] = 0;
            ColorButton[3] = 0;
            ChangeColor();
        }

        private Form CurrnentForm;
        private void OpenForm(Form ChillForm)
        {
            if (CurrnentForm != null)
            {
                CurrnentForm.Close();
            }
            CurrnentForm = ChillForm;
            ChillForm.TopLevel = false;
            ChillForm.FormBorderStyle = FormBorderStyle.None;//xóa nút 
            ChillForm.Dock = DockStyle.Fill;//Cho form con lấp đầy 
            panelMain.Controls.Add(ChillForm);
            panelMain.Tag = ChillForm;//truyền tải form con vào panelMain
            ChillForm.BringToFront();//Mang Form con ra trước
            ChillForm.Show();//Hiện thị form con
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void ChangeColor()
        {
            if(ColorButton[1]== 1)
            {
                button1.BackColor = Color.White;
                button1.ForeColor = Color.Black;
            }
            else
            {
                button1.BackColor = Color.DodgerBlue;
                button1.ForeColor = Color.White;
            }
            if (ColorButton[2] == 1)
            {
                button2.BackColor = Color.White;
                button2.ForeColor = Color.Black;
            }
            else
            {
                button2.BackColor = Color.DodgerBlue;
                button2.ForeColor = Color.White;
            }
            if (ColorButton[3] == 1)
            {
                button3.BackColor = Color.White;
                button3.ForeColor = Color.Black;
            }
            else
            {
                button3.BackColor = Color.DodgerBlue;
                button3.ForeColor = Color.White;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(new ShowDrug());
            txtTheme.Text = button1.Text;
            ColorButton[1] = 1;
            ColorButton[2] = 0;
            ColorButton[3] = 0;
            ChangeColor();
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenForm(new MedicalBox());
            txtTheme.Text = button3.Text;
            ColorButton[1] = 0;
            ColorButton[2] = 0;
            ColorButton[3] = 1;
            ChangeColor();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenForm(new fSchedule());
            txtTheme.Text = button2.Text;
            ColorButton[1] = 0;
            ColorButton[2] = 1;
            ColorButton[3] = 0;
            ChangeColor();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
   
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
       
    }
}
