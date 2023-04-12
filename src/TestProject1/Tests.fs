module Tests

open System
open Xunit
open Minefield
open Minefield.Cell

[<Fact>]
let ``Cell인데 Covered인 경우`` () =
    let sut = Covered Mine
    Assert.Equal(debug sut, "*")

[<Fact>]
let ``Cell인데 Number인 경우`` () =
    let sut = Number 1
    Assert.Equal(debug sut, "1")

[<Fact>]
let ``Cell인데 Mine인 경우`` () =
    let sut = Mine
    Assert.Equal(debug sut, "*")
