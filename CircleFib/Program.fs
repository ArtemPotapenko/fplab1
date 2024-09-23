module CircleFib



let mutable a = 0I
let mutable b = 1I

let f x y =
    b <- x + y
    a <- y
    b

let res n =
    seq { for i in 0 .. 10 * n -> (fun i -> if i = 1 then 1I else if i = 0 then 0I else f a b) i }
    |> Seq.filter (fun x -> x < pown 10I (n - 1))
    |> Seq.length

res 1000 |> printf "%d"
