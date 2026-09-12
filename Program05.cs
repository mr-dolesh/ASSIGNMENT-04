using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASSIGNMENT_04
{
    internal class Program05
    {
        delegate void notification();
        static void email()
        {
            Console.WriteLine("Email notification sent.");
        }
        static void sms()
        {
            Console.WriteLine("SMS notification sent.");
        }
        static void whatsapp()
        {
            Console.WriteLine("WhatsApp notification sent.");
        }
        public static void Main(string[] args)
        {
            notification obj = email;
            obj += sms;
            obj += whatsapp;
            obj();
        }
    }
}
