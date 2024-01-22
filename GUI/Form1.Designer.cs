namespace QLDA
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtmada = new System.Windows.Forms.TextBox();
			this.txttenda = new System.Windows.Forms.TextBox();
			this.txtsotien = new System.Windows.Forms.TextBox();
			this.cbdonvi = new System.Windows.Forms.ComboBox();
			this.dtpngaybd = new System.Windows.Forms.DateTimePicker();
			this.dtpthoigian = new System.Windows.Forms.DateTimePicker();
			this.txtchiphi = new System.Windows.Forms.TextBox();
			this.txttrangthai = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnadd = new System.Windows.Forms.Button();
			this.btnupdate = new System.Windows.Forms.Button();
			this.btndelete = new System.Windows.Forms.Button();
			this.btn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(59, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã Dự Án";
			// 
			// txtmada
			// 
			this.txtmada.Location = new System.Drawing.Point(166, 56);
			this.txtmada.Name = "txtmada";
			this.txtmada.Size = new System.Drawing.Size(100, 22);
			this.txtmada.TabIndex = 1;
			// 
			// txttenda
			// 
			this.txttenda.Location = new System.Drawing.Point(166, 99);
			this.txttenda.Name = "txttenda";
			this.txttenda.Size = new System.Drawing.Size(100, 22);
			this.txttenda.TabIndex = 2;
			// 
			// txtsotien
			// 
			this.txtsotien.Location = new System.Drawing.Point(166, 145);
			this.txtsotien.Name = "txtsotien";
			this.txtsotien.Size = new System.Drawing.Size(100, 22);
			this.txtsotien.TabIndex = 3;
			// 
			// cbdonvi
			// 
			this.cbdonvi.FormattingEnabled = true;
			this.cbdonvi.Location = new System.Drawing.Point(414, 53);
			this.cbdonvi.Name = "cbdonvi";
			this.cbdonvi.Size = new System.Drawing.Size(121, 24);
			this.cbdonvi.TabIndex = 4;
			// 
			// dtpngaybd
			// 
			this.dtpngaybd.CustomFormat = "yyyy/MM/dd";
			this.dtpngaybd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpngaybd.Location = new System.Drawing.Point(414, 103);
			this.dtpngaybd.Name = "dtpngaybd";
			this.dtpngaybd.Size = new System.Drawing.Size(200, 22);
			this.dtpngaybd.TabIndex = 5;
			this.dtpngaybd.Value = new System.DateTime(2024, 1, 14, 0, 0, 0, 0);
			this.dtpngaybd.ValueChanged += new System.EventHandler(this.dtpngaybd_ValueChanged);
			// 
			// dtpthoigian
			// 
			this.dtpthoigian.CustomFormat = "yyyy/MM/dd";
			this.dtpthoigian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpthoigian.Location = new System.Drawing.Point(414, 151);
			this.dtpthoigian.Name = "dtpthoigian";
			this.dtpthoigian.Size = new System.Drawing.Size(200, 22);
			this.dtpthoigian.TabIndex = 6;
			this.dtpthoigian.Value = new System.DateTime(2024, 1, 14, 0, 0, 0, 0);
			// 
			// txtchiphi
			// 
			this.txtchiphi.Location = new System.Drawing.Point(166, 198);
			this.txtchiphi.Name = "txtchiphi";
			this.txtchiphi.Size = new System.Drawing.Size(100, 22);
			this.txtchiphi.TabIndex = 7;
			// 
			// txttrangthai
			// 
			this.txttrangthai.Location = new System.Drawing.Point(414, 204);
			this.txttrangthai.Name = "txttrangthai";
			this.txttrangthai.Size = new System.Drawing.Size(100, 22);
			this.txttrangthai.TabIndex = 8;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
			this.dataGridView1.Location = new System.Drawing.Point(65, 304);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1116, 360);
			this.dataGridView1.TabIndex = 10;
			this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
			// 
			// btnadd
			// 
			this.btnadd.Location = new System.Drawing.Point(964, 65);
			this.btnadd.Name = "btnadd";
			this.btnadd.Size = new System.Drawing.Size(75, 56);
			this.btnadd.TabIndex = 11;
			this.btnadd.Text = "ADD";
			this.btnadd.UseVisualStyleBackColor = true;
			this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
			// 
			// btnupdate
			// 
			this.btnupdate.Location = new System.Drawing.Point(964, 128);
			this.btnupdate.Name = "btnupdate";
			this.btnupdate.Size = new System.Drawing.Size(85, 56);
			this.btnupdate.TabIndex = 12;
			this.btnupdate.Text = "UPDATE";
			this.btnupdate.UseVisualStyleBackColor = true;
			this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
			// 
			// btndelete
			// 
			this.btndelete.Location = new System.Drawing.Point(1090, 131);
			this.btndelete.Name = "btndelete";
			this.btndelete.Size = new System.Drawing.Size(88, 56);
			this.btndelete.TabIndex = 13;
			this.btndelete.Text = "DELETE";
			this.btndelete.UseVisualStyleBackColor = true;
			this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
			// 
			// btn
			// 
			this.btn.Location = new System.Drawing.Point(1095, 67);
			this.btn.Name = "btn";
			this.btn.Size = new System.Drawing.Size(83, 54);
			this.btn.TabIndex = 14;
			this.btn.Text = "PRINT";
			this.btn.UseVisualStyleBackColor = true;
			this.btn.Click += new System.EventHandler(this.btn_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(62, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 16);
			this.label2.TabIndex = 15;
			this.label2.Text = "Tên Dự Án";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(62, 151);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 16);
			this.label3.TabIndex = 16;
			this.label3.Text = "Số tiền";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(350, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 16);
			this.label4.TabIndex = 17;
			this.label4.Text = "Đơn Vị";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(335, 109);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 16);
			this.label5.TabIndex = 18;
			this.label5.Text = "Ngày BĐ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(335, 151);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 16);
			this.label6.TabIndex = 19;
			this.label6.Text = "Thời gian";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(62, 204);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 16);
			this.label7.TabIndex = 20;
			this.label7.Text = "Chi Phí";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(325, 198);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(73, 16);
			this.label8.TabIndex = 21;
			this.label8.Text = "Trạng Thái";
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "MaDA";
			this.Column1.HeaderText = "Mã Dự Án";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "TenDA";
			this.Column2.HeaderText = "Tên Dự Án";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.Width = 125;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "NgayBD";
			this.Column3.HeaderText = "Ngày BĐ";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.Width = 125;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "ThoiGian";
			this.Column4.HeaderText = "Thời Gian";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.Width = 125;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "DonVi_Ptrach";
			this.Column5.HeaderText = "Đơn vị";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.Width = 125;
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "SoTien";
			this.Column6.HeaderText = "Số Tiền";
			this.Column6.MinimumWidth = 6;
			this.Column6.Name = "Column6";
			this.Column6.Width = 125;
			// 
			// Column7
			// 
			this.Column7.DataPropertyName = "ChiPhi";
			this.Column7.HeaderText = "Chi Phí";
			this.Column7.MinimumWidth = 6;
			this.Column7.Name = "Column7";
			this.Column7.Width = 125;
			// 
			// Column8
			// 
			this.Column8.DataPropertyName = "TrangThai";
			this.Column8.HeaderText = "Trạng Thái";
			this.Column8.MinimumWidth = 6;
			this.Column8.Name = "Column8";
			this.Column8.Width = 125;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1318, 714);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn);
			this.Controls.Add(this.btndelete);
			this.Controls.Add(this.btnupdate);
			this.Controls.Add(this.btnadd);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txttrangthai);
			this.Controls.Add(this.txtchiphi);
			this.Controls.Add(this.dtpthoigian);
			this.Controls.Add(this.dtpngaybd);
			this.Controls.Add(this.cbdonvi);
			this.Controls.Add(this.txtsotien);
			this.Controls.Add(this.txttenda);
			this.Controls.Add(this.txtmada);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtmada;
		private System.Windows.Forms.TextBox txttenda;
		private System.Windows.Forms.TextBox txtsotien;
		private System.Windows.Forms.ComboBox cbdonvi;
		private System.Windows.Forms.DateTimePicker dtpngaybd;
		private System.Windows.Forms.DateTimePicker dtpthoigian;
		private System.Windows.Forms.TextBox txtchiphi;
		private System.Windows.Forms.TextBox txttrangthai;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnadd;
		private System.Windows.Forms.Button btnupdate;
		private System.Windows.Forms.Button btndelete;
		private System.Windows.Forms.Button btn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
	}
}

