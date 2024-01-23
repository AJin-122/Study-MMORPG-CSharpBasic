using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Map
    {
        int[,] tiles =
        {
            { 1, 1, 1, 1, 1},
            { 1, 0, 0, 0, 1},
            { 1, 0, 0, 0, 1},
            { 1, 0, 0, 0, 1},
            { 1, 1, 1, 1, 1}
        };

        public void Render()
        {
            var defaultColor = Console.ForegroundColor;

            for (int i = 0; i < tiles.GetLength(1); i++)
            {
                for (int j = 0; j < tiles.GetLength(0); j++)
                {
                    if (tiles[i, j] == 1)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else Console.ForegroundColor = ConsoleColor.Green;

                    Console.Write('\u25cf');
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = defaultColor;
        }
    }
    class TwoArray
    {
        // 이차원 배열
        // 선언
        // 2F [ . . . ]
        // 1F [ . . . ]
        int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 1, 2, 3 } };

        // 가변 배열
        // 선언
        // 3F [ . . ]
        // 2F [ . . . . . ]
        // 1F [ . . . ]
        TwoArray()
        {
            int[][] a = new int[3][];
            a[0] = new int[3];
            a[1] = new int[6];
            a[2] = new int[2];
        }
    }
}
