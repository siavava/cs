namespace FSharpBasics

module Arithmetic =

  module Addition =
    
    let add x y = x + y

    let private add' = 
      fun x y -> x + y

  module Subtraction =

    let sub x y = x - y

  module Multiplication = 
    let mul = (*)

  module Divide =
    let div = (/)

    let mod' x y = x % y

