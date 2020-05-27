open System


type CustomerPreferences = 
| Never 
| Everyday
| DayOfTheMonth of int
| DaysOfTheWeek of DayOfWeek list


type Customer =
    {CustomerID : string
     CustomerPreferences: CustomerPreferences} 



let contactCustomer (date: DateTime) (customer:Customer) =
    match customer.CustomerPreferences with
    | Never -> false
    | Everyday -> true
    | DaysOfTheWeek daysOfWeek ->  daysOfWeek |> List.exists(fun day -> day = date.DayOfWeek ) 
    | DayOfTheMonth x -> if x = date.Day then true else false 
    

    
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
    printfn "%s %s" formattedDate formattedCustomerID




let ninetyDayReport input  = 
    [1..90] 
    |> List.map(fun x -> DateTime.Now.AddDays (float x) )
    |> List.map(fun x -> getCustomersForDate x input, x )
    |> List.iter(fun (selectedCustomers,date) -> report date selectedCustomers)

 
let CustomerA = {CustomerID = "A"; CustomerPreferences = Everyday}
let CustomerB = {CustomerID ="B"; CustomerPreferences = DayOfTheMonth 15 }
let CustomerC = {CustomerID = "C"; CustomerPreferences = DaysOfTheWeek [DayOfWeek.Friday] }


let customers = [CustomerA ; CustomerB; CustomerC]
//ninetyDayReport customers



//let input = """A,DayOfTheMonth,2
//B,DayOfTheWeek,Mon Wed Friday
//C,Everyday
//D,Never"""



//let splitInput = input.Split '\n' |> List.ofArray 


//let customerAString = "A,DayOfTheMonth,2" 
//let result =  customerAString.Split ',' |> List.ofArray


//[|"A"; "DayOfTheMonth"; "2"|]


let convertAbreviation (dayOfWeekAbreviated:string)   =
    match dayOfWeekAbreviated with 
    |"Mon"| "Monday" -> DayOfWeek.Monday     
    |"Tue" -> DayOfWeek.Tuesday
    |"Wed" -> DayOfWeek.Wednesday
    |"Thu" -> DayOfWeek.Thursday  
    |"Fri"|"Friday" -> DayOfWeek.Friday 
    |"Sat" -> DayOfWeek.Saturday
    |"Sun" -> DayOfWeek.Sunday
    |_ -> sprintf "Could not find day of week : %s" dayOfWeekAbreviated |> failwith





let matchPreferenceWithDU (specificPreference:string) (detail:string option) = 
    match specificPreference,detail with
    |"DayOfTheMonth",Some d -> System.Convert.ToInt32(d) |> DayOfTheMonth
    |"DayOfTheWeek", Some d-> d.Split ' ' |> List.ofArray |> List.map ( fun w -> convertAbreviation(w)) |> DaysOfTheWeek 
    |"Everyday", None -> Everyday
    |"Never", None-> Never 
    | _-> sprintf "Could not find specific preference : %s" specificPreference |> failwith 


let input = (System.IO.File.ReadAllText("/Users/fhussein/f_sharp_exercises_github/Customer_Preference_Centre/input.txt"))
 
   
let makeCustomerFromList (input:string list) :Customer = 
    let customerID =  
         List.head input //B
    let preferences = List.tail input //DOW ; M W F
    let specificPreference = List.head preferences //DOW
    let detail = List.tryItem 1 preferences //M W F
    let customerPreference = matchPreferenceWithDU specificPreference detail
    {CustomerID = customerID; CustomerPreferences = customerPreference }

let inputCustomers :Customer list = 
    input.Split '\n' 
    |> List.ofArray
    |> List.map(fun s -> s.Split ',' |> List.ofArray)
    |> List.map(fun s -> makeCustomerFromList s )

ninetyDayReport inputCustomers








