/*
 * Created by SharpDevelop.
 * User: PC
 * Date: 26/11/2021
 * Time: 16:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MessageBox_tp
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn_ingresar;
		private System.Windows.Forms.TextBox txt_contraseña;
		private System.Windows.Forms.TextBox txt_usuario;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.Label lbl1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_ingresar = new System.Windows.Forms.Button();
			this.txt_contraseña = new System.Windows.Forms.TextBox();
			this.txt_usuario = new System.Windows.Forms.TextBox();
			this.lbl2 = new System.Windows.Forms.Label();
			this.lbl1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_ingresar
			// 
			this.btn_ingresar.Location = new System.Drawing.Point(81, 162);
			this.btn_ingresar.Name = "btn_ingresar";
			this.btn_ingresar.Size = new System.Drawing.Size(105, 57);
			this.btn_ingresar.TabIndex = 9;
			this.btn_ingresar.Text = "ingresar";
			this.btn_ingresar.UseVisualStyleBackColor = true;
			this.btn_ingresar.Click += new System.EventHandler(this.Btn_ingresarClick);
			// 
			// txt_contraseña
			// 
			this.txt_contraseña.Location = new System.Drawing.Point(27, 126);
			this.txt_contraseña.Name = "txt_contraseña";
			this.txt_contraseña.Size = new System.Drawing.Size(231, 20);
			this.txt_contraseña.TabIndex = 8;
			
			// 
			// txt_usuario
			// 
			this.txt_usuario.Location = new System.Drawing.Point(27, 57);
			this.txt_usuario.Name = "txt_usuario";
			this.txt_usuario.Size = new System.Drawing.Size(231, 20);
			this.txt_usuario.TabIndex = 7;
			
			// 
			// lbl2
			// 
			this.lbl2.Location = new System.Drawing.Point(27, 108);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(231, 13);
			this.lbl2.TabIndex = 6;
			this.lbl2.Text = "Ingrese contraseña:";
			
			// 
			// lbl1
			// 
			this.lbl1.Location = new System.Drawing.Point(27, 41);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(231, 13);
			this.lbl1.TabIndex = 5;
			this.lbl1.Text = "Ingrese usuario:";
			
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btn_ingresar);
			this.Controls.Add(this.txt_contraseña);
			this.Controls.Add(this.txt_usuario);
			this.Controls.Add(this.lbl2);
			this.Controls.Add(this.lbl1);
			this.Name = "MainForm";
			this.Text = "MessageBox_tp";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
