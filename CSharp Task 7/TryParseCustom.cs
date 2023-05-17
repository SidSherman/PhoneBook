﻿using System;
using System.Collections.Generic;

namespace PhoneBook
{
    internal class TryParseCustom
    {

        #region TryReadLine

        static public int TryReadLineInt(string str)
        {
            int value;
            while (true)
            {
                if (!int.TryParse(str, out value))
                {
                    Console.WriteLine("Введено недопустимое значение, нажмите Enter и попробуйте ещё раз");
                    str = Console.ReadLine();
                    continue;
                }
                else return value;
            }
        }

        static public bool VerifyNumber(string str)
        {
            int value;
            str.Replace(" ", "");

            if (int.TryParse(str, out value))
            {
                return true;
            }
            else return false;

        }



        static public float TryReadLineFloat(string str)
        {
            float value;
            while (true)
            {
                if (!float.TryParse(str, out value))
                {
                    Console.WriteLine("Введено недопустимое значение, нажмите Enter и попробуйте ещё раз");
                    str = Console.ReadLine();
                    continue;
                }
                else return value;
            }
        }

        static public DateTime TryReadLineDataTime(string str)
        {
            DateTime value;
            while (true)
            {
                if (!DateTime.TryParse(str, out value))
                {
                    Console.WriteLine("Введено недопустимое значение, нажмите Enter и попробуйте ещё раз");
                    Console.ReadLine();
                    str = Console.ReadLine();
                    continue;
                }
                else return value;
            }
        }
        #endregion


    }
}
