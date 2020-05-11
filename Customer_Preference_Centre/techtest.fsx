
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
    


let CustomerA = {CustomerID = "A"; CustomerPreferences = Everyday}
let CustomerB = {CustomerID ="B"; CustomerPreferences = DayOfTheMonth 15 }
let CustomerC = {CustomerID = "C"; CustomerPreferences = DayOfTheWeek DayOfWeek.Friday }


let customers = [CustomerA ; CustomerB; CustomerC]

let getCustomersForDate (date:DateTime) (customers:Customer list) = 
    customers
    |> List.filter(fun c -> contactCustomer date c)

    

let format (date:DateTime) = date.ToString("ddd dd-MMM-yyyy")
new DateTime(2019,08,11) |> format

let report (date:DateTime) (selectedCustomers: Customer list) =
    let customerIDs =
        selectedCustomers |> List.map(fun c -> c.CustomerID)
    let formattedDate = format date
    let formattedCustomerID = String.Join(" , " , customerIDs)
    printfn "%s  %s " formattedDate formattedCustomerID
    
    
[1..90] 
|> List.map(fun x -> DateTime.Now.AddDays (float x) )
|> List.map(fun x -> getCustomersForDate x customers, x )
|> List.iter(fun (selectedCustomers,date) -> report date selectedCustomers)




