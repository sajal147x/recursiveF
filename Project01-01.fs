module Project01_01

//
// length L
//
// Returns length of L
// 
// Examples: length []  => 0
//           length [1] => 1
//           length [1; 3; 98] => 3
//           length [1; 2; 19; 67] => 4
//           length ['a'; 'b'; 'c'; 'd'; 'e'] => 5
//           length ["List"; "of"; "strings"] => 3
// 
// You may not call List.length directly in your solution.
//

let rec length L =
    match L with
    | [] -> 0
    | _::rest -> 1 + (length rest)//   TO BE IMPLEMENTED


//[<EntryPoint>]
let main argv =
    printfn "Testing Project 01: length"
    let len1 = length []
    if len1 = 0 then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let len2 = length [1]
    if len2 = 1 then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let len3 = length [1; 3; 98]
    if len3 = 3 then
        printfn "Passed!"
    else
        printfn "Failed!"

    let len4 = length ['a'; 'b'; 'c'; 'd'; 'e']
    if len4 = 5 then
        printfn "Passed!"
    else
        printfn "Failed!"

    let len5 = length ["List"; "of"; "strings"]
    if len5 = 3 then
        printfn "Passed!"
    else
        printfn "Failed!"

    printfn ""
    0 // return an integer exit code
