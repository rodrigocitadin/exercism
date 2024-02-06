module ValentinesDay

type Approval =
    | Yes
    | No
    | Maybe

type Cuisines =
    | Korean
    | Turkish

type Genre =
    | Crime
    | Horror
    | Romance
    | Thriller

type Activity =
    | BoardGame
    | Chill
    | Movie of Genre
    | Restaurant of Cuisines
    | Walk of int

let rateActivity (activity: Activity) : Approval =
    match activity with
    | Movie Romance -> Yes
    | Restaurant Korean -> Yes
    | Restaurant Turkish -> Maybe
    | Walk w when w < 3 -> Yes
    | Walk w when w < 5 -> Maybe
    | _ -> No
