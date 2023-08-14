using Make_ET_HNX.Read_Data;
using System.Text;
using System.Text.RegularExpressions;

public class Program
{
    static void Main(string[] args)
    {
        Queue_HNX queue = new Queue_HNX();
        queue.Queue();
    }
    
    //static void Main(string[] args)
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
    //static void Main(string[] args)
    //{
    //    Queue<byte[]> messageQueue = new Queue<byte[]>();

    //    // Read the messages from the file and enqueue them as binary
    //    string filePath = "D:\\FPTS Job\\HNX\\02_08_test.txt";
    //    foreach (string line in File.ReadLines(filePath))
    //    {
    //        byte[] binaryMessage = ConvertStringToByteArray(line);
    //        messageQueue.Enqueue(binaryMessage);
    //    }

    //    // Read messages back from the queue and write them to a text file
    //    using (StreamWriter writer = new StreamWriter("D:\\FPTS Job\\HNX\\try.txt"))
    //    {
    //        while (messageQueue.Count > 0)
    //        {
    //            byte[] message = messageQueue.Dequeue();
    //            writer.WriteLine(ConvertByteArrayToString(message));
    //        }
    //    }

    //    Console.WriteLine("Messages saved to output_messages.txt");
    //    Console.ReadLine(); // Keep the console window open until user input
    //}

    //// Helper method to convert a hex string to a byte array
    //static byte[] ConvertStringToByteArray(string hex)
    //{
    //    //hex = hex.Replace(" ", "").Replace("", "");
    //    hex = Regex.Replace(hex, @"[^0-9a-fA-F]", "");
    //    int length = hex.Length / 2;
    //    byte[] byteArray = new byte[length];

    //    for (int i = 0; i < length; i++)
    //    {
    //        byteArray[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
    //    }

    //    return byteArray;
    //}

    //// Helper method to convert a byte array to a hex string
    //static string ConvertByteArrayToString(byte[] byteArray)
    //{
    //    string hex = BitConverter.ToString(byteArray).Replace("-", "");
    //    return hex;
    //}
    #region
    //static void Main(string[] args)
    //{
    //    Queue<string> messageQueue = new Queue<string>();

    //    // Read the messages from the file and enqueue them
    //    string filePath = "D:\\FPTS Job\\HNX\\02_08_test.txt";
    //    foreach (string line in File.ReadLines(filePath))
    //    {
    //        string[] fields = line.Split(',');

    //        // Combine the fields using the delimiter ''
    //        string combinedMessage = string.Join("", fields);
    //        messageQueue.Enqueue(combinedMessage);
    //    }
    //    using (StreamWriter writer = new StreamWriter("try.txt"))
    //    {
    //        while (messageQueue.Count > 0)
    //        {
    //            byte[] message = messageQueue.Dequeue();
    //            string hexMessage = BitConverter.ToString(message).Replace("-", "");
    //            writer.WriteLine(hexMessage);
    //        }
    //    }
    //    // Display messages from the queue
    //    while (messageQueue.Count > 0)
    //    {
    //        string message = messageQueue.Dequeue();
    //        Console.WriteLine($"Message: {message}");
    //    }

    //    Console.ReadLine(); // Keep the console window open until user input
    //}
    //static void Main(string[] args)
    //{
    //    Queue<byte[]> messageQueue = new Queue<byte[]>();
    //    string filePath = "D:\\FPTS Job\\HNX\\02_08_test.txt";
    //    //Đọc từng dòng từ tệp + liệt kê dưới dạng binary
    //    foreach(string line in File.ReadAllLines(filePath))
    //    {
    //        byte[] binaryData = Encoding.ASCII.GetBytes(line);
    //        messageQueue.Enqueue(binaryData);
    //    }
    //    if(messageQueue.Count > 0)
    //    {
    //        byte[] firstMessage = messageQueue.Dequeue();
    //        Console.WriteLine("First mesage as binary");
    //        Console.WriteLine(BitConverter.ToString(firstMessage));
    //    }
    //}
    #endregion
}
