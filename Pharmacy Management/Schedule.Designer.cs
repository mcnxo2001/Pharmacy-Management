
namespace Pharmacy_Management
{
    partial class fSchedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btReset = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.dtgvSchedule = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDateAndTime = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateandtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hideid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daily = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSchedule)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.ForeColor = System.Drawing.Color.White;
            this.btReset.Location = new System.Drawing.Point(702, 147);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(127, 39);
            this.btReset.TabIndex = 12;
            this.btReset.Text = "Làm mới";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.Gold;
            this.btEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.ForeColor = System.Drawing.Color.White;
            this.btEdit.Location = new System.Drawing.Point(702, 102);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(127, 39);
            this.btEdit.TabIndex = 9;
            this.btEdit.Text = "Chỉnh sửa";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btRemove
            // 
            this.btRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemove.ForeColor = System.Drawing.Color.White;
            this.btRemove.Location = new System.Drawing.Point(702, 57);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(127, 39);
            this.btRemove.TabIndex = 10;
            this.btRemove.Text = "Xóa";
            this.btRemove.UseVisualStyleBackColor = false;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Lime;
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Location = new System.Drawing.Point(702, 12);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(127, 39);
            this.btAdd.TabIndex = 11;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dtgvSchedule
            // 
            this.dtgvSchedule.AllowUserToAddRows = false;
            this.dtgvSchedule.AllowUserToDeleteRows = false;
            this.dtgvSchedule.BackgroundColor = System.Drawing.Color.White;
            this.dtgvSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.name,
            this.amount,
            this.dateandtime,
            this.hideid,
            this.daily});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvSchedule.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvSchedule.Location = new System.Drawing.Point(12, 102);
            this.dtgvSchedule.Name = "dtgvSchedule";
            this.dtgvSchedule.ReadOnly = true;
            this.dtgvSchedule.RowHeadersVisible = false;
            this.dtgvSchedule.RowHeadersWidth = 51;
            this.dtgvSchedule.RowTemplate.Height = 24;
            this.dtgvSchedule.Size = new System.Drawing.Size(685, 323);
            this.dtgvSchedule.TabIndex = 7;
            this.dtgvSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSchedule_CellClick);
            this.dtgvSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSchedule_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.txtDateAndTime);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 84);
            this.panel1.TabIndex = 13;
            // 
            // txtDateAndTime
            // 
            this.txtDateAndTime.Font = new System.Drawing.Font("Times New Roman", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateAndTime.Location = new System.Drawing.Point(450, 37);
            this.txtDateAndTime.Multiline = true;
            this.txtDateAndTime.Name = "txtDateAndTime";
            this.txtDateAndTime.Size = new System.Drawing.Size(212, 30);
            this.txtDateAndTime.TabIndex = 4;
            this.txtDateAndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDateAndTime.TextChanged += new System.EventHandler(this.txtDateAndTime_TextChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Times New Roman", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(232, 37);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(212, 30);
            this.txtAmount.TabIndex = 4;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(14, 37);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(212, 30);
            this.txtName.TabIndex = 4;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Times New Roman", 11.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(295, 7);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(90, 35);
            this.textBox7.TabIndex = 3;
            this.textBox7.Text = "Số lượng";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Times New Roman", 11.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(494, 7);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(134, 35);
            this.textBox8.TabIndex = 3;
            this.textBox8.Text = "Thời gian";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Times New Roman", 11.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(78, 7);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(81, 35);
            this.textBox6.TabIndex = 3;
            this.textBox6.Text = "Tên";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 155;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Width = 85;
            // 
            // dateandtime
            // 
            this.dateandtime.HeaderText = "DateAndTime";
            this.dateandtime.MinimumWidth = 6;
            this.dateandtime.Name = "dateandtime";
            this.dateandtime.ReadOnly = true;
            this.dateandtime.Width = 172;
            // 
            // hideid
            // 
            this.hideid.HeaderText = "HideID";
            this.hideid.MinimumWidth = 6;
            this.hideid.Name = "hideid";
            this.hideid.ReadOnly = true;
            this.hideid.Visible = false;
            this.hideid.Width = 125;
            // 
            // daily
            // 
            this.daily.HeaderText = "Mỗi ngày";
            this.daily.MinimumWidth = 6;
            this.daily.Name = "daily";
            this.daily.ReadOnly = true;
            this.daily.Width = 50;
            // 
            // fSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(841, 603);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dtgvSchedule);
            this.Name = "fSchedule";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.fSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSchedule)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridView dtgvSchedule;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDateAndTime;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateandtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn hideid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn daily;
    }
}