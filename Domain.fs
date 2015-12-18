namespace MovieNews.Data
open System

type Review =
    { Published : DateTime
      Summary : string
      Link : string
      LinkText : string }

type Cast = 
    { Actor : string
      Character : string }

type MovieBasics =
    { Title : string
      Summary : string
      Thumbnail : option<string> }
     
type MovieDetails =
    { Homepage : string
      Genres : seq<string>
      Overview : string
      Companies : seq<string>
      Poster : string
      Countries : seq<string>
      Released : DateTime
      AverageVote : decimal }

type Movie =
    { Movie : MovieBasics
      Details : MovieDetails
      Review : option<Review>
      Cast : seq<Cast> }





