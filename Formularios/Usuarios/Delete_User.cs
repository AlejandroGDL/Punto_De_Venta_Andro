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

namespace Punto_De_Venta_Andro.Formularios.Usuarios
{
    public partial class Delete_User : Form
    {
        public Delete_User()
        {
            InitializeComponent();
        }

        //Metodos
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
            }catch{
                MessageBox.Show("Error al mostrar los datos en la tabla");
            }



        }


        private void BtnCancelEliminate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEliminate_Click(object sender, EventArgs e)
        {      

            try{
                SqlConnection SQLConexion = new SqlConnection();
                SQLConexion.ConnectionString = Conexion.ConexionMaestra.Conexion;
                SQLConexion.Open();

                //Abrir Procedimiento ELIMINAR USUARIO
                SqlCommand Procedimiento = new SqlCommand();
                Procedimiento = new SqlCommand("Eliminar_Usuario", SQLConexion);
                Procedimiento.CommandType = CommandType.StoredProcedure;

                //Extrae datos
                Procedimiento.Parameters.AddWithValue("@IDUser", IDUserEliminate.Text);
                Procedimiento.Parameters.AddWithValue("@Usuario", txtUserEliminate.Text);
                Procedimiento.ExecuteNonQuery();
                SQLConexion.Close();

                //Reload Data Grid View
                BuscarDatos();

                //Cerrar Form
                this.Close();

            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }

        }


    }
}
