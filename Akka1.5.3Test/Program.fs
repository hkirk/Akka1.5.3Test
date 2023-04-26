open Akka
open Akka.Actor.Dsl
open Akka.FSharp

// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

let helloActor msg =
    match msg with
    | "hello" -> printfn "Hello to you"
    | _ -> printfn "Wrong message"


let system = System.create "NewSystem" (Configuration.load())

let actor = spawn system "Actor" (actorOf helloActor)

actor <! "hello"