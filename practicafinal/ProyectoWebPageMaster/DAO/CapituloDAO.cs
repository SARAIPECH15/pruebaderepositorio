using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoWebPageMaster.BO;
using System.Data;

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


        public void busca_capitulo(CapituloBO objbo)
        {
            string sen = "select * from CAPITULO where CODIGO_CAP=" + objbo.Codigo_cap + " AND CODIG_HIS=" + objbo.Codig_his;
            DataSet datos = objConectar.EjecutarSentencia(sen);
            objbo.Contenido = datos.Tables[0].Rows[0]["CONTENIDO"].ToString();
            objbo.Nombre = datos.Tables[0].Rows[0]["NOMBRE"].ToString();
            objbo.Numero = Convert.ToInt32(datos.Tables[0].Rows[0]["NUMERO"].ToString());
           
            // return datos;
        }






    }
}