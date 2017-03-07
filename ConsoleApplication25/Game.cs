using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Game
    {
        private int[] numbers;
        private int[,] m;
        private int size = 0;

        public Game(params int[] Numbers)
        {
            numbers = Numbers;
            CheckValue(); 
            CalculationSizeGame();
        }

        private void CheckValue()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = numbers.Length - 1; j < 0; j--)
                {
                    if (numbers[i] == numbers[j])
                    {
                        throw new ArgumentException();
                    }
                    if (numbers[i] < 0)
                    {
                        throw new ArgumentException();
                    }
                }
            }
        }
        private void CalculationSizeGame()
        {
            
            size = (int)Math.Sqrt(numbers.Length);

            if (size == Math.Sqrt(numbers.Length))
            {
                int[,] m = new int[size, size];

                int indexNumbers = 0;
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        m[i, j] = numbers[indexNumbers];
                        indexNumbers++;
                        Console.Write(m[i, j]);
                    }
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
