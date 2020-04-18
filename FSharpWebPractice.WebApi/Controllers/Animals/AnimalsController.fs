namespace FSharpWebPractice.WebApi.Controllers

open Microsoft.AspNetCore.Mvc

[<Route("api")>]
type AnimalsController() =
    inherit ControllerBase()

    [<Route("animals")>]
    member this.Get() = AnimalsRepository.all

    [<Route("animals/{name}")>]
    member this.GetAnimal name: ActionResult =
        match (AnimalsRepository.getAnimal name) with
        | Some result -> this.Ok(result) :> _
        | None -> this.NotFound() :> _
