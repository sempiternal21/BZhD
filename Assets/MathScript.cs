using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathScript
{
    public static double[,] arr = {
        {0, 0, 0, 0, 0, 0, 0},

        {0, 20, 30, 50, 100, 120, 140}, // нет пружин милливольт
        {0, 10, 15, 20, 60, 1000, 200}, // 1 пружина
        {0, 100, 80, 90, 1000, 600, 800}, // 2 пружина
        {0, 20, 300, 30, 400, 500, 350}, // 3 пружина
        {0, 3, 30, 100, 10, 16, 32}// 4 пружина
        };
}
