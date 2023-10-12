namespace Algorithms_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK 1  Verilən ədədə və ya ondan böyük ən yaxın ədədə qədər fibonaççi ardıcıllığını ekrana çap edin.


            //for (; true;)                                     //yoxlamaq daha rahat olsun deyedi bu for, algoritme daxil deyil
            //{
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    int first = 0, second = 1, third = 0;        //fikrimzde 1-ci ve 2 ci elementleri tuturq sonrada onlari artirib deyismek ucun 3 u elementi istifade edirik 
            //    Console.WriteLine(0);
            //    for (; true;)
            //    {
            //        if (first < x)
            //        {
            //            Console.WriteLine(second);
            //            third = first + second;
            //            first = second;
            //            second = third;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //}



            //Task 2-  2 dəyişənin dəyərlərini 3cü dəyişən istifadə etmədən dəyişin

            int a = 4;
            int b = 8;
            a = a * b;
            b = a / b;
            a = a / b;
            ////bu usulu "/","*","+","-" ilede etmek olar ama "*" ve "+" daha rahtdi mence
            /// "/" ile etsek int32 problem yaradacaq data type deyisdirmeliyik
            //a = a + b;
            //b = a - b;
            //a = a - b;

            //a = a - b;
            //b = a + b;
            //a = b - a;

            Console.WriteLine("a= " + a + "  b= " + b);



            //c# imkannlarindan istifade edib belede etmek olar
            int c = 10;
            int d = 2;
            (c, d) = (d, c);
            Console.WriteLine("c= " + c + "  d= " + d);

        }
    }
}