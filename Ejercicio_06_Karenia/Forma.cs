using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06_Karenia
{
    class Forma
    {
        string nom;
        double area;
        double perimetro;
        public Forma() { }
        public Forma(string nom, double area, double perimetro)
        {
            this.nom = nom;
            this.area = area;
            this.perimetro = perimetro;
        }

        public string Nom { get => nom; set => nom = value; }
        public double Area { get => area; set => area = value; }
        public double Perimetro { get => perimetro; set => perimetro = value; }

        public virtual double CalArea()
        {
            return this.Area;
        }
        public virtual double CalPerimetro()
        {
            return this.Perimetro;
        }
        public override string ToString()
        {
            return "\nNombre: " + this.Nom + " \nArea: " + CalArea() + "\nPerimetro: " + CalPerimetro();
        }
    }
    class Rectangulo : Forma
    {
        double ld1;
        double ld2;

        public Rectangulo(string nom, double ld1, double ld2)
        {
            this.ld1 = ld1;
            this.ld2 = ld2;
            this.Nom = nom;
        }

        public double Ld1 { get => ld1; set => ld1 = value; }
        public double Ld2 { get => ld2; set => ld2 = value; }
        public override double CalArea()
        {
            this.Area = this.ld1 * this.ld2;
            return base.CalArea();
        }
        public override double CalPerimetro()
        {
            this.Perimetro = 2 * (this.ld1 + this.ld2);
            return base.CalPerimetro();
        }
    }
    class Circulo : Forma
    {
        double radio;
        public Circulo(string nom, double radio)
        {
            this.Radio = radio;
            this.Nom = nom;
        }
        public double Radio { get => radio; set => radio = value; }
        public override double CalArea()
        {
            this.Area = Math.PI * this.Radio;
            return base.CalArea();
        }
        public override double CalPerimetro()
        {
            this.Perimetro = 2 * Math.PI * this.Radio;
            return base.CalPerimetro();
        }
    }
}
