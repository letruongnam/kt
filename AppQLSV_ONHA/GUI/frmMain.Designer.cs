namespace AppQLSV_ONHA
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.BtnXoaLop = new System.Windows.Forms.ToolStripButton();
            this.btnSuaLop = new System.Windows.Forms.ToolStripButton();
            this.BtnThemLop = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnXoaSinhVien = new System.Windows.Forms.ToolStripButton();
            this.btnSuaSinhVien = new System.Windows.Forms.ToolStripButton();
            this.btnThemSinhVien = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.GridSinhVien = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BDSLopHoc = new System.Windows.Forms.BindingSource(this.components);
            this.BDSSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSinhVien)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BDSLopHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 424);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Room,
            this.Column1});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(793, 397);
            this.dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "TotalStudent";
            this.Column9.HeaderText = "Tổng SV";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 70;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "TongNam";
            this.Column10.HeaderText = "Tổng Nam";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 70;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "TongNu";
            this.Column11.HeaderText = "Tổng nữ";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 70;
            // 
            // Room
            // 
            this.Room.DataPropertyName = "Room";
            this.Room.HeaderText = "Room";
            this.Room.MinimumWidth = 6;
            this.Room.Name = "Room";
            this.Room.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Tên Lớp";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.BtnXoaLop,
            this.btnSuaLop,
            this.BtnThemLop});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(793, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(126, 28);
            this.toolStripLabel1.Text = "Thông tin lớp học";
            // 
            // BtnXoaLop
            // 
            this.BtnXoaLop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnXoaLop.Image = ((System.Drawing.Image)(resources.GetObject("BtnXoaLop.Image")));
            this.BtnXoaLop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnXoaLop.Name = "BtnXoaLop";
            this.BtnXoaLop.Size = new System.Drawing.Size(59, 24);
            this.BtnXoaLop.Text = "Xóa";
            this.BtnXoaLop.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSuaLop.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaLop.Image")));
            this.btnSuaLop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Size = new System.Drawing.Size(58, 28);
            this.btnSuaLop.Text = "Sửa";
            this.btnSuaLop.Click += new System.EventHandler(this.btnSuaLop_Click);
            // 
            // BtnThemLop
            // 
            this.BtnThemLop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnThemLop.Image = ((System.Drawing.Image)(resources.GetObject("BtnThemLop.Image")));
            this.BtnThemLop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnThemLop.Name = "BtnThemLop";
            this.BtnThemLop.Size = new System.Drawing.Size(70, 28);
            this.BtnThemLop.Text = "Thêm";
            this.BtnThemLop.Click += new System.EventHandler(this.BtnThemLop_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.btnXoaSinhVien,
            this.btnSuaSinhVien,
            this.btnThemSinhVien,
            this.toolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(538, 27);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(133, 28);
            this.toolStripLabel2.Text = "Thông tin sinh viên";
            // 
            // btnXoaSinhVien
            // 
            this.btnXoaSinhVien.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXoaSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaSinhVien.Image")));
            this.btnXoaSinhVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaSinhVien.Name = "btnXoaSinhVien";
            this.btnXoaSinhVien.Size = new System.Drawing.Size(59, 28);
            this.btnXoaSinhVien.Text = "Xóa";
            this.btnXoaSinhVien.Click += new System.EventHandler(this.btnXoaSinhVien_Click);
            // 
            // btnSuaSinhVien
            // 
            this.btnSuaSinhVien.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSuaSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaSinhVien.Image")));
            this.btnSuaSinhVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuaSinhVien.Name = "btnSuaSinhVien";
            this.btnSuaSinhVien.Size = new System.Drawing.Size(58, 28);
            this.btnSuaSinhVien.Text = "Sửa";
            this.btnSuaSinhVien.Click += new System.EventHandler(this.btnSuaSinhVien_Click);
            // 
            // btnThemSinhVien
            // 
            this.btnThemSinhVien.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnThemSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSinhVien.Image")));
            this.btnThemSinhVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemSinhVien.Name = "btnThemSinhVien";
            this.btnThemSinhVien.Size = new System.Drawing.Size(70, 28);
            this.btnThemSinhVien.Text = "Thêm";
            this.btnThemSinhVien.Click += new System.EventHandler(this.btnThemSinhVien_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(113, 28);
            this.toolStripButton1.Text = "Thêm từ file";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // GridSinhVien
            // 
            this.GridSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.GridSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridSinhVien.Location = new System.Drawing.Point(0, 27);
            this.GridSinhVien.Name = "GridSinhVien";
            this.GridSinhVien.RowHeadersWidth = 51;
            this.GridSinhVien.RowTemplate.Height = 24;
            this.GridSinhVien.Size = new System.Drawing.Size(538, 397);
            this.GridSinhVien.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ID";
            this.Column2.HeaderText = "ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FirstName";
            this.Column3.HeaderText = "FirstName";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "LastName";
            this.Column4.HeaderText = "LastName";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DateOfBirth";
            this.Column5.HeaderText = "DateOfBirth";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "PlaceOfBirth";
            this.Column6.HeaderText = "PlaceOfBirth";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Gender";
            this.Column7.HeaderText = "Gender";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 50;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "IDClassroom";
            this.Column8.HeaderText = "IDClassRoom";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GridSinhVien);
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(793, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 424);
            this.panel2.TabIndex = 1;
            // 
            // BDSLopHoc
            // 
            this.BDSLopHoc.CurrentChanged += new System.EventHandler(this.BDSLopHoc_CurrentChanged);
            // 
            // BDSSinhVien
            // 
            this.BDSSinhVien.CurrentChanged += new System.EventHandler(this.BDSSinhVien_CurrentChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(793, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 424);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 424);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSinhVien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BDSLopHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton BtnThemLop;
        private System.Windows.Forms.ToolStripButton btnSuaLop;
        private System.Windows.Forms.ToolStripButton BtnXoaLop;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnThemSinhVien;
        private System.Windows.Forms.ToolStripButton btnSuaSinhVien;
        private System.Windows.Forms.ToolStripButton btnXoaSinhVien;
        private System.Windows.Forms.DataGridView GridSinhVien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource BDSLopHoc;
        private System.Windows.Forms.BindingSource BDSSinhVien;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

