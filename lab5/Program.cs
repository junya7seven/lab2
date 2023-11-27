using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Project5
{
    [Serializable]
    class queue
    {
        private int Memory = 1000;
        private string[] Firm = new string[4] { "WD Blue", "Toshiba", "WD Purple", "Segate SkyHawk" };
        public int p;
        public string ch;
    }
    [Serializable]
    class queue1 : queue
    {
        private int Sata = 6;
        public new int Memory = 5000;
        public new string[] Firm = new string[4] { "WD Red Plus", "samsung", "Toshiba", "WD Purple Plus" };
        public queue1() { }
        public queue1(int q, int i)
        {
            p = q * Sata;
            ch = Firm[i];
        }
    }

    class Executer
    {
        [STAThread]
        static void Main()
        {
            queue1 a = new queue1();
            queue1 b = new queue1(50, 2);
            queue1 c = new queue1(500, 1);

            FileStream fs;
            fs = new FileStream
                ("File_queue.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter sw = new BinaryFormatter();
            sw.Serialize(fs, b);
            sw.Serialize(fs, c);
            fs.Close();

            fs = new FileStream
                ("File_queue.bin", FileMode.Open, FileAccess.Read);
            long i = 0,
            j = fs.Length / 231; //231 — количество байт занимаемых одним объектом класса  queue1

            while (i < j)
            {
                a = (queue1)sw.Deserialize(fs);
                Console.WriteLine(a.p);
                Console.WriteLine(a.ch);
                i++;
            }
            fs.Close();
            Console.ReadLine();
        }
    }
}

