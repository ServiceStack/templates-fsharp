namespace MyApp
    open ServiceStack
    open ServiceStack.Common
    open MyApp
    open MyApp.ServiceInterface
    open System

    type AppHost() = 
        inherit AppHostBase("MyApp", typeof<MyServices>.Assembly)
        override this.Configure container =
            //Add plugins
            //this.Plugins.Add(new CorsFeature())
            this.Plugins.Add(new PostmanFeature())