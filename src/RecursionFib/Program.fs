module RecursionFib



let rec sum a b n =
    if a + b > pown 10I (n - 1)   then 2 else 1 + (sum b (a + b) n)
let res = sum 0I 1I

res 1000 |> printf "%d \n"
