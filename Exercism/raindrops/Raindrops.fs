module Raindrops

let sounds = Map.empty.Add(7, "Plong ").Add(5, "Plang ").Add(3, "Pling ")

let raindrop (number : int) =
 sounds
  |> Map.filter (fun factor _ -> number % factor = 0)
  |> (fun sounds ->
    if Map.isEmpty sounds then number.ToString()
    else Map.fold (fun state _ value -> state + value) " " sounds
  )


