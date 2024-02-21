module TisburyTreasureHunt

let getCoordinate = snd

let convertCoordinate (coordinate: string) : int * char = (int coordinate[0..0], coordinate[1])

let compareRecords ((_, c1): string * string) ((_, c2, _): string * (int * char) * string) : bool =
    convertCoordinate c1 = c2

let createRecord
    ((n1, c1): string * string)
    ((n2, c2, q): string * (int * char) * string)
    : (string * string * string * string) =
    match compareRecords (n1, c1) (n2, c2, q) with
    | true -> (c1, n2, q, n1)
    | _ -> ("", "", "", "")
