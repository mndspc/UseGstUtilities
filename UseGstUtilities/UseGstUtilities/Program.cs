using System;
using GstUtilities;
namespace UseGstUtilities
{
    class Program
    {
        //  This program demo. how to refer private assembly.
        static void Main(string[] args)
        {
            GST gst = new GST(10000,10);
            Console.WriteLine($"GST Amount is:{gst.CalculateGstAmt()}");
            Console.WriteLine($"Total Product Amount is:{gst.CalculateTotalProAmt()}");
            Console.ReadLine();
        }
    }
}
