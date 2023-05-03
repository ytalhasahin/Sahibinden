namespace _3_Sahibinden
{
    partial class FrmCarAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.değiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddBrand = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnList = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMinYear = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMinPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMinKm = new System.Windows.Forms.TextBox();
            this.txtMaxYear = new System.Windows.Forms.TextBox();
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.txtMaxKm = new System.Windows.Forms.TextBox();
            this.checkedListColor = new System.Windows.Forms.CheckedListBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.checkedListBrand = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(84, 226);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(197, 20);
            this.txtModel.TabIndex = 3;
            // 
            // cbBrand
            // 
            this.cbBrand.ContextMenuStrip = this.contextMenuStrip1;
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(84, 170);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(197, 21);
            this.cbBrand.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.değiştirToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 48);
            // 
            // değiştirToolStripMenuItem
            // 
            this.değiştirToolStripMenuItem.Name = "değiştirToolStripMenuItem";
            this.değiştirToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.değiştirToolStripMenuItem.Text = "Değiştir";
            this.değiştirToolStripMenuItem.Click += new System.EventHandler(this.değiştirToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Model";
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.BackColor = System.Drawing.Color.Gold;
            this.btnAddBrand.Location = new System.Drawing.Point(206, 197);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(75, 23);
            this.btnAddBrand.TabIndex = 2;
            this.btnAddBrand.Text = "Marka Ekle";
            this.btnAddBrand.UseVisualStyleBackColor = false;
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yıl";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(84, 268);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(197, 20);
            this.txtYear.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(29, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fiyat";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(84, 348);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(197, 20);
            this.txtPrice.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(29, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "KM";
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(84, 306);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(197, 20);
            this.txtKm.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(30, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Renk";
            // 
            // cbColor
            // 
            this.cbColor.ContextMenuStrip = this.contextMenuStrip1;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(84, 385);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(197, 21);
            this.cbColor.TabIndex = 10;
            // 
            // btnAddColor
            // 
            this.btnAddColor.BackColor = System.Drawing.Color.Gold;
            this.btnAddColor.Location = new System.Drawing.Point(206, 412);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Size = new System.Drawing.Size(75, 23);
            this.btnAddColor.TabIndex = 11;
            this.btnAddColor.Text = "Renk Ekle";
            this.btnAddColor.UseVisualStyleBackColor = false;
            this.btnAddColor.Click += new System.EventHandler(this.btnAddColor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(29, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Şehir";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(84, 441);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(197, 20);
            this.txtCity.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gold;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(206, 465);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 42);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv.Location = new System.Drawing.Point(287, 125);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(316, 337);
            this.dgv.TabIndex = 5;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Gold;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.Location = new System.Drawing.Point(464, 465);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 42);
            this.btnList.TabIndex = 14;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(646, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Yıl";
            // 
            // txtMinYear
            // 
            this.txtMinYear.Location = new System.Drawing.Point(701, 161);
            this.txtMinYear.Name = "txtMinYear";
            this.txtMinYear.Size = new System.Drawing.Size(89, 20);
            this.txtMinYear.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(646, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Fiyat";
            // 
            // txtMinPrice
            // 
            this.txtMinPrice.Location = new System.Drawing.Point(701, 241);
            this.txtMinPrice.Name = "txtMinPrice";
            this.txtMinPrice.Size = new System.Drawing.Size(89, 20);
            this.txtMinPrice.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(646, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "KM";
            // 
            // txtMinKm
            // 
            this.txtMinKm.Location = new System.Drawing.Point(701, 199);
            this.txtMinKm.Name = "txtMinKm";
            this.txtMinKm.Size = new System.Drawing.Size(89, 20);
            this.txtMinKm.TabIndex = 6;
            // 
            // txtMaxYear
            // 
            this.txtMaxYear.Location = new System.Drawing.Point(809, 161);
            this.txtMaxYear.Name = "txtMaxYear";
            this.txtMaxYear.Size = new System.Drawing.Size(89, 20);
            this.txtMaxYear.TabIndex = 5;
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.Location = new System.Drawing.Point(809, 241);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(89, 20);
            this.txtMaxPrice.TabIndex = 8;
            // 
            // txtMaxKm
            // 
            this.txtMaxKm.Location = new System.Drawing.Point(809, 199);
            this.txtMaxKm.Name = "txtMaxKm";
            this.txtMaxKm.Size = new System.Drawing.Size(89, 20);
            this.txtMaxKm.TabIndex = 6;
            // 
            // checkedListColor
            // 
            this.checkedListColor.FormattingEnabled = true;
            this.checkedListColor.Location = new System.Drawing.Point(650, 370);
            this.checkedListColor.Name = "checkedListColor";
            this.checkedListColor.Size = new System.Drawing.Size(248, 94);
            this.checkedListColor.TabIndex = 15;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Gold;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilter.Location = new System.Drawing.Point(823, 470);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 42);
            this.btnFilter.TabIndex = 16;
            this.btnFilter.Text = "Filtrele";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnF
            // 
            this.btnF.BackColor = System.Drawing.Color.Transparent;
            this.btnF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnF.BackgroundImage")));
            this.btnF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnF.FlatAppearance.BorderSize = 0;
            this.btnF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnF.Location = new System.Drawing.Point(561, 465);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(42, 42);
            this.btnF.TabIndex = 17;
            this.btnF.UseVisualStyleBackColor = false;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(646, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ara";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(701, 125);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(197, 20);
            this.txtSearch.TabIndex = 3;
            // 
            // checkedListBrand
            // 
            this.checkedListBrand.FormattingEnabled = true;
            this.checkedListBrand.Location = new System.Drawing.Point(650, 274);
            this.checkedListBrand.Name = "checkedListBrand";
            this.checkedListBrand.Size = new System.Drawing.Size(248, 94);
            this.checkedListBrand.TabIndex = 15;
            // 
            // FrmCarAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(621, 519);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.checkedListBrand);
            this.Controls.Add(this.checkedListColor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddColor);
            this.Controls.Add(this.btnAddBrand);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.txtMaxKm);
            this.Controls.Add(this.txtMinKm);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaxPrice);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtMinPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMaxYear);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtMinYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCarAdd";
            this.Text = "Sahibinden.com";
            this.Load += new System.EventHandler(this.FrmCarAdd_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem değiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMinYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMinPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMinKm;
        private System.Windows.Forms.TextBox txtMaxYear;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.TextBox txtMaxKm;
        private System.Windows.Forms.CheckedListBox checkedListColor;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckedListBox checkedListBrand;
    }
}