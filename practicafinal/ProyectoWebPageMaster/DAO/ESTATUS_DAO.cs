using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using ProyectoWebPageMaster.BO;

namespace ProyectoWebPageMaster.DAO
{

    public class ESTATUS_DAO
    {
        Conexion objConectar = new Conexion();
        public DataSet buscar_Estatus()
        {
            DataSet datos = objConectar.EjecutarSentencia("select * from ESTATUS");
            return datos;
        }
        public int AgregarEST(ESTATUS_BO objAgregarEST)
        {
            //inserta y devuelve el ultimo el id insertado
            int id = objConectar.EjecutarComando
                ("INSERT INTO ESTATUS (NOMBRE) output INSERTED.CODIGO_EST values('"
                + objAgregarEST.NOMBRE1 + "')");
            return id;
        }
        public int Eliminar_EST(ESTATUS_BO objEliminarEST)
        {
            int id = objConectar.EjecutarComando(string.Format("delete from ESTATUS where CODIGO_EST={0}", objEliminarEST.CODIGO_EST1));
            return 1;
        }
        public int ModificarCat(ESTATUS_BO objModificarEST)
        {
            int id = objConectar.EjecutarComando(string.Format("update ESTATUS set NOMBRE='{0}' where CODIGO_EST={1}", objModificarEST.NOMBRE1, objModificarEST.CODIGO_EST1));
            return 1;

        }


    }
}