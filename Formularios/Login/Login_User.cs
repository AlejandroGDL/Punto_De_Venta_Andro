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
using System.IO;
using System.Management;

namespace Punto_De_Venta_Andro.Formularios.Login
{

    public partial class Login_User : Form{
        int contador;
        public Login_User(){
            InitializeComponent();
        }

        //Metodo para Mostrar & Dibujar Usuarios
        public void Draw_Users() {
            //Abrir Conexión
            SqlConnection SQLConexion = new SqlConnection();
            SQLConexion.ConnectionString = Conexion.ConexionMaestra.Conexion;
            SQLConexion.Open();

            //Abrir Procedimiento INSERTAR USUARIO
            SqlCommand Procedimiento = new SqlCommand();
            Procedimiento = new SqlCommand("Select * From Usuarios Where Estado = 'Activo'", SQLConexion);
            SqlDataReader DataR = Procedimiento.ExecuteReader();

            //Bucle
            while (DataR.Read()) {
                Label Texto = new Label();
                Panel PanelLogin = new Panel();
                Guna.UI2.WinForms.Guna2ImageButton Imagen = new Guna.UI2.WinForms.Guna2ImageButton();

                //Dibuja un Panel
                PanelLogin.BackColor = Color.White;
                PanelLogin.Size = new Size(230, 270);

                //Dibuja una imagen con caracteristicas predefinidas
                Imagen.ImageSize = new Size(230, 230);
                Imagen.Size = new Size(230, 230);
                Imagen.HoverState.ImageSize = new Size(225, 225);
                Imagen.PressedState.ImageSize = new Size(230, 230);

                Imagen.Dock = DockStyle.Top;
                byte[] Byte = (Byte[])DataR["Icon"];
                MemoryStream MemoryS = new MemoryStream(Byte);
                Imagen.Image = Image.FromStream(MemoryS);
                Imagen.Tag = DataR["Usuario"].ToString();
                Imagen.Cursor = Cursors.Hand;

                //Dibuja una texto con caracteristicas predefinidas
                Texto.Text = DataR["Usuario"].ToString();
                Texto.Name = DataR["IDUser"].ToString();
                Texto.Font = new Font("Yu Gothic UI", 20,FontStyle.Regular);
                Texto.BackColor = Color.White;
                Texto.ForeColor = Color.Black;
                Texto.Dock = DockStyle.Fill;
                Texto.TextAlign = ContentAlignment.MiddleCenter;

                //Coloca los Objetos en su respectivo lugar
                PanelLogin.Controls.Add(Texto);
                PanelLogin.Controls.Add(Imagen);
                FLPLoginUsers.Controls.Add(PanelLogin);

                //Evento Click
                Imagen.Click += new EventHandler(EventoPanel);

            }

            SQLConexion.Close();
        }

        //Centrar Objetos & Paneles
        private void Centrar(){
            //Alto & Ancho Form
            int Altura_Form = this.Height;
            int Ancho_Form = this.Width;
            //Alto & Ancho Panel
            int Altura_Panel = PLogin.Height;
            int Ancho_Panel = PLogin.Width;
            //Alto & Ancho Picture Box
            int Altura_PB = PBUser.Height;
            int Ancho_PB = PBUser.Width;

            //Alto & Ancho Panel Olvide Contra
            int Altura_PanelO = POlvide.Height;
            int Ancho_PanelO = POlvide.Width;
            //Alto & Ancho Botón Olvide Contra
            int Altura_Boton = BtnRecoverPass.Height;
            int Ancho_Boton = BtnRecoverPass.Width;

            //"Ecuación" Para centrar Panel
            int New_Altura = (Altura_Form - Altura_Panel) / 2;
            int New_Anchura = (Ancho_Form - Ancho_Panel) / 2;

            //"Ecuación" Para centrar Picture Box
            int New_AlturaPB = (Altura_Panel - Altura_PB) / 20;

            int New_AnchuraPB = (Ancho_Panel - Ancho_PB) / 2;

            //"Ecuación" Para centrar Botón
            int Boton_Altura = (Altura_PanelO - Altura_Boton) / 2;
            int Boton_Anchura = (Ancho_PanelO - Ancho_Boton) / 2;

            //Coloca la nueva Anchura & Altura
            PBUser.Location = new Point(New_AnchuraPB, New_AlturaPB);
            PLogin.Location = new Point(New_Anchura, New_Altura);
            BtnRecoverPass.Location = new Point(Boton_Anchura, Boton_Altura);
        }

