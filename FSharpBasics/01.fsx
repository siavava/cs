
let one = 1

let hello = "hello"

let letterA = 'A'

let isEnabled = true

printfn "%d" one

printfn "%s" hello

let two = 2

printf "%d" two

let nextInt n = n + 1

printfn "%d" (nextInt 2)

let mut x = 0

// recursive appliocations
let rec loop func var lim =
  if var < lim then do
    func(var)
    loop func (var+1) lim

loop (printfn "%d") 0 10 

// function that returns a sum
let add (x: int) (y: int) = x + y

// function that returns a lambda that takes two params and returns a sum
let add' = fun x y -> x + y

// function that takes a param and returns a lambda that takes another param and returns a sum!!
let add'' x = fun y -> x + y

// partial application
let add5 = add 5

printfn "%O" add5       // prints function reference

printfn "%O" (add5 1)   // prints integer

let add1 = add 1
(** add 2 to a number **)
let add2 number = 
  number
  |> add1 
  |> add1

let add3 number =
  number
  |> add1 |> add2

let num = 10

printfn "number: %d" num
printfn "number + 1: %d" (add1 num)
printfn "number + 2: %d" (add2 num)
printfn "number + 3: %d" (num |> add3)

let pow2 number = number ** 2.
