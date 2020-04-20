module QueenAttack

module QueenAttack

let create (position: int * int) =
    let (x, y) = position
    let inrange r = (>=) 7 r && (<=) 0 r
    (inrange x) && (inrange y)


let canAttack (queen1: int * int) (queen2: int * int) =
    let (x1, y1) = queen1
    let (x2, y2) = queen2
    (create queen1) && (create queen2) && ((x1 = x2) || (y1 = y2) || (abs (x1 - x2) = abs (y1 - y2)))
