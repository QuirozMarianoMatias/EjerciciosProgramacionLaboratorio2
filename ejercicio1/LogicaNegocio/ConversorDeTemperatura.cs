using System;

namespace LogicaNegocio
{
    public class ConversorDeTemperatura
    {
        private const float ceroAbsoluto = 273.15f;
        public static float ConversorDeCelsiusAKelvin(float temperaturaCelsius)
        {


            return temperaturaCelsius + ceroAbsoluto ;
        }

        public static float ConversorDeKelvinACelsius(float temperaturaKelvin)
        {


            return temperaturaKelvin - ceroAbsoluto;
        }


    }
}
