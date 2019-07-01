using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoWebPageMaster.BO;
using ProyectoWebPageMaster.DAO;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoWebPageMaster.DAO
{
    public class estadosDAO
    {


        Conexion objConectar = new Conexion();


        public DataSet buscar_estados()
        {
            DataSet datos = objConectar.EjecutarSentencia("select * from CIUDAD");
            return datos;

        }

        public int agregarCIUDAD(estadosBO objusuario)
        {
            //inserta y devuelve el ultimo el id insertado
            int id = objConectar.EjecutarComando("INSERT INTO CIUDAD (NOMBRE,COD_PAIS) output INSERTED.COD_CIU values('" + objusuario.Nombre + "','"+objusuario.COD_PAIS1 +"')");
            return id;

        }


        public DataSet Consultar(string strSQL)
        {
            objConectar.establecerConexion();
            objConectar.abrirConexion();
            SqlCommand cmd = new SqlCommand(strSQL, objConectar.establecerConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            objConectar.cerrarConexion();
            return ds;

        }

        public int modificarestado(estadosBO objusuario)
        {
            int id = objConectar.EjecutarComando(string.Format("update CIUDAD set NOMBRE='{0}',COD_PAIS={1} where COD_CIU={2}", objusuario.Nombre,objusuario.COD_PAIS1 ,objusuario.Cod_estado));
            return 1;
        }

        public int eliminarestado(estadosBO objusuario)
        {
            int id = objConectar.EjecutarComando(string.Format("delete from CIUDAD where COD_CIU={0}", objusuario.Cod_estado));
            return 1;
        }







    }
}