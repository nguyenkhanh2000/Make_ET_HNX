﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_ET_HNX.Models
{
    internal class Backup
    {
        //public void Queue()
        //{
        //    Queue<byte[]> messageQueue = new Queue<byte[]>();

        //    // Read the messages from the file and enqueue them as binary
        //    string filePath = "D:\\FPTS Job\\HNX\\02_08_test.txt";
        //    foreach (string line in File.ReadLines(filePath))
        //    {
        //        byte[] binaryMessage = Encoding.ASCII.GetBytes(line);
        //        messageQueue.Enqueue(binaryMessage);
        //    }

        //    // Dequeue binary messages from the queue and write them to try.txt
        //    using (FileStream fileStream = new FileStream("D:\\FPTS Job\\HNX\\try.txt", FileMode.Create))
        //    {
        //        while (messageQueue.Count > 0)
        //        {
        //            byte[] message = messageQueue.Dequeue();
        //            fileStream.Write(message, 0, message.Length);

        //        }
        //    }
        //    // Read the contents of try.txt and display them
        //    byte[] tryFileContents = File.ReadAllBytes("try.txt");
        //    string tryFileContentsString = Encoding.ASCII.GetString(tryFileContents);
        //    Console.WriteLine(tryFileContentsString);

        //    Console.ReadLine(); // Keep the console window open until user input
        //}
    }
}
