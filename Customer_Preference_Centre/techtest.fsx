
open System

type CustomerPreferences = 
| Never 
| Everyday
| DayOfTheMonth of int
| DayOfTheWeek of DayOfWeek

type Customer =
    {CustomerID : string
     CustomerPreferences: CustomerPreferences} 

let contactCustomer (date: DateTime) (customer:Customer) =
    match customer.CustomerPreferences with
    | Never -> false
    | Everyday -> true
    | DayOfTheWeek dayOfWeek -> if dayOfWeek = date.DayOfWeek then true else false
    | DayOfTheMonth x -> if x = date.Day then true else false 


let customerX = {CustomerID= "X"; CustomerPreferences= DayOfTheWeek DayOfWeek.Monday}
let customerY = {CustomerID= "X"; CustomerPreferences= DayOfTheMonth 6}
let today = DateTime.Now 

let result = contactCustomer today customerY




let CustomerA = {CustomerID ="A"; CustomerPreferences = Everyday}
let CustomerB = {CustomerID ="B"; CustomerPreferences = DayOfTheMonth 6 }
let CustomerC = {CustomerID = "C"; CustomerPreferences = DayOfTheWeek DayOfWeek.Friday }



let customers = [CustomerA ; CustomerB; CustomerC]

let getCustomersForDate (date:DateTime) = 
    customers
    |> List.filter(fun c -> true)
    
[1..90] 
|> List.map(fun x -> DateTime.Now.AddDays (float x) )
|> List.map(fun x -> getCustomersForDate x , x )
|> List.iter(fun (customers,date) -> printfn "%A" date)




