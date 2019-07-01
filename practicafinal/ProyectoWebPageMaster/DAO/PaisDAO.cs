using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoWebPageMaster.BO;
using System.Data;
using ProyectoWebPageMaster.DAO;
using System.Data.SqlClient;

namespace ProyectoWebPageMaster.DAO
{
    public class PaisDAO
    {

        Conexion objConectar = new Conexion();


        public DataSet buscar_usuarios()
        {
            DataSet datos = objConectar.EjecutarSentencia("select * from PAIS");
            return datos;

        }

        public int agregarusuario(pais_BO objusuario)
        {
            //inserta y devuelve el ultimo el id insertado
            int id = objConectar.EjecutarComando("INSERT INTO PAIS (NOMBRE) values('" + objusuario.Nombre + "')");
            return id;

        }

        public DataSet Consultar(string strSQL)
        {
            objConectar.establecerConexion();
            objConectar.abrirConexion();
            SqlCommand cmd = new SqlCommand(strSQL,objConectar.establecerConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            objConectar.cerrarConexion();
            return ds;

        }


        public int modificarpais(pais_BO objusuario)
        {
            int id = objConectar.EjecutarComando(string.Format("update PAIS set nombre='{0}' where COD_PAIS={1}", objusuario.Nombre, objusuario.Cod_pais));
            return 1;
        }

        public int eliminarpais(pais_BO objusuario)
        {
            int id = objConectar.EjecutarComando(string.Format("delete from PAIS where COD_PAIS={0}", objusuario.Cod_pais));
            return 1;
        }



    }
}