        //Cuenta las columas de la tabla
        private void Contador(){
            int x;
            x = DGVUsuarios.Rows.Count;
            contador = x;
        }
        //Valida si la contraseña es correcta
        private void Sesion_Correcto(){
            Iniciar_Sesion();
            Contador();

            //Valida si la contraseña es correcta
            if (contador > 0){
                CerrarLogin();
            }

        }
        //Data Grid View 
        private void Iniciar_Sesion(){

            try{
                //Adaptador para Datos Tabla 
                DataTable DataT = new DataTable();
                SqlDataAdapter DataA;

                //Abrir Conexión
                SqlConnection SQLConexion = new SqlConnection();
                SQLConexion.ConnectionString = Conexion.ConexionMaestra.Conexion;
                SQLConexion.Open();

                //Abrir Procedimiento BUSCAR USUARIO
                DataA = new SqlDataAdapter("Validar_Usuario", SQLConexion);
                DataA.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataA.SelectCommand.Parameters.AddWithValue("@Password", TxtPasswordLogin.Text);
                DataA.SelectCommand.Parameters.AddWithValue("@Usuario", TxtUserLogin.Text);

                //Convertir Datos
                DataA.Fill(DataT);

                //Imprimir datos en la tabla
                DGVUsuarios.DataSource = DataT;

                //Cerrar Conexión
                SQLConexion.Close();
            }catch{

            }



        }
        //Cerrar paneles y abrir caja
        private void CerrarLogin(){
            this.Hide();

            Caja.Apertura_Caja A_Caja = new Caja.Apertura_Caja();
            A_Caja.Show();
        }
        //Mostrar Caja por Serial
        private void Show_SerialCaja(){
            try{
                //Adaptador para Datos Tabla 
                DataTable DataT = new DataTable();
                SqlDataAdapter DataA;

                //Abrir Conexión
                SqlConnection SQLConexion = new SqlConnection();
                SQLConexion.ConnectionString = Conexion.ConexionMaestra.Conexion;
                SQLConexion.Open();

                //Abrir Procedimiento BUSCAR USUARIO
                DataA = new SqlDataAdapter("Mostrar_Cajas_Serial", SQLConexion);
                DataA.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataA.SelectCommand.Parameters.AddWithValue("@Serial", LblSerial.Text);

                //Convertir Datos
                DataA.Fill(DataT);

                //Imprimir datos en la tabla
                DGVSerial.DataSource = DataT;

                //Cerrar Conexión
                SQLConexion.Close();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }

        }

        //Evento
        private void EventoPanel(Object sender, EventArgs e){
            PLogin.Visible = true;
            TxtUserLogin.Text = ((Guna.UI2.WinForms.Guna2ImageButton)sender).Tag.ToString();
            PBUser.Image = ((Guna.UI2.WinForms.Guna2ImageButton)sender).Image;
            TxtPasswordLogin.Select();

            //Ocultar Cosas
            BtnRecoverPass.Visible = false;
            FLPLoginUsers.Visible = false;
            txtTittle.Visible = false;
        }


        //Login Load
        private void Login_User_Load(object sender, EventArgs e){
            Draw_Users();
            Centrar();
            Timer.Start();
        }

        private void BtnChangeUser_Click(object sender, EventArgs e){
            TxtPasswordLogin.Text = "";
            PLogin.Visible = false;

            //Mostrar Cosas
            BtnRecoverPass.Visible = true;
            FLPLoginUsers.Visible = true;
            txtTittle.Visible = true;
        }

        private void BtnLogin_Click(object sender, EventArgs e){
            MessageBox.Show("Contraseña Incorrecta");
        }

        private void Login_User_SizeChanged(object sender, EventArgs e)
        {
            Centrar();
        }

        private void TxtPasswordLogin_TextChanged(object sender, EventArgs e)
        {
            Sesion_Correcto();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRecoverPass_Click(object sender, EventArgs e){
            RecoverPass Recover = new RecoverPass();
            Recover.Show();
        }

        private void Timer_Tick(object sender, EventArgs e){
            //Detiene el contador
            Timer.Stop();
            
            //Recoge el Serial Number 
            try{

                ManagementObjectSearcher ManaOS = new ManagementObjectSearcher("Select * From Win32_BaseBoard");
                    foreach (ManagementObject GetSerial in ManaOS.Get()){
                    LblSerial.Text = GetSerial.Properties["SerialNumber"].Value.ToString();
                    Show_SerialCaja();

                    try{

                    }catch(Exception ex){
                        MessageBox.Show(ex.Message);
                    }

                }

            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }

        }


    }
}
