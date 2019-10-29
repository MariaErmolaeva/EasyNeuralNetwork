using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimensionalNeuralNetwork
{
    class Program
    {

        static void Main(string[] args)
        {

            NeuralNetwork neural = new NeuralNetwork();

            neural.Training();

            neural.Show();
        }
    }

    public class NeuralNetwork
    {
        string[] numberTraing = new string[10]
        {
            "111101101101111",
            "001001001001001",
            "111001111100111",
            "111001111001111",
            "101101111001001",
            "111100111001111",
            "111100111101111",
            "111001001001001",
            "111101111101111",
            "111101111001111"
        };

        string[] numberTest = new string[6]
        {
            "111100111000111",
            "111100010001111",
            "111100011001111",
            "110100111001111",
            "110100111001011",
            "111100101001111"
        };


        int[] weight;

        int bias = 5;

        public NeuralNetwork()
        {
            weight = new int[15];

            for (int i = 0; i < 15; i++)
                weight[i] = 0;
        }


        public void Decrease(string number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == '1')
                    weight[i] -= 1;
            }
        }

        public void Increase(string number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == '1')
                    weight[i] += 1;
            }
        }

        public bool Procces(string number)
        {
            int sum = 0;
            for (int i = 0; i < 15; i++)
                sum += weight[i] * Convert.ToInt32(number[i]);

            if (sum > bias)
                return true;
            else
                return false;
        }


        public void Training()
        {
            Random rnd = new Random();
            for (int i = 0; i < 5000; i++)
            {
                int trueResult = rnd.Next(0, 9);

                if (trueResult != 5)
                {
                    if (Procces(numberTraing[trueResult]))
                    {
                        Decrease(numberTraing[trueResult]);
                    }
                }
                else
                    if (Procces(numberTraing[5]) == false)
                    Increase(numberTraing[5]);
            }

        }

        public void Show()
        {
            for (int i = 0; i < 15; i++)
                Console.Write(weight[i].ToString() + "; ");

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
                Console.WriteLine(i.ToString() + " это 5? " + Procces(numberTraing[i]));

            Console.WriteLine();

            for (int i = 0; i < 6; i++)
                Console.WriteLine("Это 5? " + Procces(numberTest[i]));

            Console.ReadKey();
        }
    }


    public class NeuralNetwork2
    {
        int[] weight;

        string[] numberTraining;

        string[] numberTesting;

        static int inputCount = 208;

        public NeuralNetwork2(int numberTrain, int numberTest)
        {

            weight = new int [inputCount];

            for (int i = 0; i < inputCount; i++)
                weight[i] = 0;

            numberTraining = new string[numberTrain];

            numberTesting = new string[numberTest];
        }


        public void GetInputNeuron(string path)
        {
            Bitmap bmp = new Bitmap(path);

            for (int i=0; i <inputCount; i++)
            {
                
            }
        }


    }
}


