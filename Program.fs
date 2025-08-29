open System
open System.Threading
open DiscordRPC
open DiscordRPC.Logging

[<EntryPoint>]
let main argv =
    // Timer iniziale (es. 5 secondi)
    Console.WriteLine("Loading...")
    Thread.Sleep(5000)

    // Inizializza il client con il tuo ID dell'app Discord
    let client = new DiscordRpcClient("1401258979748872202")

    // Connessione a Discord
    client.Initialize()

    // Imposta la Rich Presence
    client.SetPresence(
        RichPresence(
            Details = "Playing Clover Client",
            State = "In the GUI",
            Assets = Assets(
                LargeImageKey = "logo",
                LargeImageText = "Coded in F# by CodeSharp"
            )
        )
    )

    Console.WriteLine("Clover Client by CodeSharp")

    // Mantieni il programma in esecuzione
    while true do
        client.Invoke()
        Thread.Sleep(1000)

    0 // codice di uscita
