using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoWebPageMaster.BO;

namespace ProyectoWebPageMaster.DAO
{
    public class CapituloDAO
    {



        Conexion objConectar = new Conexion();

        public int agregarCapitulo(CapituloBO objcapitulo)
        {
            //inserta y devuelve el ultimo el id insertado
            int id = objConectar.EjecutarComando("INSERT INTO CAPITULO (CODIG_HIS,FECHA_RZO,NOMBRE,NUMERO,CODIGO_EST,CONTENIDO) output INSERTED.CODIGO_CAP values('" + objcapitulo.Codig_his + "',GETDATE(),'" + objcapitulo.Nombre + "','" + objcapitulo.Numero + "',1,'" + objcapitulo.Contenido + "')");
            return id;

        }






    }
}