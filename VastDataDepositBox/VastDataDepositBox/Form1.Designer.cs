
namespace VastDataDepositBox
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
			if(disposing && (components != null))
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
			this.btnEncrypt = new System.Windows.Forms.Button();
			this.btnGenMatrix = new System.Windows.Forms.Button();
			this.txtPlainText = new System.Windows.Forms.TextBox();
			this.lblKeyOut = new System.Windows.Forms.Label();
			this.lblPlainText = new System.Windows.Forms.Label();
			this.txtKey = new System.Windows.Forms.TextBox();
			this.btnDecrypt = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnEncrypt
			// 
			this.btnEncrypt.Location = new System.Drawing.Point(12, 104);
			this.btnEncrypt.Name = "btnEncrypt";
			this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
			this.btnEncrypt.TabIndex = 0;
			this.btnEncrypt.Text = "Encrypt";
			this.btnEncrypt.UseVisualStyleBackColor = true;
			this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
			// 
			// btnGenMatrix
			// 
			this.btnGenMatrix.Location = new System.Drawing.Point(12, 12);
			this.btnGenMatrix.Name = "btnGenMatrix";
			this.btnGenMatrix.Size = new System.Drawing.Size(75, 23);
			this.btnGenMatrix.TabIndex = 1;
			this.btnGenMatrix.Text = "Generate Matrix";
			this.btnGenMatrix.UseVisualStyleBackColor = true;
			this.btnGenMatrix.Click += new System.EventHandler(this.btnGenMatrix_Click);
			// 
			// txtPlainText
			// 
			this.txtPlainText.Location = new System.Drawing.Point(13, 78);
			this.txtPlainText.Name = "txtPlainText";
			this.txtPlainText.Size = new System.Drawing.Size(133, 20);
			this.txtPlainText.TabIndex = 2;
			// 
			// lblKeyOut
			// 
			this.lblKeyOut.AutoSize = true;
			this.lblKeyOut.Location = new System.Drawing.Point(13, 134);
			this.lblKeyOut.Name = "lblKeyOut";
			this.lblKeyOut.Size = new System.Drawing.Size(28, 13);
			this.lblKeyOut.TabIndex = 3;
			this.lblKeyOut.Text = "Key:";
			// 
			// lblPlainText
			// 
			this.lblPlainText.AutoSize = true;
			this.lblPlainText.Location = new System.Drawing.Point(13, 256);
			this.lblPlainText.Name = "lblPlainText";
			this.lblPlainText.Size = new System.Drawing.Size(31, 13);
			this.lblPlainText.TabIndex = 6;
			this.lblPlainText.Text = "Text:";
			// 
			// txtKey
			// 
			this.txtKey.Location = new System.Drawing.Point(13, 200);
			this.txtKey.Name = "txtKey";
			this.txtKey.Size = new System.Drawing.Size(133, 20);
			this.txtKey.TabIndex = 5;
			// 
			// btnDecrypt
			// 
			this.btnDecrypt.Location = new System.Drawing.Point(12, 226);
			this.btnDecrypt.Name = "btnDecrypt";
			this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
			this.btnDecrypt.TabIndex = 4;
			this.btnDecrypt.Text = "Decrypt";
			this.btnDecrypt.UseVisualStyleBackColor = true;
			this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblPlainText);
			this.Controls.Add(this.txtKey);
			this.Controls.Add(this.btnDecrypt);
			this.Controls.Add(this.lblKeyOut);
			this.Controls.Add(this.txtPlainText);
			this.Controls.Add(this.btnGenMatrix);
			this.Controls.Add(this.btnEncrypt);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnEncrypt;
		private System.Windows.Forms.Button btnGenMatrix;
		private System.Windows.Forms.TextBox txtPlainText;
		private System.Windows.Forms.Label lblKeyOut;
		private System.Windows.Forms.Label lblPlainText;
		private System.Windows.Forms.TextBox txtKey;
		private System.Windows.Forms.Button btnDecrypt;
	}
}

