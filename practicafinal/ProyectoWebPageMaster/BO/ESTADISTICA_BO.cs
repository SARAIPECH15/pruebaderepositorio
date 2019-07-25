using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWebPageMaster.BO
{
	public class ESTADISTICA_BO
	{

		int[] Barras = new int[3];
		string[] nombs = new string[3];
		int grafic;
		public int[] Barras1 { get => Barras; set => Barras = value; }
		public string[] Nombs { get => nombs; set => nombs = value; }
		public int Grafic { get => grafic; set => grafic = value; }
	}
}