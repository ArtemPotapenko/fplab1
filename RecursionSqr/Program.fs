module RecursionSqr

let sum n = n * n * (n - 1) / 2
let rec result n = if n = 1 then 0 else result (n - 1) + 2 * sum n

result 100 |> printf "%d \n"