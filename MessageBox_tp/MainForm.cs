/*
 * Created by SharpDevelop.
 * User: PC
 * Date: 26/11/2021
 * Time: 16:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MessageBox_tp
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{	usuario objusuario=new usuario();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			
			objusuario= new usuario();
			 objusuario.n_usuario="pedro";
			 objusuario.c_usuario="casa123";
		}
		void Btn_ingresarClick(object sender, EventArgs e)
		{
			string aux_nom=txt_usuario.Text;
			string aux_cont=txt_usuario.Text;
			
			if(aux_nom != objusuario.n_usuario && aux_cont == objusuario.c_usuario){
				
				MessageBox.Show("Usuario incorrecto","");
				
			}
				
			if(aux_nom == objusuario.n_usuario && aux_cont != objusuario.c_usuario){
				
				MessageBox.Show("contraseña incorrecta","");
				
			}
			if(aux_nom != objusuario.n_usuario && aux_cont != objusuario.c_usuario){
				
				MessageBox.Show("usuario y contraseña incorrectos","");
				
			}
			if (aux_nom == objusuario.n_usuario && aux_cont == objusuario.c_usuario) {
				MessageBox.Show("Bienvenido","");
			}
			
		}
	}
		class usuario{
			public string n_usuario;
			public string c_usuario;
			
	}
	}

