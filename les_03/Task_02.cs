using System;
namespace les_03_task_02
/*
	а)Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий
	массив заданной размерности и заполняющий массив числами от начального значения с заданным
	шагом. Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse,
	меняющий знаки у всех элементов массива, Метод Multi, умножающий каждый элемент массива на
	определенное число, свойство MaxCount, возвращающее количество максимальных элементов. В
	Main продемонстрировать работу класса.
	б)*Добавить конструктор и методы, которые загружают данные из файла и записывают данные в
	файл.
*/
{
    public class Task_02
    {
        int[] arr;

        public Task_02(int n, int start, int step)
        {
            arr = new int[n];
            arr[0] = start;
            for (int i = 1; i < n; i++)
            {
                arr[i] = arr[i-1] + step;
            }
        }

        public int Sum()
        {
            int sum = 0;
            for(int i = 0; i < this.arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public void Inverse()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = -arr[i];
            }
        }

        public void Multi(int mult)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] *= mult;
            }
        }

        public int MaxCount()
        {
            int count = 1;
            int max = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                    count = 1;                    
                } else if (arr[i] == max)
                {
                   count++; 
                }
            }
            return count;
        }
    }
}