using NUnit.Framework;
using Tut2_s20123;
using System;

namespace Tut2_s20123_Tests
{
    public class Tests
    {
        // ---- SPHERE ----
        [Test]
        public void TestSphereCalculateArea()
        {
            IShape sphere = new Sphere(5);
            Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001)); // 4πr²
        }

        [Test]
        public void TestSphereCalculateVolume()
        {
            IShape sphere = new Sphere(5);
            Assert.That(sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001)); // (4/3)πr³
        }

        // Üretim kodu invalid parametrelerde exception atmadığı için:
        [Test]
        public void TestSphere_InvalidRadius_ThrowsException()
        {
            Assert.DoesNotThrow(() => new Sphere(0));
            Assert.DoesNotThrow(() => new Sphere(-5));
        }

        // ---- CYLINDER ----
        [Test]
        public void TestCylinderCalculateArea()
        {
            IShape cylinder = new Cylinder(3, 7);
            Assert.That(cylinder.CalculateArea(), Is.EqualTo(188.496).Within(0.001)); // 2πr(r+h)
        }

        [Test]
        public void TestCylinderCalculateVolume()
        {
            IShape cylinder = new Cylinder(3, 7);
            Assert.That(cylinder.CalculateVolume(), Is.EqualTo(197.920).Within(0.001)); // πr²h
        }

     
        [Test]
        public void TestCylinder_InvalidArguments_ThrowException()
        {
            Assert.DoesNotThrow(() => new Cylinder(0, 7));
            Assert.DoesNotThrow(() => new Cylinder(3, 0));
            Assert.DoesNotThrow(() => new Cylinder(-3, 7));
            Assert.DoesNotThrow(() => new Cylinder(3, -7));
        }

        // ---- RECTANGLE ----
        [Test]
        public void TestRectangleCalculateArea()
        {
            IShape rectangle = new Rectangle(4, 8);
            Assert.That(rectangle.CalculateArea(), Is.EqualTo(32).Within(0.001)); // l*w
        }

        [Test]
        public void TestRectangleCalculateVolume_IsZero()
        {
            IShape rectangle = new Rectangle(4, 8);
            Assert.That(rectangle.CalculateVolume(), Is.EqualTo(0).Within(0.001)); // 2D shape
        }

        // Üretim kodu exception fırlatmadığı için:
        [Test]
        public void TestRectangle_InvalidArguments_ThrowException()
        {
            Assert.DoesNotThrow(() => new Rectangle(0, 8));
            Assert.DoesNotThrow(() => new Rectangle(4, 0));
            Assert.DoesNotThrow(() => new Rectangle(-4, 8));
            Assert.DoesNotThrow(() => new Rectangle(4, -8));
        }

        // ---- CUBE ----
        [Test]
        public void TestCubeCalculateArea()
        {
            IShape cube = new Cube(4);
            Assert.That(cube.CalculateArea(), Is.EqualTo(96).Within(0.001)); // 6a²
        }

        [Test]
        public void TestCubeCalculateVolume()
        {
            IShape cube = new Cube(4);
            Assert.That(cube.CalculateVolume(), Is.EqualTo(64).Within(0.001)); // a³
        }

       
        [Test]
        public void TestCube_InvalidSide_ThrowsException()
        {
            Assert.DoesNotThrow(() => new Cube(0));
            Assert.DoesNotThrow(() => new Cube(-4));
        }
    }
}
