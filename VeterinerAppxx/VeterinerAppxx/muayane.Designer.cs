
namespace VeterinerAppxx
{
    partial class muayane
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
            this.comboBoxHayvanId = new System.Windows.Forms.ComboBox();
            this.comboBoxVeteriner = new System.Windows.Forms.ComboBox();
            this.textBoxteşhis = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttontemizle = new System.Windows.Forms.Button();
            this.buttonmuayenegüncelle = new System.Windows.Forms.Button();
            this.buttonmuayenesil = new System.Windows.Forms.Button();
            this.buttonekleMuayene = new System.Windows.Forms.Button();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.veterinersonDataSet1 = new VeterinerAppxx.veterinersonDataSet1();
            this.muayeneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.muayeneTableAdapter = new VeterinerAppxx.veterinersonDataSet1TableAdapters.MuayeneTableAdapter();
            this.muayeneIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hayvanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veterinerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muayeneTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teşhisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tedaviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinersonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muayeneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxHayvanId
            // 
            this.comboBoxHayvanId.FormattingEnabled = true;
            this.comboBoxHayvanId.Location = new System.Drawing.Point(410, 78);
            this.comboBoxHayvanId.Name = "comboBoxHayvanId";
            this.comboBoxHayvanId.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHayvanId.TabIndex = 0;
            // 
            // comboBoxVeteriner
            // 
            this.comboBoxVeteriner.FormattingEnabled = true;
            this.comboBoxVeteriner.Location = new System.Drawing.Point(410, 105);
            this.comboBoxVeteriner.Name = "comboBoxVeteriner";
            this.comboBoxVeteriner.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVeteriner.TabIndex = 1;
            // 
            // textBoxteşhis
            // 
            this.textBoxteşhis.Location = new System.Drawing.Point(410, 133);
            this.textBoxteşhis.Name = "textBoxteşhis";
            this.textBoxteşhis.Size = new System.Drawing.Size(121, 20);
            this.textBoxteşhis.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(410, 159);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(410, 186);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2023, 12, 28, 0, 0, 0, 0);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(736, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 147);
            this.listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(736, 192);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(208, 147);
            this.listBox2.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.buttontemizle);
            this.panel2.Controls.Add(this.buttonmuayenegüncelle);
            this.panel2.Controls.Add(this.buttonmuayenesil);
            this.panel2.Controls.Add(this.buttonekleMuayene);
            this.panel2.Location = new System.Drawing.Point(12, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 223);
            this.panel2.TabIndex = 10;
            // 
            // buttontemizle
            // 
            this.buttontemizle.Location = new System.Drawing.Point(63, 143);
            this.buttontemizle.Name = "buttontemizle";
            this.buttontemizle.Size = new System.Drawing.Size(124, 35);
            this.buttontemizle.TabIndex = 4;
            this.buttontemizle.Text = "Temizle";
            this.buttontemizle.UseVisualStyleBackColor = true;
            this.buttontemizle.Click += new System.EventHandler(this.buttontemizle_Click);
            // 
            // buttonmuayenegüncelle
            // 
            this.buttonmuayenegüncelle.Location = new System.Drawing.Point(63, 102);
            this.buttonmuayenegüncelle.Name = "buttonmuayenegüncelle";
            this.buttonmuayenegüncelle.Size = new System.Drawing.Size(124, 35);
            this.buttonmuayenegüncelle.TabIndex = 3;
            this.buttonmuayenegüncelle.Text = "Muayane Güncelle";
            this.buttonmuayenegüncelle.UseVisualStyleBackColor = true;
            this.buttonmuayenegüncelle.Click += new System.EventHandler(this.buttonmuayenegüncelle_Click);
            // 
            // buttonmuayenesil
            // 
            this.buttonmuayenesil.Location = new System.Drawing.Point(63, 61);
            this.buttonmuayenesil.Name = "buttonmuayenesil";
            this.buttonmuayenesil.Size = new System.Drawing.Size(124, 35);
            this.buttonmuayenesil.TabIndex = 2;
            this.buttonmuayenesil.Text = "Muayane Sil";
            this.buttonmuayenesil.UseVisualStyleBackColor = true;
            this.buttonmuayenesil.Click += new System.EventHandler(this.buttonmuayenesil_Click);
            // 
            // buttonekleMuayene
            // 
            this.buttonekleMuayene.Location = new System.Drawing.Point(63, 20);
            this.buttonekleMuayene.Name = "buttonekleMuayene";
            this.buttonekleMuayene.Size = new System.Drawing.Size(124, 35);
            this.buttonekleMuayene.TabIndex = 1;
            this.buttonekleMuayene.Text = "Muayane Ekle";
            this.buttonekleMuayene.UseVisualStyleBackColor = true;
            this.buttonekleMuayene.Click += new System.EventHandler(this.buttonekleMuayene_Click);
            // 
            // textBoxid
            // 
            this.textBoxid.Enabled = false;
            this.textBoxid.Location = new System.Drawing.Point(410, 52);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(121, 20);
            this.textBoxid.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.muayeneIDDataGridViewTextBoxColumn,
            this.hayvanIDDataGridViewTextBoxColumn,
            this.veterinerIDDataGridViewTextBoxColumn,
            this.muayeneTarihiDataGridViewTextBoxColumn,
            this.teşhisDataGridViewTextBoxColumn,
            this.tedaviDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.muayeneBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(187, 354);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 150);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // veterinersonDataSet1
            // 
            this.veterinersonDataSet1.DataSetName = "veterinersonDataSet1";
            this.veterinersonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // muayeneBindingSource
            // 
            this.muayeneBindingSource.DataMember = "Muayene";
            this.muayeneBindingSource.DataSource = this.veterinersonDataSet1;
            // 
            // muayeneTableAdapter
            // 
            this.muayeneTableAdapter.ClearBeforeFill = true;
            // 
            // muayeneIDDataGridViewTextBoxColumn
            // 
            this.muayeneIDDataGridViewTextBoxColumn.DataPropertyName = "MuayeneID";
            this.muayeneIDDataGridViewTextBoxColumn.HeaderText = "MuayeneID";
            this.muayeneIDDataGridViewTextBoxColumn.Name = "muayeneIDDataGridViewTextBoxColumn";
            this.muayeneIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hayvanIDDataGridViewTextBoxColumn
            // 
            this.hayvanIDDataGridViewTextBoxColumn.DataPropertyName = "HayvanID";
            this.hayvanIDDataGridViewTextBoxColumn.HeaderText = "HayvanID";
            this.hayvanIDDataGridViewTextBoxColumn.Name = "hayvanIDDataGridViewTextBoxColumn";
            // 
            // veterinerIDDataGridViewTextBoxColumn
            // 
            this.veterinerIDDataGridViewTextBoxColumn.DataPropertyName = "VeterinerID";
            this.veterinerIDDataGridViewTextBoxColumn.HeaderText = "VeterinerID";
            this.veterinerIDDataGridViewTextBoxColumn.Name = "veterinerIDDataGridViewTextBoxColumn";
            // 
            // muayeneTarihiDataGridViewTextBoxColumn
            // 
            this.muayeneTarihiDataGridViewTextBoxColumn.DataPropertyName = "MuayeneTarihi";
            this.muayeneTarihiDataGridViewTextBoxColumn.HeaderText = "MuayeneTarihi";
            this.muayeneTarihiDataGridViewTextBoxColumn.Name = "muayeneTarihiDataGridViewTextBoxColumn";
            // 
            // teşhisDataGridViewTextBoxColumn
            // 
            this.teşhisDataGridViewTextBoxColumn.DataPropertyName = "Teşhis";
            this.teşhisDataGridViewTextBoxColumn.HeaderText = "Teşhis";
            this.teşhisDataGridViewTextBoxColumn.Name = "teşhisDataGridViewTextBoxColumn";
            // 
            // tedaviDataGridViewTextBoxColumn
            // 
            this.tedaviDataGridViewTextBoxColumn.DataPropertyName = "Tedavi";
            this.tedaviDataGridViewTextBoxColumn.HeaderText = "Tedavi";
            this.tedaviDataGridViewTextBoxColumn.Name = "tedaviDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "label4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "label5";
            // 
            // muayane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 516);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxteşhis);
            this.Controls.Add(this.comboBoxVeteriner);
            this.Controls.Add(this.comboBoxHayvanId);
            this.Name = "muayane";
            this.Text = "muayane";
            this.Load += new System.EventHandler(this.muayane_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinersonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muayeneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxHayvanId;
        private System.Windows.Forms.ComboBox comboBoxVeteriner;
        private System.Windows.Forms.TextBox textBoxteşhis;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttontemizle;
        private System.Windows.Forms.Button buttonmuayenegüncelle;
        private System.Windows.Forms.Button buttonmuayenesil;
        private System.Windows.Forms.Button buttonekleMuayene;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private veterinersonDataSet1 veterinersonDataSet1;
        private System.Windows.Forms.BindingSource muayeneBindingSource;
        private veterinersonDataSet1TableAdapters.MuayeneTableAdapter muayeneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn muayeneIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hayvanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veterinerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn muayeneTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teşhisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedaviDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}