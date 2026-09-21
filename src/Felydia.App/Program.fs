module Felydia.Program

open Avalonia

[<EntryPoint>]
let main args =
    AppBuilder
        .Configure<App.App>()
        .UsePlatformDetect()
        .StartWithClassicDesktopLifetime(args)
