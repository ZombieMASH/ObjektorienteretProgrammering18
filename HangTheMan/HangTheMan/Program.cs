﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HangTheMan
{
    class Program
    {
        static void Main(string[] args)
        {
            StartMenu startmenu = new StartMenu(placeHolder);
            startmenu.StartUp();
        }

        static void placeHolder()
        {
            Console.WriteLine("");
        }

    }
    
}
