using System;
namespace les_03_task_01
{
    /*
	    1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые
	значения от –10 000 до 10 000 включительно. Написать программу, позволяющую найти и вывести
	количество пар элементов массива, в которых хотя бы одно число делится на 3. В данной задаче
	под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти
	элементов: 6; 2; 9; –3; 6 – ответ: 4
    */

    public class Task_01
    {
        int[] arr0;

        public Task_01(int n) 
        {
            arr0 = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr0[i] = rnd.Next(-10000, 10000);
            }
        }

        public int[] Arr{

            set
            {
                Random rnd = new Random();
                for (int i = 0; i < Convert.ToInt32(value); i++)
                {
                    arr0[i] = rnd.Next(-10000, 10000);
                }
            }
    
            get
            {
                return arr0;
            }
        }

        public int getPairCount(){
            int count = 0;
            for (int i = 0; i < arr0.Length - 1; i++)
                if(arr0[i]%3 == 0 || arr0[i+1]%3 == 0)
                    count++;
            return count;
        }
    }
}