using System;

namespace Cone
{
    public class ConeSquare
    {
        public float r;
        public float h;
        public const double pi = 3.1415926535;

        //полная площадь конуса
        public float FullConeSquare(float r, float h)
        {
            //ищем образующую через теорему Пифогора.
            double l = Math.Sqrt(Math.Pow(r, 2) + Math.Pow(h, 2));

            //считаем площадь.
            double coneSquare = pi * r * (r + l);

            //возвращаем результат.
            return (float) coneSquare;
        }

        //площадь основания конуса
        public float BaseOfCone(float r)
        {
            //считаем площадь основания.
            double fullBaseOfCone = pi * (Math.Pow(r, 2));

            //возвращаем результат.
            return (float) fullBaseOfCone;
        }
    }
}
