﻿using System.Globalization;
using System.Windows.Forms;

namespace Strategy.Imposto
{
    internal static class CalculadorDeImposto
    {
        internal static void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            var valor = imposto.Calcula(orcamento);
            MessageBox.Show($"Valor do imposto calculado: {valor.ToString(CultureInfo.InvariantCulture)}");
        }
    }
}