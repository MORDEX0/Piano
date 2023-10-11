using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {

        static int[] DO = new int[] { 130, 261, 523, 1046 };
        static int[] DOdi = new int[] { 138, 277, 554, 1109 };
        static int[] EB = new int[] { 155, 311, 622, 1245 };
        static int[] FAdi = new int[] { 185, 370, 740, 1480 };
        static int[] SOdi = new int[] { 207, 415, 830, 1661 };
        static int[] Bb = new int[] { 233, 466, 932, 1865 };
        static int[] RE = new int[] { 147, 294, 587, 1174 };
        static int[] MI = new int[] { 165, 330, 659, 1318 };
        static int[] FA = new int[] { 175, 349, 698, 1396 };
        static int[] SO = new int[] { 196, 392, 784, 1568 };
        static int[] LA = new int[] { 220, 440, 880, 1760 };
        static int[] TI = new int[] { 247, 494, 988, 1976 };

        public static void Main()
        {
            Console.WriteLine("Добро пожаловать в пианино. Для выбора актав используйте F3, F4, F5, F6" +
                "\n(для переключения нажмите Escape и выберите снова актаву).");
            Console.WriteLine("Чтобы выйти нажмите Escape");
            ConsoleKeyInfo key;
            while (true)
            {

                key = Console.ReadKey();
                if (key.Key == ConsoleKey.F3)
                {
                    char ke = '1';
                    while (ke != ((char)ConsoleKey.Escape))
                    {
                        ke = Console.ReadKey(true).KeyChar;
                        switch (ke)
                        {
                            case 'a':
                                Console.Beep(DO[0], 300);

                                break;
                            case 's':
                                Console.Beep(RE[0], 300);

                                break;
                            case 'w':
                                Console.Beep(DOdi[0], 300);

                                break;
                            case 'e':
                                Console.Beep(EB[0], 300);

                                break;
                            case 'y':
                                Console.Beep(SOdi[0], 300);

                                break;
                            case 't':
                                Console.Beep(FAdi[0], 300);

                                break;
                            case 'u':
                                Console.Beep(Bb[0], 300);

                                break;
                            case 'd':
                                Console.Beep(MI[0], 300);

                                break;
                            case 'f':
                                Console.Beep(FA[0], 300);

                                break;
                            case 'g':
                                Console.Beep(SO[0], 300);

                                break;
                            case 'h':
                                Console.Beep(LA[0], 300);

                                break;
                            case 'j':
                                Console.Beep(TI[0], 300);

                                break;
                        }
                    }
                }

                else if (key.Key == ConsoleKey.F4)
                {
                    char ke = '1';
                    while (ke != ((char)ConsoleKey.Escape))
                    {
                        ke = Console.ReadKey(true).KeyChar;
                        switch (ke)
                        {
                            case 'a':
                                Console.Beep(DO[1], 300);

                                break;
                            case 's':
                                Console.Beep(RE[1], 300);

                                break;
                            case 'w':
                                Console.Beep(DOdi[1], 300);

                                break;
                            case 'e':
                                Console.Beep(EB[1], 300);

                                break;
                            case 'y':
                                Console.Beep(SOdi[1], 300);

                                break;
                            case 't':
                                Console.Beep(FAdi[1], 300);

                                break;
                            case 'u':
                                Console.Beep(Bb[1], 300);

                                break;
                            case 'd':
                                Console.Beep(MI[1], 300);

                                break;
                            case 'f':
                                Console.Beep(FA[1], 300);

                                break;
                            case 'g':
                                Console.Beep(SO[1], 300);

                                break;
                            case 'h':
                                Console.Beep(LA[1], 300);

                                break;
                            case 'j':
                                Console.Beep(TI[1], 300);

                                break;
                        }
                    }
                }
                else if (key.Key == ConsoleKey.F5)
                {
                    char ke = '1';
                    while (ke != ((char)ConsoleKey.Escape))
                    {
                        ke = Console.ReadKey(true).KeyChar;
                        switch (ke)
                        {
                            case 'a':
                                Console.Beep(DO[2], 300);

                                break;
                            case 's':
                                Console.Beep(RE[2], 300);

                                break;
                            case 'w':
                                Console.Beep(DOdi[2], 300);

                                break;
                            case 'e':
                                Console.Beep(EB[2], 300);

                                break;
                            case 'y':
                                Console.Beep(SOdi[2], 300);

                                break;
                            case 't':
                                Console.Beep(FAdi[2], 300);

                                break;
                            case 'u':
                                Console.Beep(Bb[2], 300);

                                break;
                            case 'd':
                                Console.Beep(MI[2], 300);

                                break;
                            case 'f':
                                Console.Beep(FA[2], 300);

                                break;
                            case 'g':
                                Console.Beep(SO[2], 300);

                                break;
                            case 'h':
                                Console.Beep(LA[2], 300);

                                break;
                            case 'j':
                                Console.Beep(TI[2], 300);

                                break;
                        }
                    }
                }
                else if (key.Key == ConsoleKey.F6)
                {
                    char ke = '1';
                    while (ke != ((char)ConsoleKey.Escape))
                    {
                        ke = Console.ReadKey(true).KeyChar;
                        switch (ke)
                        {
                            case 'a':
                                Console.Beep(DO[3], 300);

                                break;
                            case 's':
                                Console.Beep(RE[3], 300);

                                break;
                            case 'w':
                                Console.Beep(DOdi[3], 300);

                                break;
                            case 'e':
                                Console.Beep(EB[3], 300);

                                break;
                            case 'y':
                                Console.Beep(SOdi[3], 300);

                                break;
                            case 't':
                                Console.Beep(FAdi[3], 300);

                                break;
                            case 'u':
                                Console.Beep(Bb[3], 300);

                                break;
                            case 'd':
                                Console.Beep(MI[3], 300);

                                break;
                            case 'f':
                                Console.Beep(FA[3], 300);

                                break;
                            case 'g':
                                Console.Beep(SO[3], 300);

                                break;
                            case 'h':
                                Console.Beep(LA[3], 300);

                                break;
                            case 'j':
                                Console.Beep(TI[3], 300);

                                break;
                        }
                    }
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
}