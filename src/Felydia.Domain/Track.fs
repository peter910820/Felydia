module Felydia.Track

open System

type TrackId = TrackId of Guid

type Track =
    { Id: TrackId
      Title: string
      Artist: string
      TrackNumber: int option
      DiscNumber: int option
      Path: string
      Duration: TimeSpan option }

let create title artist path =
    { Id = TrackId <| Guid.NewGuid()
      Title = title
      Artist = artist
      TrackNumber = None
      DiscNumber = None
      Path = path
      Duration = None }
