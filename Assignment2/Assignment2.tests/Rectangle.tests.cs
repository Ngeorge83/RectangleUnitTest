using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Assignment2.tests
{
    namespace Assignment2.tests
    {
        [TestFixture]
        class RectangleTests
        {
            public class GetLengthTests
            {
                [Test]

                public void GetLength()
                {
                    Rectangle r = new Rectangle();
                    int expected_length = 1;
                    int actual_length = r.GetLength();
                    Assert.AreEqual(expected_length, actual_length);
                }

            }

            public class ChangeLengthTests
            {
                [Test]

                public void ChangeLength()
                {
                    Rectangle r = new Rectangle();
                    int expected_length = 5;
                    r.ChangeLength(5);
                    int actual_length = r.GetLength();
                    Assert.AreEqual(expected_length, actual_length);
                }

            }

            public class GetWidthTests
            {
                [Test]

                public void GetWidth()
                {
                    Rectangle r = new Rectangle();
                    int expected_width = 1;
                    int actual_width = r.GetWidth();
                    Assert.AreEqual(expected_width, actual_width);
                }

            }

            public class ChangeWidthTests
            {
                [Test]

                public void ChangeWidth()
                {
                    Rectangle r = new Rectangle();
                    int expected_width = 5;
                    r.ChangeWidth(5);
                    int actual_length = r.GetLength();
                    Assert.AreEqual(expected_width, actual_length);
                }

            }

            public class GetPerimeterTests
            {
                [Test]

                public void GetPerimeter()
                {
                    Rectangle r = new Rectangle();
                    int expected_perimeter = 4;
                    int actual_perimeter = r.GetPerimiter();
                    Assert.AreEqual(expected_perimeter, actual_perimeter);
                }

            }

            public class GetAreaTests
            {
                [Test]

                public void GetArea()
                {
                    Rectangle r = new Rectangle();
                    int expected_perimeter = 10;
                    int actual_perimeter = r.GetArea();
                    Assert.AreEqual(expected_perimeter, actual_perimeter);
                }

            }
        }
    }

}
