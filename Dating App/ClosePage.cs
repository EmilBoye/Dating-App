﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Dating_App
{
    public class ClosePage
    {
        public void CloseDown()
        {
            bool Restart = false;

            do
            {
                Console.Clear();
                Console.ResetColor();
                Console.WriteLine("Hav god dag");
            } while (Restart == true);
        }
    }
}
