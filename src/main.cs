using System;

namespace program
{
    class Program
    {
        public static void Main(string[] args)
        {  
            int[,] sudoku = {
                {0,0,0,0,1,0,0,9,0 },
                {0,0,0,0,3,6,0,0,0 },
                {0,0,9,0,0,0,7,5,0 },
                {0,0,7,0,4,0,0,0,0 },
                {4,0,0,0,0,3,0,8,0 },
                {0,1,6,0,0,0,3,0,0 },
                {0,4,0,0,6,0,0,0,1 },
                {2,0,0,0,0,1,0,0,0 },
                {0,3,0,0,0,0,8,0,7 }
            };
            Console.WriteLine("исходное судоку:");
            
            PrintSudoku(sudoku);
             
            if(Solve(sudoku))
            {
                Console.WriteLine("reshennoe sudoku:");
                PrintSudoku(sudoku);
            }else
            {
                Console.WriteLine("sudoku ne resheno");
            }

         
        }
         
        static void PrintSudoku(int[,] sudoku)
        {
          for(int x = 0; x < 9; x++)
          {
              for(int y = 0; y < 9; y++)
              {
                  
                  Console.Write(sudoku[x, y] + "  ");
              }
              Console.WriteLine();
          }
        }

        

        

        static bool Solve(int[,] sudoku)
        {
            for(int x = 0; x < 9; x++) 
            {
                for(int y = 0; y < 9; y++)
                {
                    if (sudoku[x, y] == 0)
                    {
                        for(int value = 1; value < 10; value++)
                        {
                           if(IsPossible(sudoku, x, y, value))
                           {
                               
                                sudoku[x, y] = value;
                                bool solved = Solve(sudoku);
                                if(solved)
                                {
                                    return true;
                                } else
                                {
                                    sudoku[x, y] = 0;
                                }

                                
                           } //код выполняться для значения от одного до девяти для всех пустых клеток в судоку
                            

                        }
                        return false;
                    }
                }
            }       
            return true;

        }

        static bool IsPossible(int[,] sudoku, int x , int y ,int value)
        {
            for(int x1 = 0; x1 < 9; x1++)     
            {
                if(sudoku[x1, y] == value )
                {
                    return false;   
                }
            } 

            for(int y1 = 0; y1 < 9; y1++)
            {  
                if(sudoku[x, y1] == value)
                {
                    return false;
                }
            } 

            int row = (int) Math.Floor(x/3.0) * 3;
            int column = (int) Math.Floor(y/3.0) * 3;
            
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