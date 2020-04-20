// Cardinal directions, each with a number of meters in that direction
type Direction =
  | East  of int 
  | North of int 
  | West  of int 
  | South of int 

// function toGridPosition
// Takes a Direction value, and returns an X,Y coordinate as a tuple
// Examples:
// toGridPosition (East 20)  = (20, 0)
// toGridPosition (North 5)  = (0, 5)
// toGridPosition (South 12) = (0, -12)
// toGridPosition (West 8)   = (-8, 0)
// Type: Direction -> int * int

     ____ write your implementation here __

    type Direction =
      | East  of int 
      | North of int 
      | West  of int 
      | South of int 

 let treasureMap = [ East 20 
                     North 5
                     South 12
                     West 8]


   let toGridPosition dir =
     match dir with
     | East x -> (x,0) 
     | North x -> (0,x)
     | South x -> (0, -x)
     | West x -> (-x ,0)

     



// function addToPosition
// Takes a Direction and an X,Y tuple and adds the direction to the X,Y tuple
// Examples:
// addToPosition (East 20) (10, 10) = (30, 10)
// addToPosition (North 5) (8, -10) = (8, -5)
// addToPosition (South 5) (20, -4) = (20, -9)
// Type: Direction -> (int * int) -> int * int



type Direction =
  | East  of int
  | North of int 
  | West  of int 
  | South of int 

     ____ write your implementation here _____
let treasureMap = [ East 20
                    North 10
                    East 14
                    South 50 ]

                    

                    let toGridPosition dir =
                      match dir with
                      | East x -> (x,0) 
                      | North x -> (0,x)
                      | South x -> (0, -x)
                      | West x -> (-x ,0)



                let addTuples aTuple twoTuple =
                   let (x,y) = aTuple
                   let (a,b) = twoTuple
                   (x+a, b+y)
                     // create a new one
                     
                let addToPositon dir pos =
                    let (x,y) = pos                   
                    match dir with 

                    | East c -> (c+x,y) 
                    | North c -> (x,c+y)
                    | South c -> (x,y-c)
                    | West c -> (x-c ,y) 

                    let addToPosition dir pos =
                        let result = toGridPosition dir 
                        let (x,y) = pos
                        let (a,b) = result
                        (x+a, b+y)
              

                        let addTuples aTuple twoTuple =
                           let (x,y) = aTuple
                           let (a,b) = twoTuple
                           (x+a, b+y) 

                           let addToPosition dir pos =
                               let result = toGridPosition dir 
                               let foo = addTuples result pos
                               foo 
                        



  
// Given a list of directions and a starting point (X,Y) this function follows
// the directions and returns the final position
// Example:
// findPosition treasureMap (0,0) = (34, -40)
// findPosition treasureMap (-50,100) = (-16, 60)
    // ____ write your implementation here _____

    // East 20 (0,0) -> (20,0)
    // North 10 (20,0) (20,10)
    // East 14  (20,10) (34,10
    // South 50  (34,10) (34,-40)





 let treasureMap = [ East 20
                      North 10
                       East 14
                       South 50 ]

    type Direction =
    | East  of int 
    | North of int 
    | West  of int 
    | South of int


 let rec findPosition treasureMap startingPoint =
       let first = List.head treasureMap 
       let (x,y) = List.head treasureMap 

        



        //Direction from treasureMap list
        //List.head treasureMap
        //direction 1 = List.head treasureMap
        //direction 1 startingpoint -> adding value depending on direction (20,0)
        //direction2 (20,0) -> newstartingpoint 
        //direction3 newstartingpoint -> value2

        //List.head treasureMap;;
       

        





        //let addToPosition dir pos =
            //let result = toGridPosition dir 
            //let foo = addTuples result pos
            //foo 



      //List.fold (fun x y -> x+ y)           
      // East 20 (0,0) -> (20,0) 
      // North 10 (20,0) (20,10)
      // East 14  (20,10) (34,10)
      // South 50  (34,10) (34,-40)
