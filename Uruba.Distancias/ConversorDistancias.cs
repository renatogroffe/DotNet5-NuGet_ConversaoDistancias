using System;

namespace Uruba.Distancias
{
    public static class ConversorDistancias
    {
        public static double MilhasParaKm(double milhas) =>
            Math.Round(Convert.ToDouble(milhas) * 1.609, 3);
    }
}
