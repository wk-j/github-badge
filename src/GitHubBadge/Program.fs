open System

[<EntryPoint>]
let main argv =
    let options = argv |> List.ofArray
    match options with
    | [repo] ->
        let template =
            "[![GitHub release](https://img.shields.io/github/release/wk-j/{repo}.svg?style=social)](https://github.com/wk-j/{repo}/releases)"
                .Replace("{repo}", repo)
                .Replace("\n", "")
                .Trim()
        printfn "%s" template
        0
    | _ -> -1
