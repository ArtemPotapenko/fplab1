module MapSqr

let sum n = [ 1 .. (n - 1) ] |> List.sum |> (*) n
[ 1..100 ] |> List.map sum |> List.sum |> (*) 2 |> printf "%d \n"

