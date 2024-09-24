module TailFib
let rec sum a b count n =
    if a + b > pown 10I (n - 1)   then count else (sum b (a + b) (count + 1) n)
let res = sum 0I 1I 2

res 1000 |> printf "%d \n"