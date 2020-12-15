using System;
using Unit_Test_Activity;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Convert_To_C_When_Input_Is_32F_Expect_0C()
        {
            //Arrange:

            var sup = new UnitTestExamples();


            //Act:
            var expected = 0;

            var actual = sup.ConvertToOppositeType(32, "f");


            //Assert:

            Assert.Equal(expected, actual);

        }


        [Fact]
        public void Convert_To_C_When_Input_Is_68F_Expect_20C()
        {
            //Arrange:

            var sup = new UnitTestExamples();


            //Act:
            var expected = 20;

            var actual = sup.ConvertToOppositeType(68, "f");


            //Assert:

            Assert.Equal(expected, actual);

        }


        [Fact]
        public void Convert_To_F_When_Input_Is_100C_Expect_212F()
        {
            //Arrange:

            var sup = new UnitTestExamples();


            //Act:
            var expected = 212;

            var actual = sup.ConvertToOppositeType(100, "c");


            //Assert:

            Assert.Equal(expected, actual);

        }



        [Fact]
        public void Convert_To_F_When_Input_Is_Negative40C_Expect_Negative40F()
        {
            //Arrange:

            var sup = new UnitTestExamples();


            //Act:
            var expected = -40;

            var actual = sup.ConvertToOppositeType(-40, "c");


            //Assert:

            Assert.Equal(expected, actual);

        }


        [Fact]
        public void Print_Output_When_Input_Is_43_Expect_Fizz()
        {
            //Arrange:

            var sup = new UnitTestExamples();


            //Act:
            var expected = "Fizz";

            var actual = sup.FizzBuzzBaz(43);


            //Assert:

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Print_Output_When_Input_Is_6_Expect_Fizz()
        {
            //Arrange:

            var sup = new UnitTestExamples();


            //Act:
            var expected = "Fizz";

            var actual = sup.FizzBuzzBaz(6);


            //Assert:

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Print_Output_When_Input_Is_5_Expect_Buzz()
        {
            //Arrange:

            var sup = new UnitTestExamples();


            //Act:
            var expected = "Buzz";

            var actual = sup.FizzBuzzBaz(5);


            //Assert:

            Assert.Equal(expected, actual);

        }


        [Fact]
        public void Print_Output_When_Input_Is_7_Expect_Baz()
        {
            //Arrange:

            var sup = new UnitTestExamples();


            //Act:
            var expected = "Baz";

            var actual = sup.FizzBuzzBaz(7);


            //Assert:

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Print_Output_When_Input_Is_14_Expect_Baz()
        {
            //Arrange:

            var sup = new UnitTestExamples();


            //Act:
            var expected = "Baz";

            var actual = sup.FizzBuzzBaz(14);


            //Assert:

            Assert.Equal(expected, actual);

        }


        [Fact]
        public void Print_Output_When_Input_Is_15_Expect_Baz()
        {
            //Arrange:

            var sup = new UnitTestExamples();


            //Act:
            var expected = "FizzBuzz";

            var actual = sup.FizzBuzzBaz(15);


            //Assert:

            Assert.Equal(expected, actual);

        }
    }
}

