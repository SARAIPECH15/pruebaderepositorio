using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using ProyectoWebPageMaster.BO;

namespace ProyectoWebPageMaster.DAO
{
    public class GENERO_DAO
    {
        Conexion objConectar = new Conexion();

        public DataSet buscar_Genero()
        {
            DataSet datos = objConectar.EjecutarSentencia("select * from GENERO");
            return datos;
        }
        public int AgregarGen(GENERO_BO objAgregarGen)
        {
            //inserta y devuelve el ultimo el id insertado
            int id = objConectar.EjecutarComando
                ("INSERT INTO GENERO (NOMBRE) output INSERTED.CODIGO_GEN values('"
                + objAgregarGen.NOMBRE1 + "')" );
            return id;
        }
        public int Eliminar_Gen(GENERO_BO objEliminarGen)
        {
            int id = objConectar.EjecutarComando(string.Format("delete from GENERO where CODIGO_GEN={0}", objEliminarGen.CODIGO_GEN1));
            return 1;
        }
        public int ModificarGen(GENERO_BO objModificarGen)
        {
            int id = objConectar.EjecutarComando(string.Format("update GENERO set NOMBRE='{0}'", objModificarGen.NOMBRE1));
            return 1;

        }
    }
}