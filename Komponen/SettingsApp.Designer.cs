﻿
using FontAwesome.Sharp;
namespace KASIR.Komponen
{
    partial class SettingsApp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            btnCetak = new IconButton();
            btnPengeluaran = new IconButton();
            btnAddMenu = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(31, 30, 68);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(31, 30, 68);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.ImeMode = ImeMode.NoControl;
            dataGridView1.Location = new Point(13, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gainsboro;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(888, 466);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(912, 510);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(13, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(608, 29);
            panel3.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.search_20px;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.InitialImage = Properties.Resources.search_20px;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 28);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(37, 5);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Cari transaksi ...";
            textBox1.Size = new Size(568, 18);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.DarkGray;
            label1.Location = new Point(13, 1);
            label1.Name = "label1";
            label1.Size = new Size(1573, 1);
            label1.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btnCetak);
            panel1.Controls.Add(btnPengeluaran);
            panel1.Controls.Add(btnAddMenu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(912, 70);
            panel1.TabIndex = 6;
            // 
            // btnCetak
            // 
            btnCetak.BackColor = Color.FromArgb(31, 30, 68);
            btnCetak.FlatStyle = FlatStyle.Flat;
            btnCetak.ForeColor = Color.White;
            btnCetak.IconChar = IconChar.Receipt;
            btnCetak.IconColor = Color.White;
            btnCetak.IconFont = IconFont.Auto;
            btnCetak.IconSize = 20;
            btnCetak.Location = new Point(13, 19);
            btnCetak.Name = "btnCetak";
            btnCetak.Size = new Size(167, 34);
            btnCetak.TabIndex = 16;
            btnCetak.Text = "Cetak Laporan Shift";
            btnCetak.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCetak.UseVisualStyleBackColor = false;
            btnCetak.Visible = false;
            btnCetak.Click += btnReportShift_Click;
            // 
            // btnPengeluaran
            // 
            btnPengeluaran.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPengeluaran.BackColor = Color.DarkRed;
            btnPengeluaran.FlatStyle = FlatStyle.Flat;
            btnPengeluaran.ForeColor = Color.White;
            btnPengeluaran.IconChar = IconChar.CashRegister;
            btnPengeluaran.IconColor = Color.White;
            btnPengeluaran.IconFont = IconFont.Auto;
            btnPengeluaran.IconSize = 25;
            btnPengeluaran.Location = new Point(774, 19);
            btnPengeluaran.Name = "btnPengeluaran";
            btnPengeluaran.Size = new Size(127, 34);
            btnPengeluaran.TabIndex = 15;
            btnPengeluaran.Text = "Pengeluaran";
            btnPengeluaran.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPengeluaran.UseVisualStyleBackColor = false;
            btnPengeluaran.Visible = false;
            btnPengeluaran.Click += btnNotifikasiPengeluaran_Click;
            // 
            // btnAddMenu
            // 
            btnAddMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddMenu.AutoSize = true;
            btnAddMenu.BackColor = Color.FromArgb(31, 30, 68);
            btnAddMenu.FlatAppearance.BorderSize = 0;
            btnAddMenu.FlatStyle = FlatStyle.Flat;
            btnAddMenu.ForeColor = Color.White;
            btnAddMenu.Location = new Point(1447, 23);
            btnAddMenu.Name = "btnAddMenu";
            btnAddMenu.Size = new Size(148, 29);
            btnAddMenu.TabIndex = 11;
            btnAddMenu.Text = "Tambah Menu";
            btnAddMenu.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2000;
            // 
            // successTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "successTransaction";
            Size = new Size(912, 580);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button btnAddMenu;
        private System.Windows.Forms.Timer timer1;
        private IconButton btnPengeluaran;
        private IconButton btnCetak;
    }
}