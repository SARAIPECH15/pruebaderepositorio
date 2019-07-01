using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using ProyectoWebPageMaster.BO;

namespace ProyectoWebPageMaster.DAO
{
    public class CATEGORIA_DAO
    {
        Conexion objConectar = new Conexion();

        public DataSet buscar_Genero()
        {
            DataSet datos = objConectar.EjecutarSentencia("select * from GENERO");
            return datos;
        }
        public int AgregarCat(CATEGORIA_BO objAgregarCat)
        {
            //inserta y devuelve el ultimo el id insertado
            int id = objConectar.EjecutarComando
                ("INSERT INTO CATEGORIA (NOMBRE) output INSERTED.CODIGO_CAT values('"
                + objAgregarCat.NOMBRE1 + "')");
            return id;
        }
        public int Eliminar_Cat(CATEGORIA_BO objEliminarCat)
        {
            int id = objConectar.EjecutarComando(string.Format("delete from CATEGORIA where CODIGO_CAT={0}", objEliminarCat.CODIGO_CAT1));
            return 1;
        }
        public int ModificarCat(CATEGORIA_BO objModificarCat)
        {
            int id = objConectar.EjecutarComando(string.Format("update CATEGORIA set NOMBRE='{0}'", objModificarCat.NOMBRE1));
            return 1;

        }


    }
}