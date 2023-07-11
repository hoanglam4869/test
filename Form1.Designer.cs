namespace thuvien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnadd = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnclo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtmuon = new System.Windows.Forms.TextBox();
            this.txtloai = new System.Windows.Forms.TextBox();
            this.txtso = new System.Windows.Forms.TextBox();
            this.btnfind = new System.Windows.Forms.Button();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.dataGridThu = new System.Windows.Forms.DataGridView();
            this.tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridThu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(357, 11);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnup
            // 
            this.btnup.Location = new System.Drawing.Point(357, 39);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(75, 23);
            this.btnup.TabIndex = 1;
            this.btnup.Text = "Update";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(357, 68);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 2;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnclo
            // 
            this.btnclo.Location = new System.Drawing.Point(357, 97);
            this.btnclo.Name = "btnclo";
            this.btnclo.Size = new System.Drawing.Size(75, 23);
            this.btnclo.TabIndex = 3;
            this.btnclo.Text = "Close";
            this.btnclo.UseVisualStyleBackColor = true;
            this.btnclo.Click += new System.EventHandler(this.btnclo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Người mượn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thể loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số trang";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(100, 11);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(251, 23);
            this.txtten.TabIndex = 8;
            // 
            // txtmuon
            // 
            this.txtmuon.Location = new System.Drawing.Point(100, 40);
            this.txtmuon.Name = "txtmuon";
            this.txtmuon.Size = new System.Drawing.Size(251, 23);
            this.txtmuon.TabIndex = 9;
            // 
            // txtloai
            // 
            this.txtloai.Location = new System.Drawing.Point(100, 69);
            this.txtloai.Name = "txtloai";
            this.txtloai.Size = new System.Drawing.Size(135, 23);
            this.txtloai.TabIndex = 10;
            // 
            // txtso
            // 
            this.txtso.Location = new System.Drawing.Point(100, 98);
            this.txtso.Name = "txtso";
            this.txtso.Size = new System.Drawing.Size(67, 23);
            this.txtso.TabIndex = 11;
            this.txtso.TextChanged += new System.EventHandler(this.txtso_TextChanged);
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(22, 137);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(75, 23);
            this.btnfind.TabIndex = 12;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = true;
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(100, 138);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(251, 23);
            this.txtfind.TabIndex = 13;
            this.txtfind.TextChanged += new System.EventHandler(this.txtfind_TextChanged);
            // 
            // dataGridThu
            // 
            this.dataGridThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tensach,
            this.muon,
            this.loai,
            this.so});
            this.dataGridThu.Location = new System.Drawing.Point(-1, 196);
            this.dataGridThu.Name = "dataGridThu";
            this.dataGridThu.RowTemplate.Height = 25;
            this.dataGridThu.Size = new System.Drawing.Size(556, 267);
            this.dataGridThu.TabIndex = 14;
            this.dataGridThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridThu_CellClick);
            // 
            // tensach
            // 
            this.tensach.DataPropertyName = "Ten";
            this.tensach.HeaderText = "Tên sách";
            this.tensach.Name = "tensach";
            // 
            // muon
            // 
            this.muon.DataPropertyName = "Muon";
            this.muon.HeaderText = "Người mượn";
            this.muon.Name = "muon";
            // 
            // loai
            // 
            this.loai.DataPropertyName = "Loai";
            this.loai.HeaderText = "Thể loại";
            this.loai.Name = "loai";
            // 
            // so
            // 
            this.so.DataPropertyName = "So";
            this.so.HeaderText = "Số trang";
            this.so.Name = "so";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.dataGridThu);
            this.Controls.Add(this.txtfind);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.txtso);
            this.Controls.Add(this.txtloai);
            this.Controls.Add(this.txtmuon);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclo);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.btnadd);
            this.Name = "Form1";
            this.Text = "Thư viện";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnadd;
        private Button btnup;
        private Button btndel;
        private Button btnclo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtten;
        private TextBox txtmuon;
        private TextBox txtloai;
        private TextBox txtso;
        private Button btnfind;
        private TextBox txtfind;
        private DataGridView dataGridThu;
        private DataGridViewTextBoxColumn tensach;
        private DataGridViewTextBoxColumn muon;
        private DataGridViewTextBoxColumn loai;
        private DataGridViewTextBoxColumn so;
    }
}