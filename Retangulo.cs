using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1WF
{
    internal class Retangulo
    {
        private double baseRetangulo;
        private double alturaRetangulo;
 
        public Retangulo(double baseRetangulo, double alturaRetangulo)
        {
            this.baseRetangulo = baseRetangulo;
            this.alturaRetangulo = alturaRetangulo;
        }

        public Retangulo()
        {
            this.baseRetangulo = 0;
            this.alturaRetangulo = 0;
        }

        public void setBase(double baseRetangulo)
        {
            this.baseRetangulo = baseRetangulo;
        }
        public void setAltura(double alturaRetangulo)
        {
            this.alturaRetangulo = alturaRetangulo;
        }

        public double getBase()
        {
            return this.baseRetangulo;
        }
        public double getAltura()
        {
            return this.alturaRetangulo;
        }

        public double CalcularArea()
        {
            return baseRetangulo * alturaRetangulo;
        }
    }
}
