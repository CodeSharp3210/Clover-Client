using System;
using System.Threading;
using DiscordRPC;
using DiscordRPC.Logging;

class Program
{
    static DiscordRpcClient client;

    static void Main(string[] args)
    {


        // Timer iniziale (es. 5 secondi)
        Console.WriteLine("Loading...");
        Thread.Sleep(5000); // attende 5000 millisecondi = 5 secondi


        // Inizializza il client con il tuo ID dell'app Discord
        client = new DiscordRpcClient("BOT_ID");


        // Connessione a Discord
        client.Initialize();

        // Imposta la Rich Presence
        client.SetPresence(new RichPresence()
        {
            Details = "Playing Clover Client",
            State = "In the GUI",
            Assets = new Assets()
            {
                LargeImageKey = "logo", // Assicurati che esista su Discord Developer Portal
                LargeImageText = "Coded in C# by CodeSharp"
            }
        });

        Console.WriteLine("Clover Client by CodeSharp");

        // Mantieni il programma in esecuzione
        while (true)
        {
            client.Invoke();
            Thread.Sleep(1000);
        }
    }

}

