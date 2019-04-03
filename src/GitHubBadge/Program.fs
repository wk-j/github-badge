open System

"""
![GitHub release](https://img.shields.io/github/release/wk-j/github-badge.svg?style=flat-square)
""" |> ignore

[<EntryPoint>]
let main argv =
    let options = argv |> List.ofArray
    match options with
    | [repo] ->
        let template =
            "[![GitHub release](https://img.shields.io/github/release/wk-j/{repo}.svg)](https://github.com/wk-j/{repo}/releases)"
                .Replace("{repo}", repo)
                .Replace("\n", "")
                .Trim()
        printfn "%s" template
        0
    | _ -> -1
