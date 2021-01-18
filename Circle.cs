using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    //Конкретные классы представляют реализацию класса Product. Таких классов может быть множество
    #region Конкретные объекты
    class Circle : IShape
    {
        private string name;
        protected float r;

        public string Name { get => name; set => name = value; }

        public Circle(float r, string name)
        {
            this.r = r;
            this.name = name;
        }

        public virtual float GetArea()
        {
            return (float)(Math.PI * Math.Pow(r, 2));
        }
    }

    class Square : IShape
    {
        private string name;
        protected float a;

        public string Name { get => name; set => name = value; }
        public Square(float a, string name)
        {
            this.a = a;
            this.name = name;
        }

        public virtual float GetArea()
        {
            return (float)Math.Pow(a, 2);
        }
    }

    class Triangle : IShape
    {
        private string name;
        protected float b, h;//b - основание, h - высота

        public string Name { get => name; set => name = value; }
        public Triangle(float b, float h, string name)
        {
            this.b = b;
            this.h = h;
            this.name = name;
        }

        public virtual float GetArea()
        {
            return b * h * 0.5f;
        }
    }
    #endregion
}
