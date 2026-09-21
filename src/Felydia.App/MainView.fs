module Felydia.MainView

open Avalonia.Controls
open Avalonia.FuncUI
open Avalonia.FuncUI.DSL

let view () =
    Component(fun _ ->
        StackPanel.create
            [ StackPanel.spacing 12.0
              StackPanel.children
                  [ TextBlock.create [ TextBlock.text "Felydia"; TextBlock.fontSize 28.0 ]
                    TextBlock.create [ TextBlock.text "音樂庫" ] ] ])
