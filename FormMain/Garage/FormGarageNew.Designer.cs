namespace FormMain.Garage
{
	partial class FormGarageNew
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtModel = new System.Windows.Forms.TextBox();
			this.comboBoxType = new System.Windows.Forms.ComboBox();
			this.comboBoxBrand = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtFuel = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.txtYear = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.butCreate = new System.Windows.Forms.Button();
			this.butImageLoad = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtPrice);
			this.groupBox1.Controls.Add(this.txtModel);
			this.groupBox1.Controls.Add(this.comboBoxType);
			this.groupBox1.Controls.Add(this.comboBoxBrand);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.groupBox1.Location = new System.Drawing.Point(46, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(267, 259);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "車輛資訊封面";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(81, 182);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(136, 27);
			this.txtPrice.TabIndex = 3;
			// 
			// txtModel
			// 
			this.txtModel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtModel.Location = new System.Drawing.Point(81, 89);
			this.txtModel.Name = "txtModel";
			this.txtModel.Size = new System.Drawing.Size(136, 27);
			this.txtModel.TabIndex = 0;
			// 
			// comboBoxType
			// 
			this.comboBoxType.FormattingEnabled = true;
			this.comboBoxType.Items.AddRange(new object[] {
            "SUV",
            "CUV",
            "Sedan",
            "MPV"});
			this.comboBoxType.Location = new System.Drawing.Point(81, 137);
			this.comboBoxType.Name = "comboBoxType";
			this.comboBoxType.Size = new System.Drawing.Size(112, 24);
			this.comboBoxType.TabIndex = 0;
			// 
			// comboBoxBrand
			// 
			this.comboBoxBrand.FormattingEnabled = true;
			this.comboBoxBrand.Items.AddRange(new object[] {
            "Toyota",
            "Honda",
            "BMW"});
			this.comboBoxBrand.Location = new System.Drawing.Point(81, 44);
			this.comboBoxBrand.Name = "comboBoxBrand";
			this.comboBoxBrand.Size = new System.Drawing.Size(112, 24);
			this.comboBoxBrand.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label7.Location = new System.Drawing.Point(32, 94);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(43, 16);
			this.label7.TabIndex = 1;
			this.label7.Text = "車款:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.Location = new System.Drawing.Point(32, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 16);
			this.label6.TabIndex = 1;
			this.label6.Text = "品牌:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(32, 140);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 16);
			this.label4.TabIndex = 1;
			this.label4.Text = "車種:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(32, 186);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 16);
			this.label3.TabIndex = 1;
			this.label3.Text = "價錢:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtFuel);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.txtYear);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.groupBox2.Location = new System.Drawing.Point(46, 281);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(267, 157);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "車輛細節";
			// 
			// txtFuel
			// 
			this.txtFuel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtFuel.Location = new System.Drawing.Point(81, 41);
			this.txtFuel.Name = "txtFuel";
			this.txtFuel.Size = new System.Drawing.Size(136, 27);
			this.txtFuel.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(0, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "燃料種類:";
			// 
			// txtDescription
			// 
			this.txtDescription.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtDescription.Location = new System.Drawing.Point(350, 294);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(362, 144);
			this.txtDescription.TabIndex = 0;
			// 
			// txtYear
			// 
			this.txtYear.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtYear.Location = new System.Drawing.Point(81, 90);
			this.txtYear.Name = "txtYear";
			this.txtYear.Size = new System.Drawing.Size(136, 27);
			this.txtYear.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(347, 275);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 16);
			this.label5.TabIndex = 1;
			this.label5.Text = "描述:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(32, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "年式:";
			// 
			// butCreate
			// 
			this.butCreate.BackColor = System.Drawing.Color.LightGray;
			this.butCreate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.butCreate.Location = new System.Drawing.Point(730, 371);
			this.butCreate.Name = "butCreate";
			this.butCreate.Size = new System.Drawing.Size(58, 35);
			this.butCreate.TabIndex = 7;
			this.butCreate.Text = "新增";
			this.butCreate.UseVisualStyleBackColor = false;
			this.butCreate.Click += new System.EventHandler(this.butCreate_Click);
			// 
			// butImageLoad
			// 
			this.butImageLoad.BackColor = System.Drawing.Color.Silver;
			this.butImageLoad.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.butImageLoad.Location = new System.Drawing.Point(722, 207);
			this.butImageLoad.Name = "butImageLoad";
			this.butImageLoad.Size = new System.Drawing.Size(75, 63);
			this.butImageLoad.TabIndex = 9;
			this.butImageLoad.Text = "上傳新圖片";
			this.butImageLoad.UseVisualStyleBackColor = false;
			this.butImageLoad.Click += new System.EventHandler(this.butImageLoad_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(396, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(316, 254);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// FormGarageNew
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.butImageLoad);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.butCreate);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.groupBox2);
			this.Name = "FormGarageNew";
			this.Text = "FormGarageNew";
			this.Load += new System.EventHandler(this.FormGarageNew_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtModel;
		private System.Windows.Forms.ComboBox comboBoxType;
		private System.Windows.Forms.ComboBox comboBoxBrand;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtFuel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.TextBox txtYear;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button butCreate;
		private System.Windows.Forms.Button butImageLoad;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}