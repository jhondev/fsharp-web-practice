﻿namespace FSharpWebPractice.WebApi.Controllers

open System
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open FSharpWebPractice.WebApi

[<ApiController>]
[<Route("[controller]")>]
type WeatherForecastController(logger: ILogger<WeatherForecastController>) =
    inherit ControllerBase()

    let summaries =
        [| "Freezing"; "Bracing"; "Chilly"; "Cool"; "Mild"; "Warm"; "Balmy"; "Hot"; "Sweltering"; "Scorching" |]

    [<HttpGet>]
    member __.Get(): WeatherForecast [] =
        let rng = System.Random()
        [| for index in 0 .. 4 ->
            { Date = DateTime.Now.AddDays(float index)
              TemperatureC = rng.Next(-20, 55)
              Summary = summaries.[rng.Next(summaries.Length)] } |]
