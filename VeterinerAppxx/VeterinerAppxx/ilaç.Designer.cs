
namespace VeterinerAppxx
{
    partial class ilaç
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonekleilaç = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ilaçIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilaçAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilaçTürüDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilaçlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veterinersonDataSet = new VeterinerAppxx.veterinersonDataSet();
            this.İlaçlarTableAdapter = new VeterinerAppxx.veterinersonDataSetTableAdapters.İlaçlarTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxilaçad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxilaçtür = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxmiktar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxfiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilaçlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinersonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.buttonekleilaç);
            this.panel2.Location = new System.Drawing.Point(703, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 223);
            this.panel2.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(63, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "Temizle";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "İlaç Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "İlaç Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonekleilaç
            // 
            this.buttonekleilaç.Location = new System.Drawing.Point(63, 20);
            this.buttonekleilaç.Name = "buttonekleilaç";
            this.buttonekleilaç.Size = new System.Drawing.Size(124, 35);
            this.buttonekleilaç.TabIndex = 1;
            this.buttonekleilaç.Text = "İlaç Ekle";
            this.buttonekleilaç.UseVisualStyleBackColor = true;
            this.buttonekleilaç.Click += new System.EventHandler(this.buttonekleilaç_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ilaçIDDataGridViewTextBoxColumn,
            this.ilaçAdıDataGridViewTextBoxColumn,
            this.ilaçTürüDataGridViewTextBoxColumn,
            this.miktarDataGridViewTextBoxColumn,
            this.birimFiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ilaçlarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(242, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ilaçIDDataGridViewTextBoxColumn
            // 
            this.ilaçIDDataGridViewTextBoxColumn.DataPropertyName = "İlaçID";
            this.ilaçIDDataGridViewTextBoxColumn.HeaderText = "İlaçID";
            this.ilaçIDDataGridViewTextBoxColumn.Name = "ilaçIDDataGridViewTextBoxColumn";
            // 
            // ilaçAdıDataGridViewTextBoxColumn
            // 
            this.ilaçAdıDataGridViewTextBoxColumn.DataPropertyName = "İlaçAdı";
            this.ilaçAdıDataGridViewTextBoxColumn.HeaderText = "İlaçAdı";
            this.ilaçAdıDataGridViewTextBoxColumn.Name = "ilaçAdıDataGridViewTextBoxColumn";
            // 
            // ilaçTürüDataGridViewTextBoxColumn
            // 
            this.ilaçTürüDataGridViewTextBoxColumn.DataPropertyName = "İlaçTürü";
            this.ilaçTürüDataGridViewTextBoxColumn.HeaderText = "İlaçTürü";
            this.ilaçTürüDataGridViewTextBoxColumn.Name = "ilaçTürüDataGridViewTextBoxColumn";
            // 
            // miktarDataGridViewTextBoxColumn
            // 
            this.miktarDataGridViewTextBoxColumn.DataPropertyName = "Miktar";
            this.miktarDataGridViewTextBoxColumn.HeaderText = "Miktar";
            this.miktarDataGridViewTextBoxColumn.Name = "miktarDataGridViewTextBoxColumn";
            // 
            // birimFiyatDataGridViewTextBoxColumn
            // 
            this.birimFiyatDataGridViewTextBoxColumn.DataPropertyName = "BirimFiyat";
            this.birimFiyatDataGridViewTextBoxColumn.HeaderText = "BirimFiyat";
            this.birimFiyatDataGridViewTextBoxColumn.Name = "birimFiyatDataGridViewTextBoxColumn";
            // 
            // ilaçlarBindingSource
            // 
            this.ilaçlarBindingSource.DataMember = "İlaçlar";
            this.ilaçlarBindingSource.DataSource = this.veterinersonDataSet;
            // 
            // veterinersonDataSet
            // 
            this.veterinersonDataSet.DataSetName = "veterinersonDataSet";
            this.veterinersonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // İlaçlarTableAdapter
            // 
            this.İlaçlarTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(790, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ayarlar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "ilaç Adı";
            // 
            // textBoxilaçad
            // 
            this.textBoxilaçad.Location = new System.Drawing.Point(347, 89);
            this.textBoxilaçad.Name = "textBoxilaçad";
            this.textBoxilaçad.Size = new System.Drawing.Size(149, 20);
            this.textBoxilaçad.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "İlaç Türü";
            // 
            // textBoxilaçtür
            // 
            this.textBoxilaçtür.Location = new System.Drawing.Point(347, 115);
            this.textBoxilaçtür.Name = "textBoxilaçtür";
            this.textBoxilaçtür.Size = new System.Drawing.Size(149, 20);
            this.textBoxilaçtür.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Miktar";
            // 
            // textBoxmiktar
            // 
            this.textBoxmiktar.Location = new System.Drawing.Point(347, 141);
            this.textBoxmiktar.Name = "textBoxmiktar";
            this.textBoxmiktar.Size = new System.Drawing.Size(149, 20);
            this.textBoxmiktar.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Birim Fiyat";
            // 
            // textBoxfiyat
            // 
            this.textBoxfiyat.Location = new System.Drawing.Point(347, 167);
            this.textBoxfiyat.Name = "textBoxfiyat";
            this.textBoxfiyat.Size = new System.Drawing.Size(149, 20);
            this.textBoxfiyat.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "İlac Id";
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(347, 63);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(149, 20);
            this.textBoxid.TabIndex = 26;
            // 
            // ilaç
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 471);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxfiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxmiktar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxilaçtür);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxilaçad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Name = "ilaç";
            this.Text = "ilaç";
            this.Load += new System.EventHandler(this.ilaç_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilaçlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinersonDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonekleilaç;
        private System.Windows.Forms.DataGridView dataGridView1;
        private veterinersonDataSet veterinersonDataSet;
        private System.Windows.Forms.BindingSource ilaçlarBindingSource;
        private veterinersonDataSetTableAdapters.İlaçlarTableAdapter İlaçlarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilaçIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilaçAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilaçTürüDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxilaçad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxilaçtür;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxmiktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxfiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxid;
    }
}