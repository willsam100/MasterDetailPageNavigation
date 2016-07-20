namespace MasterDetailPage

open System
open Xamarin.Forms
open Xamarin.Forms.Xaml

type MasterPageItem = {
    Title:string 
    IconSource: string
}

//type ContactsPage() =
//    inherit ContentPage()
     
    //do base.Content <- Label(Text = "Hello")


type MasterPage() =
    inherit ContentPage() 

    let _ = base.LoadFromXaml(typeof<MasterPage>)

    let listView = base.FindByName<ListView>("listView")
    let masterPageItems = [{Title = "Contacts"; IconSource = "contacts.png"}]
    do listView.ItemsSource = ((masterPageItems |> List.toSeq) :> Collections.IEnumerable) 
        |> ignore

type MainPage() =
    inherit MasterDetailPage()
    let _ = base.LoadFromXaml(typeof<MainPage>)


type App() = 
    inherit Application(MainPage = MainPage())

