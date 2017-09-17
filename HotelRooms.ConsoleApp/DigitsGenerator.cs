using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRooms.ConsoleApp
{
    public class DigitsGenerator
    {

        int[] digits;

        public int[] GenerateDigitsCount(int numberRoomsReq)
        {
            digits = new int[10];

            //Generator divisor to the length of the number of rooms
            // i.e. if 55 then 10 
            // if 345 then 100
            int divisor =(int) Math.Pow(10, Math.Floor(Math.Log10(numberRoomsReq)));

            CountDigits(numberRoomsReq, numberRoomsReq, divisor);

            return digits;
        }

        private void CountDigits(int roomsReq, int numberRooms, int divisor)
        {
            if (numberRooms < 10) //for less than 10 rooms
            {
                IncreaseDigitCount(1, numberRooms, 1);
                numberRooms = 0;
            }
            else
            {
                int divisorMultiple = numberRooms / divisor;
                int divisorRemainder = numberRooms % divisor;


                if (divisorMultiple > 1) //if the out is multiple of divisor i.e. 555 then add 100 to 1-4
                {
                    IncreaseDigitCount(1, divisorMultiple - 1, divisor);
                }

                //For each multiple of 10 add result 
                //i.e. 215
                // then result is 2
                // divistor is 100 and Log is 2
                // multiplied by divisor/10 
                // 2 * 2 * 10 = 40 for 200
                IncreaseDigitCount(0, 9, divisorMultiple * (int)Math.Log10(divisor) * (divisor / 10));


                //because 1-9 does not contain zeros if the
                //number is greater than 100 i.e. 106 
                // then in the line above we have added 10 additional zoros
                // 101 - 106 should contains 6 zeros and delete additional 4 zeros
                if (roomsReq > 99 && divisorRemainder < 10 && divisor > 10)
                    IncreaseDigitCount(0, 0, -(9 - divisorRemainder));


                IncreaseDigitCount(divisorMultiple, divisorMultiple, divisorRemainder + 1);
                numberRooms -= (divisor * divisorMultiple);

                if(numberRooms > 0)
                    CountDigits(roomsReq, numberRooms, divisor /10);
            }
        }


        private void IncreaseDigitCount(int fromIndex, int toIndex, int increaseBy)
        {
            for (int i = fromIndex; i <= toIndex; i++)
                digits[i] += increaseBy;
        }

    }
}
