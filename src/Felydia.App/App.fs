module Felydia.App

open Avalonia
open Avalonia.Controls.ApplicationLifetimes
open Avalonia.FuncUI.Hosts
open Avalonia.Themes.Fluent

type App() =
    inherit Application()

    override this.Initialize() = this.Styles.Add(FluentTheme())

    override this.OnFrameworkInitializationCompleted() =
        match this.ApplicationLifetime with
        | :? IClassicDesktopStyleApplicationLifetime as desktop ->
            let window = HostWindow()
            window.Title <- "Felydia"
            window.Width <- 960.0
            window.Height <- 640.0
            window.Content <- MainView.view ()
            desktop.MainWindow <- window
        | _ -> ()

        base.OnFrameworkInitializationCompleted()
