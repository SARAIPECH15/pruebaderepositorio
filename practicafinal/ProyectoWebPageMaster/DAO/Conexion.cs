using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoWebPageMaster.DAO
{
    public class Conexion
    {

        SqlCommand ComandoSQL; //crea una variable tipo SqlCommand para transacciones sql
        SqlDataAdapter adaptador; //crea una variable sqlDataAdapter para un conjunto de datos y una conexión a una bd que se usan para rellenar DataSet y actualizar una base de datos de SQL Server
        DataSet DataSetAdaptador; //representa un conjunto completo de datos, incluyendo las tablas que contienen, ordenan y restringen los datos
        SqlConnection con; //para abrir conexion a bd sqlserver

        public SqlConnection establecerConexion()
        {
            //datos para la conexión usuario, bd, etc.
            string cs = "Data Source=ANDREA-TURRIZA\\SQLEXPRESS;Initial Catalog=PROYECTOFINAL;Integrated Security=True";
            con = new SqlConnection(cs); //instancia el objeto para la conexion a la bd
            return con; //el objeto
        }

        //sobrecarga del método
        public SqlConnection establecerConexion(string conexionString)
        {
            string cs = conexionString;
            con = new SqlConnection(cs); //instancia el objeto para la conexion a la bd
            return con; //regresa el objeto
        }
        public void abrirConexion()
        {
            con.Open();
        }
        public void cerrarConexion()
        {
            con.Close();
        }
        public int EjecutarComando(string Comando)
        {

            // INSERT, DELETE, UPDATE
            String strComandoSQL = Comando;

            adaptador = new SqlDataAdapter(); //crea la instancia de SqlDataAdapter
            ComandoSQL = new SqlCommand(); //crea instancia de SqlCommand
            ComandoSQL.Connection = this.establecerConexion(); //crea un objeto de conexion
            this.abrirConexion(); //abre la conexion
            ComandoSQL.CommandText = strComandoSQL; //establece una instrucción SQL que se va a ejecutar
            int id = Convert.ToInt32(ComandoSQL.ExecuteScalar()); //ejecuta instrucción sql

            this.cerrarConexion(); //cierra conexion
            return id;
        }
        public DataSet EjecutarSentencia(string Sentencia)
        {
            // SELECT
            ComandoSQL = new SqlCommand();
            adaptador = new SqlDataAdapter();
            ComandoSQL = new SqlCommand();
            DataSetAdaptador = new DataSet();


            String strComandoSQL = Sentencia;
            ComandoSQL.CommandText = strComandoSQL;

            ComandoSQL.Connection = this.establecerConexion();
            this.abrirConexion();

            adaptador.SelectCommand = ComandoSQL;
            adaptador.Fill(DataSetAdaptador);
            return DataSetAdaptador;


        }









    }
}