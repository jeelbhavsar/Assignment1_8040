using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleProject
{
    public class rectangle
    {
        private int Length; private int Width;
        private int Perimeter; private int Area; 
        public rectangle()
        {
            Length = 1;
            Width = 1;
            Perimeter = 1;
            Area = 1;
        }

        //public int SetLength(int Length)
        //{
        //    this.Length = Length;
        //    return this.Length;
        // }

        //public int SetWidth(int Width )
        //{
        //    this.Width = Width;
        //    return this.Width;
        //}

        public int GetLength()
        {
            return Length;
        }

        public int GetWidth()
        {
            return Width;
        }
        public int SetLength(int Length01)
        {
            Length = Length01;
            return Length;
        }

        public int SetWidth(int Width01)
        {
            Width = Width01;
            return Width;

        }
        public int SetPerimeter(int Perimeter01)
        {
            Perimeter = Perimeter01;
            return Perimeter;

        }
        public int SetArea(int Area01)
        {
            Area = Area01;
            return Area;

        }

        public int GetPerimeter()
        {
            int Perimeter = 2 * (Length + Width);
            Console.WriteLine(" ");
            return Perimeter;
        }

        public int GetArea()
        {
            int area = (Length * Width);
            Console.WriteLine(" ");
            return area;
        }
    }
}
