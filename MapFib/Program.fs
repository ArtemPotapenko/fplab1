module MapFib

let mutable a = 0I
let mutable b = 1I

let f x y =
    b <- x + y
    a <- y
    b


let res n = 
    [ 0..10000 ]
    |> List.map (fun x ->
        if x = 0 then 0I
        else if x = 1 then 1I
        else f a b) |> List.filter (fun x -> x < pown 10I (n - 1)) |> List.length 
    

res 1000 |> printf "%d \n"
