using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenII_OscarMedina.Modelos.DAO;
using ExamenII_OscarMedina.Modelos.Entidades;
using ExamenII_OscarMedina.Vistas;
using System.Windows.Forms;

namespace ExamenII_OscarMedina.Controladores
{
    public class LoginController
    {
        LoginView vista;
        public LoginController(LoginView view)
        {
            vista = view;
            vista.bttaceptar.Click += new EventHandler(ValidarUsuario);

        }
        private void ValidarUsuario(object serder, EventArgs e)
        {
            //llamar los modelos 
            UsuarioDAO userDAO = new UsuarioDAO();
            Usuario user = new Usuario();
            user.Email = vista.TxtEmail.Text;
            user.Clave = vista.Txt_Contra.Text;


            bool valido = userDAO.ValidarUsuario(user);
            if (valido)
            {
                MessageBox.Show("Usuario Correcto");

            }
            else
            {
                MessageBox.Show("Usuario Correcto");

            }

        }
    }
}
