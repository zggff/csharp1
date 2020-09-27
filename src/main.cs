using System;

namespace program
{
    class Program
    {
        public static void Main(string[] args)
        {  
            int[,] sudoku = {
                {1,5,0,0,0,0,9,2,4},
                {0,0,4,0,0,0,7,0,6},
                {0,0,0,0,0,0,3,8,5},
                {0,0,0,0,0,0,3,8,5},
                {0,2,0,3,0,0,0,6,0},
                {0,0,6,7,0,0,4,0,3},
                {0,0,2,4,0,0,5,3,1},
                {0,0,7,2,0,3,6,9,8},
                {0,8,3,0,0,1,2,4,0},
            };


            int rows = sudoku.GetUpperBound(0) + 1;
            int columns = sudoku.Length / rows;

            Console.WriteLine(IsPossible(sudoku, rows, columns, 0, 2, 9));


            // for(int x = 0; x < rows; x++)
            // {
            //     for(int y = 0; y < columns; y++)
            //     {
            //         Console.Write(sudoku[x, y] + "\t");
            //     }
            //     Console.WriteLine();
            // }            
        } 
        static bool IsPossible(int[,] sudoku, int rows, int columns, int x , int y ,int value)
        {
            int cell = sudoku[x, y] ;
            if (cell != 0)
            {    
                return false;
            }

            for(int x1 = 0; x1 < rows; x1++)     
            {
                if(sudoku[x1, y] == value )
                {
                    return false;   
                }
            } 
            for(int y1 = 0; y1 < columns; y1++)
            {  
                if(sudoku[x, y1] == value)
                {
                    return false;
                }
            } 

            int row = Math.Floor(x/3) * 3;
            int column = Math.Floor(y/3) * 3;
            
            for(int x1 = 0; x1 < 3; x1++)
            {
                for(int y1 = 0; y1 < 3; y1++)
                {  
                    if(sudoku[row + x1, column + y1] == value)
                    {
                        return false;
                    }
                    
                }
            }
            return true;
        }
    }
} 