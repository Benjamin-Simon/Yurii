using System;
using System.IO;

namespace MFU
{
    class Printer
    { 
        public void Print(string txt)
        {
            Console.WriteLine($"Текст для печати в MFU: {txt}");
        }
    }
    class Scaner
    {
        public void Scan()
        {
            string t;
            Console.WriteLine($"Введите текст для записи в файл: ");
            t = Console.ReadLine();

            StreamWriter print = new StreamWriter("note.txt", true); // добавить в файл
            print.WriteLine();
            print.Write("Вывод текста в файл: \n" + t);
            print.Close();
        }
    }

    //class MFU
    //{
    //    public void Print(string txt, Printer printer)
    //    {
    //        printer.Print(txt);
    //    }

    //    public void Scan(Scaner scaner)
    //    {
    //        scaner.Scan();
    //    }
    //}

    class MFU
    {
        private Printer printer;
        private Scaner scaner;

        public MFU(Printer printer, Scaner scaner)
        {
            this.printer = printer;
            this.scaner = scaner;
        }

        public void Print(string txt)
        {
            printer.Print(txt);
        }

        public void Scan()
        {
            scaner.Scan();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //использование класса "Printer"
            //Printer p = new Printer();
            //p.Print("Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor.");
            //Console.ReadKey();

            //использование класса "Scaner"
            //Scaner s = new Scaner();
            //s.Scan();

            //использование класса "MFU"
            MFU m = new MFU(new Printer(), new Scaner());

            //m.Print("Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor.", new Printer());
            //m.Scan(new Scaner());
            m.Print("Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor.");
            m.Scan();
        }
    }
}