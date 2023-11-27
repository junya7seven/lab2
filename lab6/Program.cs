using System.Collections;

namespace lab6
{
    class ChooseSort
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во повторений");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                n = 2;
            }
            queues a = new queues(n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Жесткий диск:\nФирма: {a[i].firm}\nОбъём HDD(ГБ): {a[i].mark}\nИдентифиционный номер: {a[i].id}\n");
            }
            PrintSort();
            
        }
        public static void PrintSort()
        {
            HDD hdd = new HDD();
            string[] firmArray = hdd.firmArr;
            int[] memorykArr = hdd.memorykArr;
            Console.WriteLine("Сортировка методом прямого выбора");
            SelectionSorts.PrintArray(firmArray);
            SelectionSorts.PrintArray(memorykArr);
            Console.WriteLine("Сортировка методом прямого включения");
            InsertionSorts.PrintArray(firmArray);
            InsertionSorts.PrintArray(memorykArr);
            Console.WriteLine("Сортировка методом шейкера");
            CocktailSorts.PrintArray(firmArray);
            CocktailSorts.PrintArray(memorykArr);
            Console.WriteLine("Сортировка методом Шелла");
            ShellSorts.PrintArray(firmArray);
            ShellSorts.PrintArray(memorykArr);


        }
    }
}