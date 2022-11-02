using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Fact]
        public void testIfFoo()
        {
            int a = 9;
            string expected = "Foo";
            FooBarQixDeterminer fooBarQixDeterminer = new FooBarQixDeterminer();

            // Act
            string actual = fooBarQixDeterminer.Determine(a);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testIfBar()
        {
            int a = 10;
            string expected = "Bar";
            FooBarQixDeterminer fooBarQixDeterminer = new FooBarQixDeterminer();

            // Act
            string actual = fooBarQixDeterminer.Determine(a);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testIfQix()
        {
            int a = 14;
            string expected = "Qix";
            FooBarQixDeterminer fooBarQixDeterminer = new FooBarQixDeterminer();

            // Act
            string actual = fooBarQixDeterminer.Determine(a);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testIfFooBar()
        {
            int a = 15;
            string expected = "FooBar";
            FooBarQixDeterminer fooBarQixDeterminer = new FooBarQixDeterminer();

            // Act
            string actual = fooBarQixDeterminer.Determine(a);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testIfFooQix()
        {
            int a = 21;
            string expected = "FooQix";
            FooBarQixDeterminer fooBarQixDeterminer = new FooBarQixDeterminer();

            // Act
            string actual = fooBarQixDeterminer.Determine(a);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testIfBarQix()
        {
            int a = 35;
            string expected = "BarQix";
            FooBarQixDeterminer fooBarQixDeterminer = new FooBarQixDeterminer();

            // Act
            string actual = fooBarQixDeterminer.Determine(a);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testIfFooBarQix()
        {
            int a = 105;
            string expected = "FooBarQix";
            FooBarQixDeterminer fooBarQixDeterminer = new FooBarQixDeterminer();

            // Act
            string actual = fooBarQixDeterminer.Determine(a);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}