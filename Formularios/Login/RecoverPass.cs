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
using System.Net.Mail;
using System.Net;

namespace Punto_De_Venta_Andro.Formularios.Login
{
    public partial class RecoverPass : Form
    {
        public RecoverPass()
        {
            InitializeComponent();
        }

        //Extrae correos al Combo Box
        private void Recover_Correo()
        {

            try
            {
                //Adaptador para Datos Tabla 
                DataTable DataT = new DataTable();
                SqlDataAdapter DataA;

                //Abrir Conexión
                SqlConnection SQLConexion = new SqlConnection();
                SQLConexion.ConnectionString = Conexion.ConexionMaestra.Conexion;
                SQLConexion.Open();

                //Abrir Procedimiento BUSCAR USUARIO
                DataA = new SqlDataAdapter("Select Correo From Usuarios Where Estado='Activo'", SQLConexion);

                //Convertir Datos
                DataA.Fill(DataT);

                //Imprimir datos en el Combo Box
                CBCorreo.DisplayMember = "Correo";
                CBCorreo.ValueMember = "Correo";
                CBCorreo.DataSource = DataT;

                //Cerrar Conexión
                SQLConexion.Close();
            }
            catch
            {

            }



        }

        //Contraseña del correo
        private void Pass_Correo(){

            try{
                
                //Abrir Conexión
                SqlConnection SQLConexion = new SqlConnection();
                SQLConexion.ConnectionString = Conexion.ConexionMaestra.Conexion;
                SQLConexion.Open();

                //Abrir Procedimiento BUSCAR USUARIO
                SqlCommand DataA = new SqlCommand("Buscar_Correo_Usuario",SQLConexion);
                DataA.CommandType = CommandType.StoredProcedure;
                DataA.Parameters.AddWithValue("@Correo", CBCorreo.Text);

                //Imprimir datos en la tabla
                LblPass.Text = Convert.ToString(DataA.ExecuteScalar());

                //Cerrar Conexión
                SQLConexion.Close();
            }
            catch
            {

            }



        }

        //Enviar Correo
        internal void Send_Email(string Emisor, string Password, string Mensaje, string Asunto, string Receptor){
            try{
                MailMessage Correo = new MailMessage();
                SmtpClient Envio = new SmtpClient();

                Correo.Subject = Asunto;
                Correo.SubjectEncoding = Encoding.UTF8;

                Correo.Body = Mensaje;
                Correo.BodyEncoding = Encoding.UTF8;
                Correo.IsBodyHtml = true;

                Correo.To.Add((Receptor));
                Correo.From = new MailAddress(Emisor);

                Envio.Credentials = new NetworkCredential(Emisor, Password);

                Envio.Host = "smtp.gmail.com";
                Envio.Port = 587;
                Envio.EnableSsl = true;

                Envio.Send(Correo);
                MessageBox.Show("Contraseña enviada, Revise su correo electonico");
                this.Hide();

            }catch{
                MessageBox.Show("Error al enviar el correo");
            }
        }

        //Centra el panel
        private void Centrar()
        {
            //Alto & Ancho Form
            int Altura_Form = this.Height;
            int Ancho_Form = this.Width;
            //Alto & Ancho Panel
            int Altura_Panel = PBG.Height;
            int Ancho_Panel = PBG.Width;

            //"Ecuación" Para centrar Panel
            int New_Altura = (Altura_Form - Altura_Panel) / 2;
            int New_Anchura = (Ancho_Form - Ancho_Panel) / 2;

            //Coloca la nueva Anchura & Altura
            PBG.Location = new Point(New_Anchura, New_Altura);
        }

        //Form Load
        private void RecoverPass_Load(object sender, EventArgs e)
        {
            Recover_Correo();
            Centrar();
        }

        private void BtnClose_Click(object sender, EventArgs e){
            this.Close();
        }

        private void RecoverPass_SizeChanged(object sender, EventArgs e)
        {
            Centrar();
        }

        private void BtnSendCorreo_Click(object sender, EventArgs e){
            Pass_Correo();
            HTMLDoc.Text = HTMLDoc.Text.Replace("@Pass", LblPass.Text);
            Send_Email("antoniosmart1298@gmail.com", "Alexander1298%",HTMLDoc.Text, "Solicitud Contraseña", CBCorreo.Text);

        }

        private void BtnCloseA_Click(object sender, EventArgs e)
        {
            Application.Exit();        
        }

    }
}
