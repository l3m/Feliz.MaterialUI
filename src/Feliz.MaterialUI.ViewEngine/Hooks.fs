﻿namespace Feliz.MaterialUI

open System.ComponentModel
open Fable.Core
open Fable.Core.JsInterop


[<EditorBrowsable(EditorBrowsableState.Never)>]
module HookImports =

  let useMediaQuery (query: string) : bool =
    importDefault "@material-ui/core/useMediaQuery"

  let useMediaQuery_theme (getQuery: Theme -> string) : bool =
    importDefault "@material-ui/core/useMediaQuery"


[<Erase>]
type Hooks =

  static member inline useMediaQuery (query: string) : bool =
    HookImports.useMediaQuery query

  static member inline useMediaQuery (getQuery: Theme -> string) : bool =
    HookImports.useMediaQuery_theme getQuery
