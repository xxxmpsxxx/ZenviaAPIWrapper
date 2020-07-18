using System;

namespace ZenviaWhatsapp
{
    class Program
    {
        static void Main(string[] args)
        {
            //"{\"from\":\"few-jumper\",\"to\":\"5517991119839\",\"contents\":[{\"type\":\"text\",\"text\":\"Testando3333333333333333\"}]}";
            var x = new WhatsappClient("qwXNkAVQQ6WUAni_BrTOkN0BFg-zOkc3AjiZ");
            x.SendMessage(new Message()
            {
               from = "few-jumper",
               to = "5517991119839",
               contents = new Content[] { new Content() { text = "Testando o webhook", type = "text" } }
            });

            Console.ReadKey();

        }
    }
}
