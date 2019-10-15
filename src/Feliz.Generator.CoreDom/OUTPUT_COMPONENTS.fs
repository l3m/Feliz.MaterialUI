namespace Feliz

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open System.ComponentModel
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Feliz

[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]
module HtmlHelpers =

  let reactElement (el: ReactElementType) (props: 'a) : ReactElement =
    import "createElement" "react"

  let reactElementTag (tag: string) (props: 'a) : ReactElement =
    import "createElement" "react"

  let createElement (el: ReactElementType) (properties: IReactProperty seq) : ReactElement =
    reactElement el (createObj !!properties)

  let createElementTag (tag: string) (properties: IReactProperty seq) : ReactElement =
    reactElementTag tag (createObj !!properties)

[<Erase>]
type Html =

  /// Represents a document section that contains interactive controls for submitting information to a web server.
  static member inline form props = createElement form props

  /// Represents a document section that contains interactive controls for submitting information to a web server.
  static member inline form children: #seq<ReactElement> = createElement form Feliz.form.children (children :> ReactElement seq)
