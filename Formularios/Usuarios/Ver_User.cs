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

namespace Punto_De_Venta_Andro
{
    public partial class Ver_User : Form
    {
        public Ver_User()
        {
            InitializeComponent();
        }

        //Metodos
        private void MostrarDatos(){
            
            try{
                //Adaptador para Datos Tabla 
                DataTable DataT = new DataTable();
                SqlDataAdapter DataA;

                //Abrir Conexión
                SqlConnection SQLConexion = new SqlConnection();
                SQLConexion.ConnectionString = Conexion.ConexionMaestra.Conexion;
                SQLConexion.Open();

                //Abrir Procedimiento MOSTRAR USUARIO
                DataA = new SqlDataAdapter("Mostrar_Usuario", SQLConexion);

                //Convertir Datos
                DataA.Fill(DataT);

                //Imprimir datos en la tabla
                DGVUsuarios.DataSource = DataT;

                //Cerrar Conexión
                SQLConexion.Close();

                //Ocultar Columnas
                DGVUsuarios.Columns[1].Visible = false;
                DGVUsuarios.Columns[5].Visible = false;
                DGVUsuarios.Columns[6].Visible = false;
                DGVUsuarios.Columns[7].Visible = false;
                DGVUsuarios.Columns[8].Visible = false;
            }catch{
                MessageBox.Show("Error al mostrar los datos en la tabla");
            }



        }

        private void BuscarDatos()
        {

            try{
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
                DataA.SelectCommand.Parameters.AddWithValue("@Letra",TxtSearchUser.Text);

                //Convertir Datos
                DataA.Fill(DataT);

                //Imprimir datos en la tabla
                DGVUsuarios.DataSource = DataT;

                //Cerrar Conexión
                SQLConexion.Close();

                //Ocultar Columnas
                DGVUsuarios.Columns[1].Visible = false;
                DGVUsuarios.Columns[5].Visible = false;
                DGVUsuarios.Columns[6].Visible = false;
                DGVUsuarios.Columns[7].Visible = false;
                DGVUsuarios.Columns[8].Visible = false;
            }catch{
                MessageBox.Show("Error al mostrar los datos en la tabla");
            }



        }


        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            //Objeto para Add User
            Formularios.Usuarios.Add_Edit_User AddUser = new Formularios.Usuarios.Add_Edit_User();
            AddUser.Show();

            //Ocultar Botón Modificar
            AddUser.BtnModificarUser.Visible = false;
        }

        //Load Form Principal
        private void Ver_User_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            TimerReloadUsers.Start();
            TxtSearchUser.Select();
        }

        //Data Grid View
        private void DGVUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e){
            //Objeto ventana datos
            Formularios.Usuarios.Add_Edit_User AddUser = new Formularios.Usuarios.Add_Edit_User();

            AddUser.BtnGuardarUser.Visible = false;
            AddUser.BtnModificarUser.Visible = true;

            //Extrae los datos de la tabla
            AddUser.txtID.Text = DGVUsuarios.SelectedCells[1].Value.ToString();
            AddUser.txtNameUser.Text = DGVUsuarios.SelectedCells[2].Value.ToString();
            AddUser.txtUser.Text = DGVUsuarios.SelectedCells[3].Value.ToString();
            AddUser.TxtPasswordUser.Text = DGVUsuarios.SelectedCells[4].Value.ToString();

            //Extrae la imagen y la convierte en bytes
            AddUser.BtnAddImageUser.BackgroundImage = null;
            byte[] b = (Byte[])DGVUsuarios.SelectedCells[5].Value;
            System.IO.MemoryStream MemoryS = new System.IO.MemoryStream(b);
            AddUser.BtnAddImageUser.Image = Image.FromStream(MemoryS);

            AddUser.txtNameIcon.Text = DGVUsuarios.SelectedCells[6].Value.ToString();
            AddUser.txtCorreoUser.Text = DGVUsuarios.SelectedCells[7].Value.ToString();
            AddUser.CBRolUser.Text = DGVUsuarios.SelectedCells[8].Value.ToString();

            //Mostrar panel añadir usuarios
            AddUser.Show();
        }

        private void DGVUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.DGVUsuarios.Columns["Eliminar"].Index){
                //Objeto ventana datos
                Formularios.Usuarios.Delete_User DeleteUser = new Formularios.Usuarios.Delete_User();

                //Extrae los datos de la tabla
                DeleteUser.IDUserEliminate.Text = DGVUsuarios.SelectedCells[1].Value.ToString();
                DeleteUser.txtNameEliminate.Text = "Nombre: " + DGVUsuarios.SelectedCells[2].Value.ToString();
                DeleteUser.txtUserEliminate.Text = "Usuario: " + DGVUsuarios.SelectedCells[3].Value.ToString();

                //Extrae la imagen y la convierte en bytes
                DeleteUser.PBEliminate.BackgroundImage = null;
                byte[] b = (Byte[])DGVUsuarios.SelectedCells[5].Value;
                System.IO.MemoryStream MemoryS = new System.IO.MemoryStream(b);
                DeleteUser.PBEliminate.Image = Image.FromStream(MemoryS);

                DeleteUser.txtRolEliminate.Text = "Rol: " + DGVUsuarios.SelectedCells[8].Value.ToString();

                //Mostrar panel añadir usuarios
                DeleteUser.Show();
            }
        }

        //Timer Buscar Datos
        private void TimerReloadUsers_Tick(object sender, EventArgs e)
        {
            BuscarDatos();
        }

        private void TxtSearchUser_TextChanged(object sender, EventArgs e)
        {
            BuscarDatos();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Formularios.Login.Login_User Login = new Formularios.Login.Login_User();
            Login.Show();
            this.Close();
        }
    }


}
