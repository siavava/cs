

// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"


let (|Positive|Negative|Zero|) num =
  if num > 0.0 then Positive
  elif num < 0.0 then Negative
  else Zero


let Sign value =
  match value with
  | Positive -> printf "%A is positive.\n" value
  | Negative -> printf "%A is negative.\n" value
  | Zero -> printf "%A is zero.\n" value

Sign -12
Sign 0
Sign 25
Sign 12.05

let rec fib n =
  if n <= 1 then n 
  else fib (n-1) + fib (n-2)

let rec allFib n =
  match n with
  | 0 -> printfn "%d" (fib n)
  | _ -> do 
    printfn "%d" (fib n) 
    allFib (n - 1)

allFib 20

let rec Even x =
  if x = 0 then true
  elif x = 1 then false
  else Odd (x - 1)
and Odd x =
  if x = 1 then true
  elif x = 0 then false
  else Even (x - 1)

printfn "2301 is even? %b" (Even 2301)
printfn "2301 is odd? %b" (Odd 2301)

let fibEven = fib >> Even
let fibOdd = fib >> Odd

let checkFib n =
  if fibEven n 
    then printfn "Fibonacci num %d is %d and it's even." n (fib n)
  else 
    printfn "Fibonacci num %d is %d and it's odd." n (fib n)


for num in 0 .. 20 do
  checkFib num

type Cat() =
  member this.Walk() = printfn "Cat walks."

type Dog() =
  member this.Walk() = printfn "Dog walks."

let adapterExample() =
  let cat = Cat()
  let dog = Dog()

  let inline walk(x: ^T) = (^T: (member Walk : unit->unit) x)

  walk(cat)
  walk(dog)

adapterExample()

let incrementer(n: int ref) = do

  n.Value <- n.Value + 1

  printfn "n is %d" n.Value


let n = ref 0
for step in 0 .. 20 do
  incrementer n
