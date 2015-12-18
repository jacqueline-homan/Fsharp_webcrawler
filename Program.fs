open System
open System.IO
open MovieNews.Data

let findByTitle title =
    if title = "Interstellar" then
        { Published = DateTime(2014, 11, 5)
          Summary = 
              "In Christopher Nolan's science-fiction parablee " +
              "Interstellar, Earth is dying, and a team of " +
              "astronauts searches the universe for a new home " +
              "for the human race."
          Link = "http://movies.nytimes.com/2014/11/05/movies/interstellar"
          LinkText = "Read the NY Times review" } |> Some
    else None

let reviewOpt = findByTitle "Interstellar"
match reviewOpt with
| Some review -> printfn "%s" review.Summary
| None -> printfn "No review available"


[<EntryPoint>]
let main argv = 
    printfn "Press any key to exit program"
    let user = Console.ReadKey() 
    0 // return an integer exit code

