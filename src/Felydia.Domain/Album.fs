module Felydia.Album

open System
open Felydia.Track

type AlbumId = AlbumId of Guid

type Album =
    { Id: AlbumId
      Title: string
      AlbumArtist: string
      Year: int option
      Cover: byte array option
      Path: string
      Tracks: Track list }

let create title albumArtist path =
    { Id = AlbumId <| Guid.NewGuid()
      Title = title
      AlbumArtist = albumArtist
      Year = None
      Cover = None
      Path = path
      Tracks = [] }
