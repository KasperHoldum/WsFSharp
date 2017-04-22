type OpenWalls =
| Top
| Bottom
| Left
| Right
| TopLeft
| TopRight
| TopBottom
| TopLeftRight
| TopLeftBottom
| TopLeftBottomRight
| LeftRight
| LeftBottom
| LeftRightBottom
| BottomRight

type MapSpot =
| Goal
| Free of OpenWalls
| Closed

let map: MapSpot[,] = 
    array2D [|
        [|Closed; Free Top|];
        [|Free Left; Goal|]|]

let startPlayerLoc = [0;1]





let isOpenTop (s : OpenWalls) =
    match s with 
    | _ -> true

let isOpenBottom (s:OpenWalls) = 
    match s with
    | _ -> true

let isOpenRight (s:OpenWalls) =
    match s with
    | _ -> true

let isOpenLeft (s : OpenWalls) =
    match s with
    | Left | TopLeft | TopLeftRight 
    | LeftRightBottom | LeftBottom | LeftRight 
    | TopLeftBottomRight | TopLeftBottom | TopLeftRight -> true
    | _ -> false

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code



