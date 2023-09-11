namespace FormMain
{
	partial class FormPriceSearch
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.butSearch = new System.Windows.Forms.Button();
			this.comboBrand = new System.Windows.Forms.ComboBox();
			this.comboType = new System.Windows.Forms.ComboBox();
			this.txtMin = new System.Windows.Forms.TextBox();
			this.txtMax = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dataGridView1.Location = new System.Drawing.Point(84, 119);
			this.dataGridView1.MinimumSize = new System.Drawing.Size(542, 289);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(542, 289);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// butSearch
			// 
			this.butSearch.BackColor = System.Drawing.SystemColors.Info;
			this.butSearch.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.butSearch.Location = new System.Drawing.Point(525, 59);
			this.butSearch.Name = "butSearch";
			this.butSearch.Size = new System.Drawing.Size(101, 33);
			this.butSearch.TabIndex = 1;
			this.butSearch.Text = "查詢";
			this.butSearch.UseVisualStyleBackColor = false;
			this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
			// 
			// comboBrand
			// 
			this.comboBrand.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBrand.FormattingEnabled = true;
			this.comboBrand.Items.AddRange(new object[] {
            "Toyota",
            "Honda",
            "BMW"});
			this.comboBrand.Location = new System.Drawing.Point(155, 40);
			this.comboBrand.Name = "comboBrand";
			this.comboBrand.Size = new System.Drawing.Size(121, 24);
			this.comboBrand.TabIndex = 3;
			this.comboBrand.Text = "搜尋品牌:";
			// 
			// comboType
			// 
			this.comboType.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboType.FormattingEnabled = true;
			this.comboType.Items.AddRange(new object[] {
            "SUV",
            "CUV",
            "Sedan",
            "MPV"});
			this.comboType.Location = new System.Drawing.Point(155, 73);
			this.comboType.Name = "comboType";
			this.comboType.Size = new System.Drawing.Size(121, 24);
			this.comboType.TabIndex = 3;
			this.comboType.Text = "搜尋車種:";
			// 
			// txtMin
			// 
			this.txtMin.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtMin.Location = new System.Drawing.Point(382, 40);
			this.txtMin.Name = "txtMin";
			this.txtMin.Size = new System.Drawing.Size(97, 27);
			this.txtMin.TabIndex = 4;
			// 
			// txtMax
			// 
			this.txtMax.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtMax.Location = new System.Drawing.Point(382, 70);
			this.txtMax.Name = "txtMax";
			this.txtMax.Size = new System.Drawing.Size(97, 27);
			this.txtMax.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(301, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "價錢下限:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(301, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "價錢上限:";
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "Brand";
			this.Column1.HeaderText = "品牌";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "Id";
			this.Column6.HeaderText = "編號";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Visible = false;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "Model";
			this.Column2.HeaderText = "車款";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "Type";
			this.Column3.HeaderText = "車種";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "Price";
			this.Column4.HeaderText = "價錢(k)";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "Seller";
			this.Column5.HeaderText = "賣家";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// FormPriceSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtMax);
			this.Controls.Add(this.txtMin);
			this.Controls.Add(this.comboType);
			this.Controls.Add(this.comboBrand);
			this.Controls.Add(this.butSearch);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FormPriceSearch";
			this.Text = "FormPriceSearch";
			this.Load += new System.EventHandler(this.FormPriceSearch_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button butSearch;
		private System.Windows.Forms.ComboBox comboBrand;
		private System.Windows.Forms.ComboBox comboType;
		private System.Windows.Forms.TextBox txtMin;
		private System.Windows.Forms.TextBox txtMax;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
	}
}