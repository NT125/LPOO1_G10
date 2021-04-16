using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClasesBase;

namespace Vistas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Boolean bUserFound = false;

            Usuario oUsuario1 = new Usuario("Jhon","123");
            Usuario oUsuario2 = new Usuario("Aria", "123");


            FrmMain oFrmMain = new FrmMain();

            if (oUsuario1.UsuNombreUsuario == txtUserName.Text && oUsuario1.UsuContrasenia == txtPassword.Text)
            {
                bUserFound = true;
            }
            else if (oUsuario2.UsuNombreUsuario == txtUserName.Text && oUsuario2.UsuContrasenia == txtPassword.Text)
            {
                bUserFound = true;
            }

            if (bUserFound)
            {
                MessageBox.Show("Bienvenido/a:: " + txtUserName.Text);
                
                oFrmMain.perfil = "administrador";
                oFrmMain.Show();
                this.Hide();                
            }


            else
            {
                MessageBox.Show("Datos de acceso incorrectos");
            }



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
