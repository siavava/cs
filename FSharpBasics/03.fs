namespace FSharpBasics

open System
open System.Threading

module Program =

  [<EntryPoint>]
  let main args =
    
    printf "What is your name? "
    let name = Console.ReadLine()   // side-effects functions take units `()`

    printf "How old are you? "
    let age = Console.ReadLine()    // side-effects functions take units `()`
    printfn "Hello, I'm %s and I am %s years old!" name age

    let currentTime =
      DateTime.Now

    printfn "THE WRONG WAY...\n"

    printfn "%O" currentTime

    Thread.Sleep 2000

    printfn "%O" currentTime


    printfn "THE RIGHT WAY...\n"

    let currentTime() =
      DateTime.Now
    
    currentTime() |> printfn "%O"
    
    Thread.Sleep 2000
    
    currentTime() |> printfn "%O"
    0

