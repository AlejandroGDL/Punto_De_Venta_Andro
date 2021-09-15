using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_De_Venta_Andro.Clases
{
    class Metodos
    {

        public void Mostrar_Login(){
            Formularios.Login.Login_User Login = new Formularios.Login.Login_User();

            //Mostrar Cosas
            Login.BtnRecoverPass.Visible = true;
            Login.FLPLoginUsers.Visible = true;
            Login.txtTittle.Visible = true;
        }

    }
}
