
//add item to the front of list


let addfront x = x::[2;3;4]



//remove last in array

let rec removelast alist = 
    match alist with
    | [] -> []
    | x::[] -> [] 
    | x::y -> x::(removelast y)
    


// calculates sum of list 
let rec sum alist =
match alist with
| [] -> 0
| x::y -> x + sum y

      

// adding first item to list despite head value

let rec addfirst item alist =
    match alist with 
    | [] -> []
    | x::y -> item::x::y
    
    // removing item passed through in a list 
   let rec removeitem item alist =
     match alist with 
    | [] -> []
    | x::y -> if item = x
    then removeitem item y 
    else x::(removeitem item y)


// replacing number in a list through index values 
let rec replace index num alist =
match index, alist with
| 0, x::xs -> num::xs
| index, x::xs -> x :: replace (index - 1) num xs
| index, [] -> failwith "not valid int - out of range"




 // outputs if integer is even or false e.g 2 Even -> true 3 Even -> false vise versa

let rec Even x = 
  if x = 0 then true 
  else Odd (x-1) 
  and Odd x =       if x = 0 then false 
  else Even (x-1)


// finds the length of items in a list 
    let rec lengthoflist alist =
     match alist with
    | [] -> 0
    | [ _ ] -> 1
    | _ :: y -> 1 + lengthoflist y
            

// adds item passed through to the end of a given list  

  let rec addlast (item:int) alist  =
     match alist with 
     |[] -> [item] 
     |x::y -> x::(addlast item y)



// subst number by index value
  let rec replace index num alist =
   match index, alist with
  | 0, x::xs -> num::xs
  | index, x::xs -> x :: replace (index - 1) num xs



// replace first element in a list
  let replaceHead item list = 
  match list with
  | _ :: y -> item :: y
  | [] -> [item]


// repeat item number with new value

let rec repeatIf item alist =                            
    match alist with 
    | [] -> []
    | x::[] -> if item = x
              then x::x::[] 
               else x::[]
    | x::y -> if item = x 
              then x::x::y
              else x::(repeatIf item y)

    

// subst number by index value
  let rec replace index num alist =
      match index, alist with
      | 0, x::xs -> num::xs
      | index, x::xs -> x :: replace (index - 1) num xs


//    // does item occur in list?

   let rec occurs value = function
    | x::xs when x = value -> true
    | x::xs -> occurs value xs
    | [] -> false;;



   // does item occur in list 
   let rec occurs (item alist) =
    match alist with
   | [] -> 0
   | x::y when item=x -> 1 + occurs(item, y)
   | x::y ->occurs(item, y)


      // does item occur in list tuples
       let rec occurs (item, alist) =
       match alist with
       | [] -> 0
       | x::y when item=x -> 1 + occurs(item, y)
       | x::y ->occurs(item, y)





  // does item occur in list 
        let rec occurs item alist =
        match alist with
       | [] -> 0
       | x::y when item=x -> 1 + occurs item y
       | x::y ->occurs item y


    

// insert to the right item in list


let rec moveRight index alist =
   match index, alist with
   | -1, _ -> alist
   | 0, x1::x2::y -> x2::x1::y
   | index, x::y -> x::moveRight (index - 1) y
   | _, [] -> alist


//let rec subst old n alist = 
    match alist with 
    |[] -> []
    |x::[] -> if old = x 
              then n::[]
             else x::[]

    |x::y -> if old = x 
             then n::(subst old n y)
             else x::(subst old n y)
                                               

                                              


  // insert item to the right
 let rec insertR old n alist = 
     match alist with 
     |x::[] -> if old = x 
               then x::n::[]
               else x::[]

    |x::y -> if old = x 
             then x::n::(insertR old n y)
             else x::(insertR old n y)
      



// tail call reccursion 

//sum

let sum alist =
  let rec sum alist result =
     match alist with
    | [] -> result
    | x::y -> sum y (result + x )
      



  // multiply 

  let multiply alist =
      let rec multiply alist result =
        match alist with
         | [] -> result
        | x::y -> multiply y (result * x)
        
     


// subsitute
let rec subst old n alist =
  let rec subst old n alist (result: int list) = 
      match alist with 
      |[] -> result
      |x::[] -> if old = x 
                then n::result
                else x::result 

      |x::y -> if old = x 
                then (subst old n y (n::result)) 
                else (subst old n y (x::result))


subst old n alist []

|> List.rev
                                               

                                                                                  