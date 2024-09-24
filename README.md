# Лабораторная работа №1

## Потапенко Артем 336773. Вариант 6, 25

## Задача 6

Найти разность между суммой квадратов первых ста натуральных чисел и квадратом суммы

## Задача 25

Найти индекс первого члена в последовательности Фибоначчи, который должен содержать 1000 цифр.

### Релиазицая на C#

Задача 6

```C#
   int sum = 0;
        for (int i = 0; i <= 100; i++)
        {
            for (int j = 0; j < i; j++)
            {
                sum += j * i * 2;
            }
        }   
        Console.WriteLine(sum);
```

Задача 25

```C#
public static void Main(string[] args)
    {
        BigInteger a = 0;
        BigInteger b = 1;
        int count = 1;
        while (b.ToString().Length < 1000)
        {
            count++;
            b = BigInteger.Add(a, b);
            a = BigInteger.Subtract(b, a);
        }

        Console.WriteLine(count);
    }
```
### Реализация Хвостовой рекурсией

Задача 6

Функция sum высчитывает все парные произведения чисел от 1 до n.
С помощью хвостовой рекурсии высчитываем все удвоенные суммы.

```F#
let sum n = n * n * (n - 1) / 2

let res n =
    let rec helper k helpSum = if k = 0 then helpSum else helper (k - 1) (helpSum + 2 * sum k)
    helper n 0
res 100 |> printf "%d \n"
```

Задача 25

Функция sum принимает в качестве первых двух аргументов числа Фибоначи, таким образом рекурсивно можем пересчитывает следующие числа и увеличивать
счетчие найденных чисел с меньшим количеством знаков.

```F#
let rec sum a b count n =
    if a + b => pown 10I (n - 1)   then count else (sum b (a + b) (count + 1) n)
let res = sum 0I 1I 2

res 1000 |> printf "%d \n"
```

