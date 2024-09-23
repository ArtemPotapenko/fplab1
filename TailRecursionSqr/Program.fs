module TailRecursionSqr

let sum n = n * n * (n - 1) / 2

let res n =
    let rec helper k helpSum = helper (k - 1) (helpSum + sum k)
    helper n 0
res 100 |> printf "%d \n"