namespace ReportIt.Pages

open Xamarin.Forms
open Xamarin.Forms.Xaml

type Home() =
    inherit ContentPage()

    do base.LoadFromXaml(typeof<Home>) |> ignore
