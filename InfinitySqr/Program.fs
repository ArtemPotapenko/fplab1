module InfSqr
let sum n = [ 1 .. (n - 1) ] |> List.sum |> (*) n

Seq.initInfinite ((+) 1)
|> Seq.map sum
|> Seq.take 100
|> Seq.sum
|> (*) 2
|> printf "%d \n"
