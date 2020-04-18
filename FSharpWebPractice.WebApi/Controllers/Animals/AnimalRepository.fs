namespace FSharpWebPractice.WebApi.Controllers

// [<AutoOpen>]
module AnimalsRepository =
    let all =
        [ { Name = "Fido"
            Species = "Dog" }
          { Name = "Felix"
            Species = "Cat" } ]

    let getAll() = all
    let getAnimal name = all |> List.tryFind (fun r -> r.Name = name)
