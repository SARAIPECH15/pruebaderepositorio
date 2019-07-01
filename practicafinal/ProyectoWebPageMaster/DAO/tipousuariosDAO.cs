using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using ProyectoWebPageMaster.BO;



namespace ProyectoWebPageMaster.DAO
{
    public class tipousuariosDAO
    {


        Conexion objConectar = new Conexion();


        public DataSet buscar_tipousuarios()
        {
            DataSet datos = objConectar.EjecutarSentencia("select * from TIPOUSUARIO");
            return datos;

        }

        public int agregatiporusuario(tipousuariosBO objusuario)
        {
            //inserta y devuelve el ultimo el id insertado
            int id = objConectar.EjecutarComando("INSERT INTO TIPOUSUARIO (NOMBRE) output INSERTED.ID_TIPOUSUARIO values('" + objusuario.Nombre + "')");
            return id;

        }



        public int modificartipousuario(tipousuariosBO objusuario)
        {
            int id = objConectar.EjecutarComando(string.Format("update TIPOUSUARIO set NOMBRE='{0}' where ID_TIPOUSUARIO={1}", objusuario.Nombre, objusuario.Id_tipousuario));
            return 1;
        }

        public int eliminartipousuario(tipousuariosBO objusuario)
        {
            int id = objConectar.EjecutarComando(string.Format("delete from TIPOUSUARIO where ID_TIPOUSUARIO={0}", objusuario.Id_tipousuario));
            return 1;
        }








    }
}