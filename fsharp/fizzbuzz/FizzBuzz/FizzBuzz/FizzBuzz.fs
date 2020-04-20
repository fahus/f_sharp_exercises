// Learn more about F# at http://fsharp.org

open System

[1..15]
|> List.map (fun x -> 
match (x % 3, x % 5) with 
| (0,0) -> "FizzBuzz"
| (0,_) -> "Fizz"
| (0,_) -> "Buzz"
| (_,_) -> x |> string
)
