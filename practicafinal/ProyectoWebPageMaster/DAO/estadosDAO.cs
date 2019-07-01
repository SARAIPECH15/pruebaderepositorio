using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoWebPageMaster.BO;
using ProyectoWebPageMaster.DAO;
using System.Data;

namespace ProyectoWebPageMaster.DAO
{
    public class estadosDAO
    {


        Conexion objConectar = new Conexion();


        public DataSet buscar_usuarios()
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





    }
}