﻿namespace MyApp

open System

type Global() = 
    inherit System.Web.HttpApplication()
    member x.Application_Start (sender:Object, e:EventArgs) = 
          let appHost = new AppHost()
          appHost.Init() |> ignore