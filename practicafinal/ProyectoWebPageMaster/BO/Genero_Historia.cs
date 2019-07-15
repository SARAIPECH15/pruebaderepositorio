using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWebPageMaster.BO
{
    public class Genero_Historia
    {

        private int codigo_genero;
        private int codigo_historia;

        public int Codigo_genero { get => codigo_genero; set => codigo_genero = value; }
        public int Codigo_historia { get => codigo_historia; set => codigo_historia = value; }
    }
}