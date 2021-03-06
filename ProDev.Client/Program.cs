﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Http;

namespace ProDev.Client
{
    class Program
    {
        static void Main(string[] args)
        {
        restart:
            SendMessage();
            Console.WriteLine("Sent!");
            Console.ReadLine();
            goto restart;
        }

        static void SendMessage()
        {
            var baseAddress = "http://marct-w8-dt/ProDev.WebAPIv2/api/submit";

            var http = (HttpWebRequest)WebRequest.Create(new Uri(baseAddress));
            //http.Accept = "application/json";
            http.ContentType = "application/json";
            http.Method = "POST";

            string parsedContent = "{\"To\": \"marct@nvisionit.co.za\", \"Subject\": \"Console test\", \"Message\": \"This is a test\", \"DeliveryType\": \"Email\"}";

            ASCIIEncoding encoding = new ASCIIEncoding();
            Byte[] bytes = encoding.GetBytes(parsedContent);

            Stream newStream = http.GetRequestStream();
            newStream.Write(bytes, 0, bytes.Length);
            newStream.Close();

            var response = http.GetResponse();

            var stream = response.GetResponseStream();
            var sr = new StreamReader(stream);
            var content = sr.ReadToEnd();
            Console.WriteLine("Received: {0}", content.ToString());

        }
    }
}
