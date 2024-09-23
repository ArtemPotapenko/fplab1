module ModuleFib

let mutable a = 0I
let mutable b = 1I

let f x y =
    b <- x + y
    a <- y
    b

let fib n =
    [ 0 .. 10 * n ]
    |> List.map (fun x ->
        if x = 0 then 0I
        else if x = 1 then 1I
        else f a b)

let res n =
    let arr = fib n

    [ 1 .. 10 * n ]
    |> List.fold (fun acc x -> if arr[x] < pown 10I (n - 1) then acc + 1 else acc) 1

res 1000 |> printf "%d"
