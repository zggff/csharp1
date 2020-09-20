using System;

namespace program{
    class Program{
        public static void Main(string[] args){
            //формат массива - [12;342;423;412;12.2]
            foreach(string arg in args){
                Console.WriteLine(arg);
            }
        }
    }
} 