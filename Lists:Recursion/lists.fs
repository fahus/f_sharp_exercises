
 //lists

let list1 = [1;2;3;4]

let result =
    list1 
    |> List.map( fun x -> x * 3)
    |> List.filter(fun x -> if x % 2 = 0 then true else false)  
Seq.exists
List.exists
Array.exists
let c = "Hello"
c.Split
  

let list2 = ["a";"b";"c";"a"]
let result1 = 
    list2 
    |> List.countBy(fun x -> x)

type DuOfTypes = 
    | MyInt of int 
    | MyString of string 
    | MyDecimal of float 

let list3 = 
    [ MyInt 3;
      MyString "a"
      MyDecimal 4.0;
    ]

let result2 = 
    list3 
    |> List.map(fun x ->
        match x with 
        |MyInt i -> MyInt (i + 2)
        |MyString c -> MyString ("two" + c)
        |MyDecimal f -> MyDecimal (f + 2.0) 
        ) 

//List exercises


//last element in a list

let list1 = [1; 2; 3; 4]

let result1 xy = 
    xy 
    |> List.rev 
    |> List.head 


//last element in a list using ranges 

let list2 = ['a'..'e']

let result2 xy =
    xy
    |> List.rev
    |>List.tail
    |> List.head 


// find given element of a list, first element is 1 

let list3 = [1; 2; 3] 2;;


let list3 xs n = List.nth xs (n-1)



    

