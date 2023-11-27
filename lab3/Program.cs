using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1
{
    //Жесткий диск", "WD Blue", 1000, "SATA III 6 Гбит/с", 7200
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов");
            int n = Convert.ToInt32(Console.ReadLine());
            queues a = new queues(n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Жесткий диск:\nФирма: {a[i].firm}\nОбъём HDD(ГБ): {a[i].mark}\nИдентифиционный номер: {a[i].id}\n");
            }
            Console.ReadKey();
        }
    }
}

class queues
{
    HDD[] Queues = new HDD[30];
    public queues(int n)
    {
        for (int i = 0; i < n; i++)
            Queues[i] = new HDD();
    }

    public HDD this[int pos]
    {
        get
        {
            if (pos >= 0 && pos < 30)
                return Queues[pos];
            else
                throw new IndexOutOfRangeException("Вне диапазона");
        }
        set
        {
            Queues[pos] = value;
        }
    }
}
public class HDD
{
    public string firm;
    public int mark;
    public int id;

    private string[] firmArr = new string[6] { "WD Blue", "WD Purple", "Toshiba", "Segate SkyHawk", "WD Red Plus", "Samsung" };
    private int[] memorykArr = new int[4] {500,1000,2000,3000};
    public HDD()
    {
        Random random = new Random();
        int t = random.Next(0, firmArr.Length);
        int t2 = random.Next(0, memorykArr.Length);
        firm = firmArr[t];
        mark = memorykArr[t2];
        Random idRan = new Random();
        id = idRan.Next(30);

    }

}