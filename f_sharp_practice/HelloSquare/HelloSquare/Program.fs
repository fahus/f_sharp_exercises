module HelloSquare

type TwoNumbers = int * int 

let minus ((fst,snd):TwoNumbers) = 
fst - snd 


let isOdd x = x % 2 <> 0
let result =
    if isOdd input then 
        input +1
        else 
            input 
            result 

let numbers = [3;2;1;0]
let addNumbers = 4 :: numbers 


let letters = ["h"; "i"; "j"; "k"]
let addLetter = "g" :: letters 

let double = fun n -> 2 * n 
double(2)

let distance x y = x - y |> abs 
distance 500 100 

let distance x y = x - y |> abs 
let distance x y = (x:float) - (y:float) |> abs;;

let (|><|) x y = x - y |> abs 
10 |><| 5

List.map (fun x -> x * 2 ) [2;4;6]

let rec length - function
|[] -> 0 
|x::xs -> 1 + length xs
;;

length[1;2;3;4;5;6]

let rec factorial n = 
    if n < 2 then 
        1 
        else 
            n * factorial (n-1)

            let f x = 
                match x with
                | 1 -> "a" 
                | _ -> "b"

 let name = "Faduma"
name.[0]

