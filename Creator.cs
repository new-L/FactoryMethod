using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class Creator
    {
        //Абстрактный класс Creator определяет абстрактный фабричный метод FactoryMethod(), который возвращает объект Product.
        //За параметр у нас отвечает любая сторона фигуры, h - высота
        public IShape FactoryMethod(string shapeType, float parametr, float h)
        {
            switch (shapeType.ToLower()) {
                case "circle": return new Circle(parametr, shapeType);
                case "square": return new Square(parametr, shapeType);
                case "triangle": return new Triangle(parametr, h, shapeType);
            }

            return null;
        }
    }
}
