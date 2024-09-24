module TailRecursionSqr

let sum n = n * n * (n - 1) / 2

let res n =
    let rec helper k helpSum = if k = 0 then helpSum else helper (k - 1) (helpSum + 2 * sum k)
    helper n 0
res 100 |> printf "%d \n"