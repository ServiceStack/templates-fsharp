namespace MyApp
    open ServiceStack
    open ServiceStack.Common
    open System
    open MyApp.ServiceInterface

    type AppHost() = 
        inherit AppSelfHostBase("MyApp", typeof<MyServices>.Assembly)
        override this.Configure container =
            //Add plugins
            //this.Plugins.Add(new CorsFeature())
            this.Plugins.Add(new PostmanFeature())