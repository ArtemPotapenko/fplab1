module CircleSqr

let sum n = [ 1 .. (n - 1) ] |> List.sum |> (*) n
let res n = seq{for i in 1..n -> 2 * sum i} |> Seq.sum

res 100 |> printf "%d \n"
