using System;

namespace KataHRD
{
    public class Program
    {
        static void Main(string[] args)
        {
            TimeFormat tf = new TimeFormat();
            Console.WriteLine(tf.GetReadableTime(0));
            Console.WriteLine(tf.GetReadableTime(5));
            Console.WriteLine(tf.GetReadableTime(60));
            Console.WriteLine(tf.GetReadableTime(4000));
            Console.WriteLine(tf.GetReadableTime(7643));
            Console.WriteLine(tf.GetReadableTime(86399));
            Console.WriteLine(tf.GetReadableTime(359999));
        }

        
    }
}
