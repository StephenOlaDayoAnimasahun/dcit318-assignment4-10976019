namespace WindowsFormsApp
{
	partial class AddressBookForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.textBoxPhone = new System.Windows.Forms.TextBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonOpenDrawing = new System.Windows.Forms.Button();
			this.labelName = new System.Windows.Forms.Label();
			this.labelEmail = new System.Windows.Forms.Label();
			this.labelPhone = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(105, 30);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(100, 20);
			this.textBoxName.TabIndex = 0;
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Location = new System.Drawing.Point(105, 70);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
			this.textBoxEmail.TabIndex = 1;
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.Location = new System.Drawing.Point(105, 110);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
			this.textBoxPhone.TabIndex = 2;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(105, 150);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(100, 23);
			this.buttonSave.TabIndex = 3;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonOpenDrawing
			// 
			this.buttonOpenDrawing.Location = new System.Drawing.Point(105, 180);
			this.buttonOpenDrawing.Name = "buttonOpenDrawing";
			this.buttonOpenDrawing.Size = new System.Drawing.Size(100, 23);
			this.buttonOpenDrawing.TabIndex = 4;
			this.buttonOpenDrawing.Text = "Open Drawing";
			this.buttonOpenDrawing.UseVisualStyleBackColor = true;
			this.buttonOpenDrawing.Click += new System.EventHandler(this.buttonOpenDrawing_Click);
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(35, 33);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(35, 13);
			this.labelName.TabIndex = 5;
			this.labelName.Text = "Name";
			// 
			// labelEmail
			// 
			this.labelEmail.AutoSize = true;
			this.labelEmail.Location = new System.Drawing.Point(35, 73);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(32, 13);
			this.labelEmail.TabIndex = 6;
			this.labelEmail.Text = "Email";
			// 
			// labelPhone
			// 
			this.labelPhone.AutoSize = true;
			this.labelPhone.Location = new System.Drawing.Point(35, 113);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(38, 13);
			this.labelPhone.TabIndex = 7;
			this.labelPhone.Text = "Phone";
			// 
			// AddressBookForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 231);
			this.Controls.Add(this.labelPhone);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.buttonOpenDrawing);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.textBoxPhone);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.textBoxName);
			this.Name = "AddressBookForm";
			this.Text = "Address Book";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.TextBox textBoxPhone;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonOpenDrawing;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.Label labelPhone;
	}
}
