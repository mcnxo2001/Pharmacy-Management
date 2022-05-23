
namespace Pharmacy_Management
{
    partial class ShowDrug
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dtgvShowMedicine = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateandtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartMedicineEnable = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMedicineEnable)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvShowMedicine
            // 
            this.dtgvShowMedicine.AllowUserToAddRows = false;
            this.dtgvShowMedicine.AllowUserToDeleteRows = false;
            this.dtgvShowMedicine.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvShowMedicine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvShowMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvShowMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.amount,
            this.dateandtime});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvShowMedicine.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvShowMedicine.Location = new System.Drawing.Point(106, 41);
            this.dtgvShowMedicine.Name = "dtgvShowMedicine";
            this.dtgvShowMedicine.ReadOnly = true;
            this.dtgvShowMedicine.RowHeadersVisible = false;
            this.dtgvShowMedicine.RowHeadersWidth = 51;
            this.dtgvShowMedicine.RowTemplate.Height = 24;
            this.dtgvShowMedicine.Size = new System.Drawing.Size(640, 178);
            this.dtgvShowMedicine.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 135;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Width = 70;
            // 
            // dateandtime
            // 
            this.dateandtime.HeaderText = "DateAndTime";
            this.dateandtime.MinimumWidth = 6;
            this.dateandtime.Name = "dateandtime";
            this.dateandtime.ReadOnly = true;
            this.dateandtime.Width = 222;
            // 
            // chartMedicineEnable
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMedicineEnable.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMedicineEnable.Legends.Add(legend1);
            this.chartMedicineEnable.Location = new System.Drawing.Point(106, 225);
            this.chartMedicineEnable.Name = "chartMedicineEnable";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Số lượng";
            this.chartMedicineEnable.Series.Add(series1);
            this.chartMedicineEnable.Size = new System.Drawing.Size(640, 323);
            this.chartMedicineEnable.TabIndex = 3;
            this.chartMedicineEnable.Text = "chart1";
            title1.Name = "abc";
            title1.Text = "LƯỢNG THUỐC CÒN HẠN VÀ HẾT HẠN SỬ DỤNG";
            this.chartMedicineEnable.Titles.Add(title1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(294, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "ĐƠN THUỐC SẮP TỚI";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ShowDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(841, 603);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chartMedicineEnable);
            this.Controls.Add(this.dtgvShowMedicine);
            this.Name = "ShowDrug";
            this.Text = "ShowDrug";
            this.Load += new System.EventHandler(this.ShowDrug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMedicineEnable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvShowMedicine;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMedicineEnable;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateandtime;
    }
}