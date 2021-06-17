using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
        public class Rectangle
        {
            private int length;
            private int width;

            public Rectangle()
            {
                this.length = 1;
                this.width = 1;
            }

            public Rectangle(int length, int width)
            {
                this.length = length;
                this.width = width;
            }

            public int GetLength()
            {
                return this.length;
            }

            public void ChangeLength(int newLength)
            {
                this.length = newLength;
            }

            public int GetWidth()
            {
                return this.width;
            }

            public void ChangeWidth(int newWidth)
            {
                this.width = newWidth;
            }

            public int GetPerimiter()
            {
                return 2 * (this.length + this.width);
            }

            public int GetArea()
            {
                return this.length * this.width;
            }

        }
    
