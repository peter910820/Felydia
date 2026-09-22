module AlbumTests

open Xunit
open Felydia.Track
open Felydia.Album

[<Fact>]
let ``可建立含曲目與封面的專輯`` () =
    let track =
        { Felydia.Track.create "曲目一" "演出者" "a.mp3" with
            TrackNumber = Some 1 }

    let cover = [| 1uy; 2uy; 3uy |]

    let album =
        { Felydia.Album.create "專輯名" "專輯演出者" @"C:\Music\專輯名" with
            Year = Some 2024
            Cover = Some cover
            Tracks = [ track ] }

    Assert.Equal("專輯名", album.Title)
    Assert.Equal("專輯演出者", album.AlbumArtist)
    Assert.Equal(@"C:\Music\專輯名", album.Path)
    Assert.Equal(Some 2024, album.Year)
    Assert.Equal(Some cover, album.Cover)
    Assert.Equal(1, album.Tracks.Length)
    Assert.Equal("曲目一", album.Tracks.Head.Title)
    Assert.Equal("a.mp3", album.Tracks.Head.Path)
