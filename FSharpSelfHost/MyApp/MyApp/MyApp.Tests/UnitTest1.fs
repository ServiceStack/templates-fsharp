﻿namespace MyApp.Tests

open NUnit.Framework
open FsUnit
open Funq
open ServiceStack
open ServiceStack.Testing
open MyApp.ServiceInterface
open MyApp.ServiceModel

[<TestFixture>] 
type UnitTests ()=
    let mutable appHost = new BasicAppHost(typeof<MyServices>.Assembly)
    //Register dependencies
    let configContainer (c: Container)=
        ignore()
    
    [<OneTimeSetUp>]
    member x.Init ()=
        appHost <- new BasicAppHost(typeof<MyServices>.Assembly)
        appHost.ConfigureContainer <- (fun c -> configContainer(c))
        appHost.Init() |> ignore

    [<OneTimeTearDown>]
    member x.CleanUp ()=
        appHost.Dispose()

    [<Test>] 
    member x.HelloWorld ()=
        let service = appHost.Resolve<MyServices>()
        let req = new Hello(Name = "World")
        let response = service.Any req
        response.Result |> should equal "Hello, World!"