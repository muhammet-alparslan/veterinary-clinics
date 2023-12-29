
namespace VeterinerAppxx
{
    partial class HAYVAN
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
            this.buttoneklehayvan = new System.Windows.Forms.Button();
            this.textBoxhayvanismi = new System.Windows.Forms.TextBox();
            this.textBoxhayvantür = new System.Windows.Forms.TextBox();
            this.textBoxhayvanırkı = new System.Windows.Forms.TextBox();
            this.comboBoxhayvansiniyet = new System.Windows.Forms.ComboBox();
            this.dateTimePickerhayvantime = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hayvanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.türüDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ırkıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doğumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sahipIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hayvanlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veterinersonDataSetx = new VeterinerAppxx.veterinersonDataSetx();
            this.hayvanlarTableAdapter = new VeterinerAppxx.veterinersonDataSetxTableAdapters.HayvanlarTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvanlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinersonDataSetx)).BeginInit();
            this.SuspendLayout();
            // 
            // buttoneklehayvan
            // 
            this.buttoneklehayvan.Location = new System.Drawing.Point(63, 20);
            this.buttoneklehayvan.Name = "buttoneklehayvan";
            this.buttoneklehayvan.Size = new System.Drawing.Size(124, 35);
            this.buttoneklehayvan.TabIndex = 1;
            this.buttoneklehayvan.Text = "Hayvanı Ekle";
            this.buttoneklehayvan.UseVisualStyleBackColor = true;
            this.buttoneklehayvan.Click += new System.EventHandler(this.buttoneklehayvan_Click);
            // 
            // textBoxhayvanismi
            // 
            this.textBoxhayvanismi.Location = new System.Drawing.Point(173, 90);
            this.textBoxhayvanismi.Name = "textBoxhayvanismi";
            this.textBoxhayvanismi.Size = new System.Drawing.Size(149, 20);
            this.textBoxhayvanismi.TabIndex = 2;
            // 
            // textBoxhayvantür
            // 
            this.textBoxhayvantür.Location = new System.Drawing.Point(526, 90);
            this.textBoxhayvantür.Name = "textBoxhayvantür";
            this.textBoxhayvantür.Size = new System.Drawing.Size(149, 20);
            this.textBoxhayvantür.TabIndex = 3;
            // 
            // textBoxhayvanırkı
            // 
            this.textBoxhayvanırkı.Location = new System.Drawing.Point(173, 150);
            this.textBoxhayvanırkı.Name = "textBoxhayvanırkı";
            this.textBoxhayvanırkı.Size = new System.Drawing.Size(149, 20);
            this.textBoxhayvanırkı.TabIndex = 4;
            // 
            // comboBoxhayvansiniyet
            // 
            this.comboBoxhayvansiniyet.FormattingEnabled = true;
            this.comboBoxhayvansiniyet.Items.AddRange(new object[] {
            "Diş",
            "Dişi"});
            this.comboBoxhayvansiniyet.Location = new System.Drawing.Point(526, 149);
            this.comboBoxhayvansiniyet.Name = "comboBoxhayvansiniyet";
            this.comboBoxhayvansiniyet.Size = new System.Drawing.Size(149, 21);
            this.comboBoxhayvansiniyet.TabIndex = 5;
            // 
            // dateTimePickerhayvantime
            // 
            this.dateTimePickerhayvantime.Location = new System.Drawing.Point(320, 218);
            this.dateTimePickerhayvantime.Name = "dateTimePickerhayvantime";
            this.dateTimePickerhayvantime.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerhayvantime.TabIndex = 6;
            this.dateTimePickerhayvantime.Value = new System.DateTime(2023, 12, 27, 0, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dateTimePickerhayvantime);
            this.panel1.Controls.Add(this.textBoxhayvanismi);
            this.panel1.Controls.Add(this.comboBoxhayvansiniyet);
            this.panel1.Controls.Add(this.textBoxhayvantür);
            this.panel1.Controls.Add(this.textBoxhayvanırkı);
            this.panel1.Location = new System.Drawing.Point(28, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 360);
            this.panel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hayvan Id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(376, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hayvan Irkı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hayvan Tür";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hayvan Cinsiyet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hayvan İsmi";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.buttoneklehayvan);
            this.panel2.Location = new System.Drawing.Point(978, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 223);
            this.panel2.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(63, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "Temizle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Hayvanı Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hayvanı Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hayvanIDDataGridViewTextBoxColumn,
            this.adıDataGridViewTextBoxColumn,
            this.türüDataGridViewTextBoxColumn,
            this.ırkıDataGridViewTextBoxColumn,
            this.cinsiyetiDataGridViewTextBoxColumn,
            this.doğumTarihiDataGridViewTextBoxColumn,
            this.sahipIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hayvanlarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(353, 413);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 159);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            // 
            // hayvanIDDataGridViewTextBoxColumn
            // 
            this.hayvanIDDataGridViewTextBoxColumn.DataPropertyName = "HayvanID";
            this.hayvanIDDataGridViewTextBoxColumn.HeaderText = "HayvanID";
            this.hayvanIDDataGridViewTextBoxColumn.Name = "hayvanIDDataGridViewTextBoxColumn";
            this.hayvanIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adıDataGridViewTextBoxColumn
            // 
            this.adıDataGridViewTextBoxColumn.DataPropertyName = "Adı";
            this.adıDataGridViewTextBoxColumn.HeaderText = "Adı";
            this.adıDataGridViewTextBoxColumn.Name = "adıDataGridViewTextBoxColumn";
            // 
            // türüDataGridViewTextBoxColumn
            // 
            this.türüDataGridViewTextBoxColumn.DataPropertyName = "Türü";
            this.türüDataGridViewTextBoxColumn.HeaderText = "Türü";
            this.türüDataGridViewTextBoxColumn.Name = "türüDataGridViewTextBoxColumn";
            // 
            // ırkıDataGridViewTextBoxColumn
            // 
            this.ırkıDataGridViewTextBoxColumn.DataPropertyName = "Irkı";
            this.ırkıDataGridViewTextBoxColumn.HeaderText = "Irkı";
            this.ırkıDataGridViewTextBoxColumn.Name = "ırkıDataGridViewTextBoxColumn";
            // 
            // cinsiyetiDataGridViewTextBoxColumn
            // 
            this.cinsiyetiDataGridViewTextBoxColumn.DataPropertyName = "Cinsiyeti";
            this.cinsiyetiDataGridViewTextBoxColumn.HeaderText = "Cinsiyeti";
            this.cinsiyetiDataGridViewTextBoxColumn.Name = "cinsiyetiDataGridViewTextBoxColumn";
            // 
            // doğumTarihiDataGridViewTextBoxColumn
            // 
            this.doğumTarihiDataGridViewTextBoxColumn.DataPropertyName = "DoğumTarihi";
            this.doğumTarihiDataGridViewTextBoxColumn.HeaderText = "DoğumTarihi";
            this.doğumTarihiDataGridViewTextBoxColumn.Name = "doğumTarihiDataGridViewTextBoxColumn";
            // 
            // sahipIDDataGridViewTextBoxColumn
            // 
            this.sahipIDDataGridViewTextBoxColumn.DataPropertyName = "SahipID";
            this.sahipIDDataGridViewTextBoxColumn.HeaderText = "SahipID";
            this.sahipIDDataGridViewTextBoxColumn.Name = "sahipIDDataGridViewTextBoxColumn";
            // 
            // hayvanlarBindingSource
            // 
            this.hayvanlarBindingSource.DataMember = "Hayvanlar";
            this.hayvanlarBindingSource.DataSource = this.veterinersonDataSetx;
            // 
            // veterinersonDataSetx
            // 
            this.veterinersonDataSetx.DataSetName = "veterinersonDataSetx";
            this.veterinersonDataSetx.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hayvanlarTableAdapter
            // 
            this.hayvanlarTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(859, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(1054, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ayarlar";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // HAYVAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 584);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "HAYVAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HAYVAN";
            this.Load += new System.EventHandler(this.HAYVAN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvanlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinersonDataSetx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttoneklehayvan;
        private System.Windows.Forms.TextBox textBoxhayvanismi;
        private System.Windows.Forms.TextBox textBoxhayvantür;
        private System.Windows.Forms.TextBox textBoxhayvanırkı;
        private System.Windows.Forms.ComboBox comboBoxhayvansiniyet;
        private System.Windows.Forms.DateTimePicker dateTimePickerhayvantime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private veterinersonDataSetx veterinersonDataSetx;
        private System.Windows.Forms.BindingSource hayvanlarBindingSource;
        private veterinersonDataSetxTableAdapters.HayvanlarTableAdapter hayvanlarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hayvanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn türüDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ırkıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doğumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sahipIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}