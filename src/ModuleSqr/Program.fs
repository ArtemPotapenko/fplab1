module ModuleSqr

let sum n = [ 1 .. (n - 1) ] |> List.sum |> (*) n
let res n = [ 1..n ] |> List.fold (fun acc k -> acc +  2 * sum (k - 1)) 0

res 100 |> printf "%d \n"