namespace ReportIt

open Xamarin.Forms
open Xamarin.Forms.Xaml

open ReportIt.Pages

type App() as this =
    inherit Application()
    
    do this.Initialize()

    member this.Initialize() =
        this.MainPage <- NavigationPage(Home())