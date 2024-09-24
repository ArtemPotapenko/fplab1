module InfFib


let mutable a = 0I
let mutable b = 1I

let f x y =
    b <- x + y
    a <- y
    b


let res n =
    Seq.initInfinite ((+) 0)
    |> Seq.map (fun x ->
        if x = 0 then 0I
        else if x = 1 then 1I
        else f a b)
    |> Seq.take (10 * n)
    |> Seq.filter (fun x -> x < pown 10I (n - 1))
    |> Seq.length
    

res 1000 |> printf "%d "
