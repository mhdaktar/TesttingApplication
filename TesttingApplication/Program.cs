using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesttingApplication
{
    class Program
    {
        int indexOfInputArr = 0;
        static void Main(string[] args)
        {
            // accept input seatno. 
            int InputSeatno = 0;

            // seat arranagemnt in train. 

            int[] seat1 = new int[3] { 1, 2, 3 };
            int[] seat_1 = new int[3] { 12, 11, 10 };

            int[] seat2 = new int[3] { 7, 8, 9 };
            int[] seat_2 = new int[3] { 6, 5, 4 };

            int[] seat3 = new int[3] { 18, 17, 16 };
            int[] seat_3 = new int[3] { 19, 20, 21 };

            int[] seat4 = new int[3] { 13, 14, 15 };
            int[] seat_4 = new int[3] { 24, 23, 22 };

            int[] seat5 = new int[3] { 30, 29, 28 };
            int[] seat_5 = new int[3] { 31, 32, 33 };

            int[] seat6 = new int[3] { 25, 26, 27 };
            int[] seat_6 = new int[3] { 36, 35, 34 };

            int[] seat7 = new int[3] { 42, 41, 40 };
            int[] seat_7 = new int[3] { 43, 44, 45 };

            int[] seat8 = new int[3] { 37, 38, 39 };
            int[] seat_8 = new int[3] { 48, 47, 46 };

            int[] seat9 = new int[3] { 54, 53, 52 };
            int[] seat_9 = new int[3] { 55, 56, 57 };

            int[] seat10 = new int[3] { 49, 50, 51 };
            int[] seat_10 = new int[3] { 60, 59, 58 };

            int[] seat13 = new int[3] { 66, 65, 64 };
            int[] seat_13 = new int[3] { 67, 68, 69 };

        

            int[] seat12 = new int[3] { 61, 62, 63 };
            int[] seat_12 = new int[3] { 72, 71, 70 };



        

            int[] seat14 = new int[3] { 78, 77, 76 };
            int[] seat_14 = new int[3] { 79, 80, 81 };


            int[] seat15 = new int[3] { 73, 74, 75 };
            int[] seat_15 = new int[3] { 84, 83, 82 };

            int[] seat16 = new int[3] { 90, 89, 88 };
            int[] seat_16 = new int[3] { 91, 92, 93 };

            int[] seat17 = new int[3] { 85, 86, 87 };
            int[] seat_17 = new int[3] { 96, 95, 94 };

            int[] seat18 = new int[3] { 102, 101, 100 };
            int[] seat_18 = new int[3] { 103, 104, 105 };

            int[] seat19 = new int[3] { 97, 98, 99 };
            int[] seat_19 = new int[3] { 108, 107, 106 };


            int[][] row1 = new int[][] { seat1, seat_1 };
            int[][] row2 = new int[][] { seat2, seat_2 };
            int[][] row3 = new int[][] { seat3, seat_3 };
            int[][] row4 = new int[][] { seat4, seat_4 };
            int[][] row5 = new int[][] { seat5, seat_5 };
            int[][] row6 = new int[][] { seat6, seat_6 };
            int[][] row7 = new int[][] { seat7, seat_7 };
            int[][] row8 = new int[][] { seat8, seat_8 };
            int[][] row9 = new int[][] { seat9, seat_9 };
            int[][] row10 = new int[][] { seat10, seat_10 };
            
            int[][] row12 = new int[][] { seat12, seat_12 };
            int[][] row13 = new int[][] { seat13, seat_13 };
            int[][] row14 = new int[][] { seat14, seat_14 };
            int[][] row15 = new int[][] { seat15, seat_15 };
            int[][] row16 = new int[][] { seat16, seat_16 };
            int[][] row17 = new int[][] { seat17, seat_17 };
            int[][] row18 = new int[][] { seat18, seat_18 };
            int[][] row19 = new int[][] { seat19, seat_19 };

            List<int[][]> comppartment = new List<int[][]>() { row1, row2,row3,row4,row5,row6,row7,row8,row9,row10, row12, row13, row14, row15, row16, row17, row18, row19 };

          
           

            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                 InputSeatno = int.Parse(Console.ReadLine());
                // get sub array block which resides input number 
                //get index of input number
                if (InputSeatno<=108)
                {
                    Console.Write(GetRow(comppartment, InputSeatno));
                    Console.WriteLine(); 
                }
                else
                {
                    Console.WriteLine("Error...Kindly give value seat number");
                }
            }

            Console.ReadLine();
          
        }

        public static string GetRow(List<int[][]> compart, int InputSeatno)
        {
            // get row which resides the input seatnumber
            int[][] inputblock = new int[1][];
            int indexOfInputArr = 0;
            string Output = "";

            foreach (var items in compart)
            {
                foreach (var item in items)
                {
                    if (((int[])item).Contains(InputSeatno))
                    {
                         indexOfInputArr = item.ToList().IndexOf(InputSeatno);
                        inputblock = items;
                        break;
                        //return items;
                    }
                }
            }
            // get adjucent block
            var list=inputblock.ToList().Where(y=>!(y.Contains(InputSeatno)));

            //get element in adjucent array of input number and which is (arr.length - indexofInput + 1) and get it index in it
            // Push in to output string by sufix space.
                var arr = list.ToArray().FirstOrDefault();
                int oppositSeat = Convert.ToInt32(Convert.ToString(arr[indexOfInputArr]));
                Output = oppositSeat +  " ";

            // find the position of the seat
            Output += indexOfInputArr == 0 ? "WS" : indexOfInputArr == 1 ? "MS" : "AS";
            return Output;
        }


    }
}
