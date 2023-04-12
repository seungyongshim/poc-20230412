module Tests

open System
open Xunit
open Minefield
open Minefield.Cell

[<Fact>]
let ``Cell인데 Covered인 경우`` () =
    let sut = Covered Mine
    Assert.Equal(debug sut, "*")

