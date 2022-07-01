// namespace FSharpBasics

// Record type
// tuple
// Anonymous record

//////// RANDOM NUMBER GENERATOR ///
let randomInt () = 
  let rnd = new System.Random()
  rnd.Next(int System.Int16.MaxValue)

let randomIntInRange(low, high) =
  low + randomInt() % (high - low)

printfn "random integer in range: %d" (randomIntInRange (10, 30) )

let rec printRand count =
  if count > 0 then do
    printfn "%O" (randomInt())
    printRand (count-1)


// RECORDS //

type Day = { Date: int; Month: int }
type Person = { Name: string; Age: int}
type Student =
  {
    Name: string
    Age: int
    School: string
    SSN: int
  }

  static member New =
    { 
      Name = ""
      Age = 0
      School = ""
      SSN = 0
    }

  static member With name age school ssn =
    {
      Name = name
      Age = age
      School = school
      SSN = ssn
    }

let today = { Date = 21; Month = 12}

let ben = {Name = "Ben"; Age = 26}

let me = {         // If 2 types have same signature, later definition supercedes earlier.
  Name = "Amittai"
  Age = 20
}

ben.Name
ben.Age

// NOTE: THis returns a new Person record!!
let incrementAge person: Person =
  { person with Age = person.Age + 1 }

printfn "Ben's copy with incremented age: %d" (incrementAge ben).Age
ben.Age

let registerStudent (person: Person) school ssn =
  Student.With person.Name person.Age school ssn

let registerDartmouth (person: Person) =
  registerStudent person "Dartmouth" (randomInt())

let registerYale(person: Person) =
  registerStudent person "Yale" (randomInt())

  

let jon = {Name = "Jon"; Age = 51}
printfn "Jon:\n\t%O" jon

printfn "Jon @ Dartmouth:\n\t%O" (registerDartmouth jon)

printfn "Jon @ Yale:\n\t%O" (registerYale jon)

printfn "Jon:\n\t"

printRand 20


////// TUPLES ///////
(ben, 400, "what else?")

////// ANONYMOUS RECORDS ///////
let duo = {| Person1 = ben; Person2 = me |}
printfn "duo: %O" duo

/// Anon records do not allow pattern matching.
/// BUT... Can add records!

let trio = {| duo with Person3 = ben|}
printfn "trio: %O" trio


/////////// SUM TYPES //////////

type Suit =
  | Hearts
  | Clubs
  | Spades
  | Diamonds

type Rectangle = { _base: double; height: double}

//type Shape =
//  | Rectangle of _base: double * _height: double    // `*` is a tuple!
//  | Triangle of _base: double * _height: double    // `*` is a tuple!
//  | Circle of radius: double

type Shape =
  | Rectangle of Rectangle
  | Triangle of _base: double * height: double
  | Circle of radius: double
  | Dot
  
  static member area shape =
    match shape with
      | Rectangle rect -> rect._base * rect.height
      | Triangle (b, h) -> b * h / 2.
      | Circle r -> r ** 2. * System.Math.PI
      | Dot -> 0.


//////// function keyword /////////

let isOdd x =
  x % 2 = 1

let isOdd' x =
  match x % 2 with
    | 0 -> false
    | _ -> true

let fizz x =
  if x % 15 = 0 then "FizzBuzz"
  else if x % 5 = 0 then "Buzz"
  else if x % 3 = 0 then "Fizz"
  else "unknown"

let fizz' =
  function
    | 3 -> "Fizz"
    | 5 -> "Buzz"
    | 15 -> "FizzBuzz"
    | _ -> "unknown"

let fizz'' x = do
  let str: string = ""
  if x % 3 = 0 then sprintf str "%s%s" str "Fizz"
  if x % 5 = 0 then sprintf "%s%s" str str "Fizz"

let buzz =
  function
    | "Fizz" -> string 3
    | "Buzz" -> string 5
    | "FizzBuzz" -> string 15
    | _ -> string System.Math.PI

for i in 1 .. 20 do
  let v = fizz i
  let b = buzz v
  printfn "\n%d -> %s -> %s\n" i v b
    
type OrderId = OrderId of int

let incrementOrderId (OrderId id) =
  OrderId <| id + 1

let id = OrderId 1

let incrId = incrementOrderId id

printfn "%O after increment = %O" id incrId

//// Shapes again /////

let c = Circle 7
let c_area = Shape.area c
printfn "Circle area = %f" c_area

let r = Rectangle {_base = 2.0; height = 3.0}
let r_area = Shape.area r
printfn "Rectangle area = %f" r_area

let d = Dot
let d_area = Shape.area d
printfn "Dot area = %f" d_area

//////// Optional DATA ////////

// NOTE: 'a -> dynamically resolved, generic
// NTOE: ^a -> statically resolved, generic
type Option<'a> =
  | Some of 'a
  | None

let translateFizzBuzz = function
  | "Fizz" -> Some 3
  | "Buzz" -> Some 5
  | "FizzBuzz" -> Some 15
  | _ -> None

let inline add x y = x + y




seq [1; 2; 3]

let arr = [|1 .. 10|]
printfn "%A" arr

arr.[0] <- 21

printfn "%A" arr

let list = []   /// empty constructor
let addToList x xs =
  x :: xs

let list2 = [1;2;3]
addToList 1 list2

let getFirstItem list = function
  | x::_ -> Some x
  | _ -> None

let getFirstItem' list =
  List.head list

let x: int list = List.head []

let rec printEveryItem = function
  | x::xs ->
    printfn "%O" x
    printEveryItem xs
  | [] -> ()

let list3 = [1 .. 4]
printEveryItem list3
