namespace MyApp.ServiceInterface

open ServiceStack
open MyApp.ServiceModel

type MyServices() = 
    inherit Service()
    member this.Any(request : Hello) = { Result = "Hello, {0}!".Fmt(request.Name) }