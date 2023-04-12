namespace Minefield

type Cell = 
    | Covered of Cell
    | Number of int
    | Mine

module Cell =
    let rec debug (cell: Cell) =
        match cell with
        | Covered cell -> debug cell
        | Number n -> string n
        | Mine -> "*"
