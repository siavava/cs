

// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"


let (|Positive|Negative|Zero|) num =
  if num > 0 then Positive
  elif num < 0 then Negative
  else Zero


let Sign value =
  match value with
  | Positive -> printf "%d is positive.\n" value
  | Negative -> printf "%d is negative.\n" value
  | Zero -> printf "%d is zero.\n" value

Sign -12
Sign 0
Sign 25