namespace Feliz

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open System
open System.ComponentModel
open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Feliz


[<Erase>]
type prop =
  /// Defines a keyboard shortcut to activate or add focus to the element.
  static member inline accesskey (value: string) = Interop.mkAttr "accesskey" value

module prop =

  /// Controls whether and how text input is automatically capitalized as it is entered/edited by the user.
  [<Erase>]
  type autocapitalize =
    /// No autocapitalization is applied (all letters default to lowercase)
    static member inline none = Interop.mkAttr "autocapitalize" none
    /// Alias for `none`.
    static member inline off = Interop.mkAttr "autocapitalize" off
    /// The first letter of each sentence defaults to a capital letter; all other letters default to lowercase
    static member inline sentences = Interop.mkAttr "autocapitalize" sentences
    /// Alias for `sentences`.
    static member inline on = Interop.mkAttr "autocapitalize" on
    /// The first letter of each word defaults to a capital letter; all other letters default to lowercase
    static member inline words = Interop.mkAttr "autocapitalize" words
    /// All letters should default to uppercase
    static member inline characters = Interop.mkAttr "autocapitalize" characters


[<Erase>]
type form =
  /// Defines the text content of the element.
  static member inline children (elements: Fable.React.ReactElement seq) = Interop.mkAttr "children" (Interop.reactApi.Children.toArray elements)
  /// Defines the text content of the element.
  static member inline children (element: Fable.React.ReactElement seq) = Interop.mkAttr "children" element
  /// List of types the server accepts, typically a file type.
  static member inline accept (value: string) = Interop.mkAttr "accept" value
  /// The URI of a program that processes the information submitted via the form.
  static member inline action (value: string) = Interop.mkAttr "action" value
  /// *Inherited from `prop`*
  ///
  /// Defines a keyboard shortcut to activate or add focus to the element.
  static member inline accesskey (value: string) = Interop.mkAttr "accesskey" value

module form =

  /// *Inherited from `prop`*
  ///
  /// Controls whether and how text input is automatically capitalized as it is entered/edited by the user.
  [<Erase>]
  type autocapitalize =
    /// No autocapitalization is applied (all letters default to lowercase)
    static member inline none = Interop.mkAttr "autocapitalize" none
    /// Alias for `none`.
    static member inline off = Interop.mkAttr "autocapitalize" off
    /// The first letter of each sentence defaults to a capital letter; all other letters default to lowercase
    static member inline sentences = Interop.mkAttr "autocapitalize" sentences
    /// Alias for `sentences`.
    static member inline on = Interop.mkAttr "autocapitalize" on
    /// The first letter of each word defaults to a capital letter; all other letters default to lowercase
    static member inline words = Interop.mkAttr "autocapitalize" words
    /// All letters should default to uppercase
    static member inline characters = Interop.mkAttr "autocapitalize" characters
