using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Punto_De_Venta_Andro.Formularios.Usuarios
{
    public partial class Add_Edit_User : Form {
        public Add_Edit_User() {
            InitializeComponent();
        }

        private void BtnCancelUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodos
        public void BadNotification() {
            //Objeto Venta Notificacion
            Resources.BigNotification Notification = new Resources.BigNotification();
            //Icono Not..
            Notification.PBNotificacion.Image = Properties.Resources.Exclamation;
            //Color panel not..
            Notification.PAdvice.BackColor = Color.FromArgb(200, 250, 80, 80);
            Notification.PExclamation.BackColor = Color.FromArgb(200, 250, 80, 80);
        }

        public void GoodNotification() {
            //Objeto Venta Notificacion
            Resources.BigNotification Notification = new Resources.BigNotification();
            //Icono Not..
            Notification.PBNotificacion.Image = Properties.Resources.Checkmark;
            //Color paneles not..
            Notification.PAdvice.BackColor = Color.FromArgb(80, 250, 148);
            Notification.PExclamation.BackColor = Color.FromArgb(80, 250, 148);
        }

        private void BuscarDatos()
        {

            try{
                //Objeto Form Usuarios
                Ver_User Usuarios = new Ver_User();

                //Adaptador para Datos Tabla 
                DataTable DataT = new DataTable();
                SqlDataAdapter DataA;

                //Abrir Conexión
                SqlConnection SQLConexion = new SqlConnection();
                SQLConexion.ConnectionString = Conexion.ConexionMaestra.Conexion;
                SQLConexion.Open();

                //Abrir Procedimiento BUSCAR USUARIO
                DataA = new SqlDataAdapter("Buscar_Usuario", SQLConexion);
                DataA.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataA.SelectCommand.Parameters.AddWithValue("@Letra", Usuarios.TxtSearchUser.Text);

                //Convertir Datos
                DataA.Fill(DataT);

                //Imprimir datos en la tabla
                Usuarios.DGVUsuarios.DataSource = DataT;

                //Cerrar Conexión
                SQLConexion.Close();

                //Ocultar Columnas
                Usuarios.DGVUsuarios.Columns[1].Visible = false;
                Usuarios.DGVUsuarios.Columns[5].Visible = false;
                Usuarios.DGVUsuarios.Columns[6].Visible = false;
                Usuarios.DGVUsuarios.Columns[7].Visible = false;
                Usuarios.DGVUsuarios.Columns[8].Visible = false;
            }
            catch
            {
                MessageBox.Show("Error al mostrar los datos en la tabla");
            }



        }

        private void Used_Icon(){
            Ver_User Usuarios = new Ver_User();

            foreach (DataGridViewRow row in Usuarios.DGVUsuarios.Rows){

                try{
                    string IDIcono = Convert.ToString(row.Cells["Name_Icon"].Value);


                    if (IDIcono == "1"){
                        PB1.Visible = false;                                        //Ocultar Imagen Usada
                    }
                    else if (IDIcono == "2"){
                        PB2.Visible = false;                                        //Ocultar Imagen Usada
                    }
                    else if (IDIcono == "3"){
                        PB3.Visible = false;                                        //Ocultar Imagen Usada
                    }
                    else if (IDIcono == "4"){
                        PB4.Visible = false;                                        //Ocultar Imagen Usada
                    }
                    else if (IDIcono == "5"){
                        PB5.Visible = false;                                        //Ocultar Imagen Usada
                    }
                    else if (IDIcono == "6"){
                        PB6.Visible = false;                                        //Ocultar Imagen Usada
                    }
                    else if (IDIcono == "7"){
                        PB7.Visible = false;                                        //Ocultar Imagen Usada
                    }
                    else if (IDIcono == "8"){
                        PB8.Visible = false;                                        //Ocultar Imagen Usada
                    }
                    else if (IDIcono == "9"){
                        PB9.Visible = false;                                        //Ocultar Imagen Usada
                    }
                    else if (IDIcono == "10"){
                        PB10.Visible = false;                                        //Ocultar Imagen Usada
                    }
                    else if (IDIcono == "11"){
                        PB11.Visible = false;                                        //Ocultar Imagen Usada
                    }
                    else if (IDIcono == "12"){
                        PB12.Visible = false;                                        //Ocultar Imagen Usada
                    }
                    else if (IDIcono == "13"){
                        PB13.Visible = false;                                        //Ocultar Imagen Usada
                    }
                    else if (IDIcono == "14"){
                        PB14.Visible = false;                                        //Ocultar Imagen Usada
                    }

                }
                catch{}

            }

        }

        public void Solo_Numeros(Guna.UI2.WinForms.Guna2TextBox _1, System.Windows.Forms.KeyPressEventArgs e){
            //Valida si solo son numeros
            if (Char.IsDigit(e.KeyChar)){
                e.Handled = false;
            }else if (Char.IsControl(e.KeyChar)){
                e.Handled = false;
            }else{
                e.Handled = true;
            }


        }


        private void BtnAddImageUser_Click(object sender, EventArgs e)
        {
            Used_Icon();
            PanelImageUser.Visible = true;                                  //Mostrar Panel Image User
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            PanelImageUser.Visible = false;                                 //Ocultar Panel Image User
        }

        private void BtnGuardarUser_Click(object sender, EventArgs e) {
            //Variable para la validación del E-mail
            string CorreoValidation = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                  
            //Pregunta si algún campo esta vacío
            if (txtNameUser.Text == "") {
                //Focus Nombre
                txtNameUser.Focus();

                //Abrir Notificación
                Resources.BigNotification Notification = new Resources.BigNotification();
                Notification.txtNotification.Text = "Agrega un nombre";
                BadNotification();
                //Mostar not…
                Notification.Show();
            }
            else if (txtUser.Text == "") {
                //Focus Usuario
                txtUser.Focus();

                //Abrir Notificación
                Resources.BigNotification Notification = new Resources.BigNotification();
                BadNotification();
                Notification.txtNotification.Text = "Agrega un usuario";
                //Mostar not…
                Notification.Show();
            }
            else if (TxtPasswordUser.Text == "") {
                //Focus Contraseña
                TxtPasswordUser.Focus();

                //Abrir Notificación
                Resources.BigNotification Notification = new Resources.BigNotification();
                BadNotification();
                Notification.txtNotification.Text = "Agrega una cotraseña";
                //Mostar not…
                Notification.Show();
            }
            else if (txtCorreoUser.Text == "") {
                //Focus Correo
                txtCorreoUser.Focus();

                //Abrir Notificación
                Resources.BigNotification Notification = new Resources.BigNotification();
                BadNotification();
                Notification.txtNotification.Text = "Agrega un correo";
                //Mostar not…
                Notification.Show();
            }
            //Valida el E Mail con el formato correcto
            else if (!Regex.IsMatch(txtCorreoUser.Text, CorreoValidation)){
                MessageBox.Show("Dirección de correo electronico invalida ", "Validación de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCorreoUser.Focus();
                txtCorreoUser.SelectAll();
            }
            else if (CBRolUser.Text == "") {
                //Focus Rol
                CBRolUser.Focus();

                //Abrir Notificación
                Resources.BigNotification Notification = new Resources.BigNotification();
                BadNotification();
                Notification.txtNotification.Text = "Agrega un rol";
                //Mostar not…
                Notification.Show();
            }
            else if (txtNameIcon.Text == "Nombre Icono") {

                //Abrir Notificación & Cronometro
                Resources.BigNotification Notification = new Resources.BigNotification();
                Notification.txtNotification.Text = "Selecciona un icono";
                BadNotification();
                //Mostar not…
                Notification.Show();
            }
            else if (txtNameUser.Text != "" && txtUser.Text != "" && TxtPasswordUser.Text != "" && txtCorreoUser.Text != "" && CBRolUser.Text != "" && txtNameIcon.Text != "Nombre Icono"){
                try {
                    //Abrir Conexión
                    SqlConnection SQLConexion = new SqlConnection();
                    SQLConexion.ConnectionString = Conexion.ConexionMaestra.Conexion;
                    SQLConexion.Open();

                    //Abrir Procedimiento INSERTAR USUARIO
                    SqlCommand Procedimiento = new SqlCommand();
                    Procedimiento = new SqlCommand("Insertar_Usuario", SQLConexion);
                    Procedimiento.CommandType = CommandType.StoredProcedure;

                    //Insertar Datos 
                    Procedimiento.Parameters.AddWithValue("@Nombre_Apellidos", txtNameUser.Text);
                    Procedimiento.Parameters.AddWithValue("@Usuario", txtUser.Text);
                    Procedimiento.Parameters.AddWithValue("@PassWord", TxtPasswordUser.Text);
                    Procedimiento.Parameters.AddWithValue("@Correo", txtCorreoUser.Text);
                    Procedimiento.Parameters.AddWithValue("@Rol", CBRolUser.Text);

                    //Procesar Imagenes / Memoriza las imagenes
                    System.IO.MemoryStream MemoryS = new System.IO.MemoryStream();

                    //Convertir Imagenes a formato SQL
                    BtnAddImageUser.Image.Save(MemoryS, BtnAddImageUser.Image.RawFormat);


                    //Insertar Imagen
                    Procedimiento.Parameters.AddWithValue("@Icon", MemoryS.GetBuffer());
                    Procedimiento.Parameters.AddWithValue("@Name_Icon", txtNameIcon.Text);

                    //Agrega el estado Activo
                    Procedimiento.Parameters.AddWithValue("@Estado","Activo");

                    //Cerrar Conexión y Procedimiento
                    Procedimiento.ExecuteNonQuery();
                    SQLConexion.Close();

                    //Notificación
                    //Objeto Ventana Notificación
                    Resources.BigNotification Notification = new Resources.BigNotification();
                    //Texto Notificacion
                    Notification.txtNotification.Text = "Usuario Agregado Correctamente";
                    //Icono Not...
                    Notification.PBNotificacion.Image = Properties.Resources.Checkmark;
                    //Color paneles Not..
                    Notification.PAdvice.BackColor = Color.FromArgb(80, 250, 148);
                    Notification.PExclamation.BackColor = Color.FromArgb(80, 250, 148);
                    //Mostrar paneles Not...
                    Notification.Show();

                    //Cerrar Agregar Usuario
                    this.Close();

                }catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                }

            }

            //Reload Users
            BuscarDatos();
        }


        //Show and Hide Password
        private void PBShowPasswordUser_Click(object sender, EventArgs e)
        {
            Convert.ToString(TxtPasswordUser.PasswordChar = '\0');
            PBShowPasswordUser.Visible = false;
            PBHidePasswordUser.Visible = true;
        }

        private void PBHidePasswordUser_Click(object sender, EventArgs e)
        {
            Convert.ToString(TxtPasswordUser.PasswordChar = '•');
            PBShowPasswordUser.Visible = true;
            PBHidePasswordUser.Visible = false;
        }



        private void BtnModificarUser_Click(object sender, EventArgs e){
            //Variable para la validación del E-mail
            string CorreoValidation = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            //Pregunta si algún campo esta vacío
            if (txtNameUser.Text == "")
            {
                //Focus Nombre
                txtNameUser.Focus();

                //Abrir Notificación
                Resources.BigNotification Notification = new Resources.BigNotification();
                Notification.txtNotification.Text = "Agrega un nombre";
                BadNotification();
                //Mostar not…
                Notification.Show();
            }
            else if (txtUser.Text == "")
            {
                //Focus Usuario
                txtUser.Focus();

                //Abrir Notificación
                Resources.BigNotification Notification = new Resources.BigNotification();
                BadNotification();
                Notification.txtNotification.Text = "Agrega un usuario";
                //Mostar not…
                Notification.Show();
            }
            else if (TxtPasswordUser.Text == "")
            {
                //Focus Contraseña
                TxtPasswordUser.Focus();

                //Abrir Notificación
                Resources.BigNotification Notification = new Resources.BigNotification();
                BadNotification();
                Notification.txtNotification.Text = "Agrega una cotraseña";
                //Mostar not…
                Notification.Show();
            }
            else if (txtCorreoUser.Text == "")
            {
                //Focus Correo
                txtCorreoUser.Focus();

                //Abrir Notificación
                Resources.BigNotification Notification = new Resources.BigNotification();
                BadNotification();
                Notification.txtNotification.Text = "Agrega un correo";
                //Mostar not…
                Notification.Show();
            }
            //Valida el E Mail con el formato correcto
            else if (!Regex.IsMatch(txtCorreoUser.Text, CorreoValidation)){
                MessageBox.Show("Dirección de correo electronico invalida ", "Validación de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCorreoUser.Focus();
                txtCorreoUser.SelectAll();
            }
            else if (CBRolUser.Text == "")
            {
                //Focus Rol
                CBRolUser.Focus();

                //Abrir Notificación
                Resources.BigNotification Notification = new Resources.BigNotification();
                BadNotification();
                Notification.txtNotification.Text = "Agrega un rol";
                //Mostar not…
                Notification.Show();
            }
            else if (txtNameIcon.Text == "Nombre Icono"){

                //Abrir Notificación & Cronometro
                Resources.BigNotification Notification = new Resources.BigNotification();
                Notification.txtNotification.Text = "Selecciona un icono";
                BadNotification();
                //Mostar not…
                Notification.Show();
            }
            else if (txtNameUser.Text != "" && txtUser.Text != "" && TxtPasswordUser.Text != "" && txtCorreoUser.Text != "" && CBRolUser.Text != "" && txtNameIcon.Text != "Nombre Icono"){
                try{
                    //Abrir Conexión
                    SqlConnection SQLConexion = new SqlConnection();
                    SQLConexion.ConnectionString = Conexion.ConexionMaestra.Conexion;
                    SQLConexion.Open();

                    //Abrir Procedimiento INSERTAR USUARIO
                    SqlCommand Procedimiento = new SqlCommand();
                    Procedimiento = new SqlCommand("Modificar_Usuario", SQLConexion);
                    Procedimiento.CommandType = CommandType.StoredProcedure;

                    //Insertar Datos
                    Procedimiento.Parameters.AddWithValue("@IDUser", txtID.Text);
                    Procedimiento.Parameters.AddWithValue("@Nombre_Apellidos", txtNameUser.Text);
                    Procedimiento.Parameters.AddWithValue("@Usuario", txtUser.Text);
                    Procedimiento.Parameters.AddWithValue("@PassWord", TxtPasswordUser.Text);
                    Procedimiento.Parameters.AddWithValue("@Correo", txtCorreoUser.Text);
                    Procedimiento.Parameters.AddWithValue("@Rol", CBRolUser.Text);

                    //Procesar Imagenes / Memoriza las imagenes
                    System.IO.MemoryStream MemoryS = new System.IO.MemoryStream();

                    //Convertir Imagenes a formato SQL
                    BtnAddImageUser.Image.Save(MemoryS, BtnAddImageUser.Image.RawFormat);


                    //Insertar Imagen
                    Procedimiento.Parameters.AddWithValue("@Icon", MemoryS.GetBuffer());
                    Procedimiento.Parameters.AddWithValue("@Name_Icon", txtNameIcon.Text);

                    //Cerrar Conexión y Procedimiento
                    Procedimiento.ExecuteNonQuery();
                    SQLConexion.Close();

                    //Notificación
                    //Objeto Ventana Notificación
                    Resources.BigNotification Notification = new Resources.BigNotification();
                    //Texto Notificacion
                    Notification.txtNotification.Text = "Usuario Modificado Correctamente";
                    //Icono Not...
                    Notification.PBNotificacion.Image = Properties.Resources.Checkmark;
                    //Color paneles Not..
                    Notification.PAdvice.BackColor = Color.FromArgb(80, 250, 148);
                    Notification.PExclamation.BackColor = Color.FromArgb(80, 250, 148);
                    //Mostrar paneles Not...
                    Notification.Show();

                    //Cerrar Agregar Usuario
                    this.Close();

                }
                catch (Exception ex){
                    MessageBox.Show(ex.Message);
                }

            }

            //Reload Users
            BuscarDatos();

        }

        //Imagenes Predeterminadas
        private void PB1_Click(object sender, EventArgs e)
        {
            BtnAddImageUser.Image = Properties.Resources.Woma3;             //Agrega imagen al botón User
            PanelImageUser.Visible = false;                                 //Ocultar Panel Image User
            txtNameIcon.Text = "1";                                         //Nombre Icono
        }

        private void PB2_Click(object sender, EventArgs e)
        {
            BtnAddImageUser.Image = Properties.Resources.Man2;              //Agrega imagen al botón User
            PanelImageUser.Visible = false;                                 //Ocultar Panel Image User
            txtNameIcon.Text = "2";                                         //Nombre Icono
        }

        private void PB3_Click(object sender, EventArgs e)
        {
            BtnAddImageUser.Image = Properties.Resources.Woman2;            //Agrega imagen al botón User
            PanelImageUser.Visible = false;                                 //Ocultar Panel Image User
            txtNameIcon.Text = "3";                                         //Nombre Icono
        }

        private void PB4_Click(object sender, EventArgs e)
        {
            BtnAddImageUser.Image = Properties.Resources.Man3;              //Agrega imagen al botón User
            PanelImageUser.Visible = false;                                 //Ocultar Panel Image User
            txtNameIcon.Text = "4";                                         //Nombre Icono
        }

        private void PB5_Click(object sender, EventArgs e)
        {
            BtnAddImageUser.Image = PB5.Image;                              //Agrega imagen al botón User
            PanelImageUser.Visible = false;                                 //Ocultar Panel Image User
            txtNameIcon.Text = "5";                                         //Nombre Icono
        }

        private void PB6_Click(object sender, EventArgs e)
        {
            BtnAddImageUser.Image = PB6.Image;                              //Agrega imagen al botón User
            PanelImageUser.Visible = false;                                 //Ocultar Panel Image User
            txtNameIcon.Text = "6";                                         //Nombre Icono
        }

        private void PB7_Click(object sender, EventArgs e)
        {
            BtnAddImageUser.Image = PB7.Image;                              //Agrega imagen al botón User
            PanelImageUser.Visible = false;                                 //Ocultar Panel Image User
            txtNameIcon.Text = "7";                                         //Nombre Icono
        }

        private void PB8_Click(object sender, EventArgs e)
        {
            BtnAddImageUser.Image = PB8.Image;                              //Agrega imagen al botón User
            PanelImageUser.Visible = false;                                 //Ocultar Panel Image User
            txtNameIcon.Text = "8";                                         //Nombre Icono
        }

        private void PB9_Click(object sender, EventArgs e)
        {
            BtnAddImageUser.Image = PB9.Image;                              //Agrega imagen al botón User
            PanelImageUser.Visible = false;                                 //Ocultar Panel Image User
            txtNameIcon.Text = "9";                                         //Nombre Icono
        }

        private void PB10_Click(object sender, EventArgs e)
        {
            BtnAddImageUser.Image = PB10.Image;                             //Agrega imagen al botón User
            PanelImageUser.Visible = false;                                 //Ocultar Panel Image User
            txtNameIcon.Text = "10";                                        //Nombre Icono
        }

        private void PB11_Click(object sender, EventArgs e)
        {
            BtnAddImageUser.Image = PB11.Image;                             //Agrega imagen al botón User
            PanelImageUser.Visible = false;                                 //Ocultar Panel Image User
            txtNameIcon.Text = "11";                                        //Nombre Icono
        }

        private void PB12_Click(object sender, EventArgs e)
        {
            BtnAddImageUser.Image = PB12.Image;                             //Agrega imagen al botón User
            PanelImageUser.Visible = false;                                 //Ocultar Panel Image User
            txtNameIcon.Text = "12";                                        //Nombre Icono
        }

        private void PB13_Click(object sender, EventArgs e)
        {
            BtnAddImageUser.Image = PB13.Image;                             //Agrega imagen al botón User
            PanelImageUser.Visible = false;                                 //Ocultar Panel Image User
            txtNameIcon.Text = "13";                                        //Nombre Icono
        }

        private void PB14_Click(object sender, EventArgs e)
        {
            BtnAddImageUser.Image = PB14.Image;                             //Agrega imagen al botón User
            PanelImageUser.Visible = false;                                 //Ocultar Panel Image User
            txtNameIcon.Text = "14";                                        //Nombre Icono
        }

        //Buscador de Imagenes
        private void PBSeleccionaImage_Click(object sender, EventArgs e)
        {
            OFDImage.InitialDirectory = "";
            OFDImage.Filter = "Imagenes|*.jpg;*.png";
            OFDImage.FilterIndex = 2;
            OFDImage.Title = "Busca una imagen como foto de perfil";

            if (OFDImage.ShowDialog() == DialogResult.OK){
                BtnAddImageUser.Image = new Bitmap(OFDImage.FileName);

                txtNameIcon.Text = Path.GetFileName(OFDImage.FileName);
                PanelImageUser.Visible = false;
            }


        }

        //Solo numeros 
        private void TxtPasswordUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Objeto Form Usuarios
            Ver_User Usuarios = new Ver_User();

            //Metodo Validar SOLO numeros
            Solo_Numeros(Usuarios.TxtSearchUser, e);
        }

        //Load Form 
        private void Add_Edit_User_Load(object sender, EventArgs e)
        {
            txtNameUser.Focus();
            txtNameUser.SelectAll();
            txtNameUser.Select();
        }
    }
}
