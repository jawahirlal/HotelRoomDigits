using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using HotelRooms.ConsoleApp;

namespace HotelRooms.Tests
{
    [TestClass]
    public class HotelRoomsTests
    {
        DigitsGenerator digitsGenerator;
        public HotelRoomsTests()
        {
            digitsGenerator = new DigitsGenerator();
        }
 
        [TestMethod]
        public void Test_When_Passed_1_Should_Return_1()
        {
            //arrange
            var numberRooms = 1;
            var exptectedValues  = new  int [10] { 0,1,0,0,0,0,0,0,0,0 };

            checkValues(numberRooms,  exptectedValues);
        }


        [TestMethod]
        public void Test_When_Passed_2_Should_Return()
        {
            //arrange
            var numberRooms = 2;
            var exptectedValues = new int[10] { 0, 1, 1, 0, 0, 0, 0, 0, 0, 0 };

            checkValues(numberRooms, exptectedValues);
        }

        [TestMethod]
        public void Test_When_Passed_9_Should_Return()
        {
            //arrange
            var numberRooms = 9;
            var exptectedValues = new int[10] { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

            checkValues(numberRooms, exptectedValues);
        }

        [TestMethod]
        public void Test_When_Passed_15_Should_Return()
        {
            //arrange
            var numberRooms = 15;
            var exptectedValues = new int[10] { 1, 8, 2, 2, 2, 2, 1, 1, 1, 1 };

            checkValues(numberRooms, exptectedValues);
        }


        [TestMethod]
        public void Test_When_Passed_56_Should_Return()
        {
            //arrange
            var numberRooms = 56;
            var exptectedValues = new int[10] { 5, 16, 16, 16, 16, 13, 6, 5, 5, 5 };

            checkValues(numberRooms, exptectedValues);
        }


        [TestMethod]
        public void Test_When_Passed_99_Should_Return()
        {
            //arrange
            var numberRooms = 99;
            var exptectedValues = new int[10] { 9, 20, 20, 20, 20, 20, 20, 20, 20, 20 };

            checkValues(numberRooms, exptectedValues);
        }

        [TestMethod]
        public void Test_When_Passed_100_Should_Return()
        {
            //arrange
            var numberRooms = 100;
            var exptectedValues = new int[10] { 11, 21, 20, 20, 20, 20, 20, 20, 20, 20 };

            checkValues(numberRooms, exptectedValues);
        }


        [TestMethod]
        public void Test_When_Passed_101_Should_Return()
        {
            //arrange
            var numberRooms = 101;
            var exptectedValues = new int[10] { 12, 23, 20, 20, 20, 20, 20, 20, 20, 20 };

            checkValues(numberRooms, exptectedValues);
        }


        [TestMethod]
        public void Test_When_Passed_115_Should_Return()
        {
            //arrange
            var numberRooms = 115;
            var exptectedValues = new int[10] { 21, 44, 22, 22, 22, 22, 21, 21, 21, 21 };

            checkValues(numberRooms, exptectedValues);
        }


        [TestMethod]
        public void Test_When_Passed_120_Should_Return()
        {
            //arrange
            var numberRooms = 120;
            var exptectedValues = new int[10] { 22, 53, 23, 22, 22, 22, 22, 22, 22, 22 };

            checkValues(numberRooms, exptectedValues);
        }


        [TestMethod]
        public void Test_When_Passed_200_Should_Return()
        {
            //arrange
            var numberRooms = 200;
            var exptectedValues = new int[10] { 31, 140, 41, 40, 40, 40, 40, 40, 40, 40 };

            checkValues(numberRooms, exptectedValues);
        }

        [TestMethod]
        public void Test_When_Passed_205_Should_Return()
        {
            //arrange
            var numberRooms = 205;
            var exptectedValues = new int[10] { 36, 141, 47, 41, 41, 41, 40, 40, 40, 40 };

            checkValues(numberRooms, exptectedValues);
        }



        private void checkValues(int numberRooms, int[] exptectedValues)
        {
            //act
            var digits = digitsGenerator.GenerateDigitsCount(numberRooms);


            //assert
            Assert.IsTrue(digits.SequenceEqual(exptectedValues));
        }
    }
}

