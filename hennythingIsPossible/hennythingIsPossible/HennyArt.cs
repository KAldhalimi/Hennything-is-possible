﻿using System;
using System.Collections.Generic;
using System.Text;

namespace hennythingIsPossible
{
    public class HennyArt
    {
        public static void DisplayHennyArt()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.Title = "Hennything Is Possible Liquor Store";
            //            string title = @"
            // _    _                        _   _     _               _____     
            //| |  | |                      | | | |   (_)             |_   _|    
            //| |__| | ___ _ __  _ __  _   _| |_| |__  _ _ __   __ _    | |  ___ 
            //|  __  |/ _ \ '_ \| '_ \| | | | __| '_ \| | '_ \ / _` |   | | / __|
            //| |  | |  __/ | | | | | | |_| | |_| | | | | | | | (_| |  _| |_\__ \
            //|_|  |_|\___|_| |_|_| |_|\__, |\__|_| |_|_|_| |_|\__, | |_____|___/
            //                          __/ |                   __/ |            
            //                         |___/                   |___/             
            // _____              _ _     _                                      
            //|  __ \            (_) |   | |                                     
            //| |__) |__  ___ ___ _| |__ | | ___                                 
            //|  ___/ _ \/ __/ __| | '_ \| |/ _ \                                
            //| |  | (_) \__ \__ \ | |_) | |  __/                                
            //|_|   \___/|___/___/_|_.__/|_|\___|                                
            //                                                                   ";

            string title = @"
 _   _                        _   _     _               ___       ____               _ _     _      
| | | | ___ _ __  _ __  _   _| |_| |__ (_)_ __   __ _  |_ _|___  |  _ \ ___  ___ ___(_) |__ | | ___ 
| |_| |/ _ \ '_ \| '_ \| | | | __| '_ \| | '_ \ / _` |  | |/ __| | |_) / _ \/ __/ __| | '_ \| |/ _ \
|  _  |  __/ | | | | | | |_| | |_| | | | | | | | (_| |  | |\__ \ |  __/ (_) \__ \__ \ | |_) | |  __/
|_| |_|\___|_| |_|_| |_|\__, |\__|_| |_|_|_| |_|\__, | |___|___/ |_|   \___/|___/___/_|_.__/|_|\___|
                        |___/                   |___/                                               ";

            Console.WriteLine(title);
            Console.WriteLine();
            Console.ResetColor();

        }
    }
}
