﻿
namespace Schleifen
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnSchleife1 = new System.Windows.Forms.Button();
			this.lblSchleife1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSchleife1
			// 
			this.btnSchleife1.Location = new System.Drawing.Point(13, 13);
			this.btnSchleife1.Name = "btnSchleife1";
			this.btnSchleife1.Size = new System.Drawing.Size(75, 23);
			this.btnSchleife1.TabIndex = 0;
			this.btnSchleife1.Text = "Schleife 1";
			this.btnSchleife1.UseVisualStyleBackColor = true;
			this.btnSchleife1.Click += new System.EventHandler(this.btnSchleife1_Click);
			// 
			// lblSchleife1
			// 
			this.lblSchleife1.AutoSize = true;
			this.lblSchleife1.Location = new System.Drawing.Point(126, 18);
			this.lblSchleife1.Name = "lblSchleife1";
			this.lblSchleife1.Size = new System.Drawing.Size(35, 13);
			this.lblSchleife1.TabIndex = 1;
			this.lblSchleife1.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(369, 98);
			this.Controls.Add(this.lblSchleife1);
			this.Controls.Add(this.btnSchleife1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSchleife1;
		private System.Windows.Forms.Label lblSchleife1;
	}
}

