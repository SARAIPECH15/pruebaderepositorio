using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoWebPageMaster.BO;
using ProyectoWebPageMaster.DAO;
using System.Data;

namespace ProyectoWebPageMaster.DAO
{
    public class Class1
    {
        Conexion objConectar = new Conexion();

        public DataSet selecciondegenero(GENERO_BO objGen)
        {
            string sen = "Select HISTORIA.NOMBRE,HISTORIA.FOTO,HISTORIA.PROLOGO,GENERO.CODIGO_GEN,HISTORIA.CODIG_HIS from GENERO INNER JOIN historia_genero ON GENERO.CODIGO_GEN=historia_genero.CODIGO_GEN  INNER JOIN HISTORIA ON historia_genero.CODIG_HIS=HISTORIA.CODIG_HIS INNER JOIN ESTATUS ON HISTORIA.CODIGO_EST=ESTATUS.CODIGO_EST WHERE GENERO.CODIGO_GEN= '"+ objGen.CODIGO_GEN1 +"' AND ESTATUS.CODIGO_EST=1";
            return objConectar.EjecutarSentencia (sen);         
        }

        public DataSet datos_gen()
        {
            string sen="select * from GENERO";
            return objConectar.EjecutarSentencia(sen);

        }
    }
}