using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraMatrices.WcfOperaciones.Dominio.Acciones
{
    public class Transponer
    {
        public double[,] Transpuesta(double[,] laMatriz) {
            double[,] elresultado = { { 1,2}, { 3.4,2} };
            return elresultado;
        }
    }
}