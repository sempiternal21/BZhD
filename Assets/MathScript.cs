using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathScript
{
    public static double[,] arr = {
        {0, 0, 0, 0, 0, 0, 0},

        {0, 9, 10, 20, 60, 44, 56}, // нет пружин
        {0, 15, 76, 16, 220, 230, 280}, // 1 пружина
        {0, 0, 0, 0, 0, 0, 0}, // 2 пружина
        {0, 5, 9, 10, 60, 90, 180}, // 3 пружина
        {0, 3, 30, 100, 110, 16, 32}// 4 пружина
        };
}
