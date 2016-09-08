// Learn more about F# at http://fsharp.org. See the 'F# Tutorial' project
// for more guidance on F# programming.
#load "Library1.fs"

open SpamOrHam

// Define your library scripting code here
type DocType = 
    | Ham
    | Spam

let identify (example:DocType*string) =
    let docType,content = example
    match docType with
    | Ham -> printfn "'%s' is ham" content
    | Spam -> printfn "'%s' is spam" content