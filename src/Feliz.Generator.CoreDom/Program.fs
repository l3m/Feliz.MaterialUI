module Program

open System.IO
open Feliz.Generator


let flip f x y = f y x


let addChildrenComponentOverload (comp: Component) =
  comp
  |> Component.addOverload (
      ComponentOverload.create "children: #seq<ReactElement>" (sprintf "Feliz.%s.children (children :> ReactElement seq)" comp.MethodName)
  )


let addChildrenProp =
  Component.addProp (
    Prop.create "children" "children"
    |> Prop.setDocs ["Defines the text content of the element."]
    |> Prop.addRegularOverload (RegularPropOverload.create "(elements: Fable.React.ReactElement seq)" "(Interop.reactApi.Children.toArray elements)")
    |> Prop.addRegularOverload (RegularPropOverload.create "(element: Fable.React.ReactElement seq)" "element")
    // TODO: more children prop overloads
  )


let standardStringPropOverload = RegularPropOverload.create "(value: string)" "value"


let components = [
  
  // Meta component without overloads, only used for global props (will not appear in Html.fs)
  Component.createTag "prop" "NOT_USED"
  |> Component.removeDefaultOverload
  |> Component.addProp (
      Prop.create "accesskey" "accesskey"
      |> Prop.setDocs ["Defines a keyboard shortcut to activate or add focus to the element."]
      |> Prop.addRegularOverload standardStringPropOverload
  )
  |> Component.addProp (
    Prop.create "autocapitalize" "autocapitalize"
    |> Prop.setDocs ["Controls whether and how text input is automatically capitalized as it is entered/edited by the user."]
    |> Prop.addEnumOverload (EnumPropOverload.create "none" "none" |> EnumPropOverload.setDocs ["No autocapitalization is applied (all letters default to lowercase)"])
    |> Prop.addEnumOverload (EnumPropOverload.create "off" "off" |> EnumPropOverload.setDocs ["Alias for `none`."])
    |> Prop.addEnumOverload (EnumPropOverload.create "sentences" "sentences" |> EnumPropOverload.setDocs ["The first letter of each sentence defaults to a capital letter; all other letters default to lowercase"])
    |> Prop.addEnumOverload (EnumPropOverload.create "on" "on" |> EnumPropOverload.setDocs ["Alias for `sentences`."])
    |> Prop.addEnumOverload (EnumPropOverload.create "words" "words" |> EnumPropOverload.setDocs ["The first letter of each word defaults to a capital letter; all other letters default to lowercase"])
    |> Prop.addEnumOverload (EnumPropOverload.create "characters" "characters" |> EnumPropOverload.setDocs ["All letters should default to uppercase"])
  )
  // TODO: Add other other global attributes similarly

  // Form
  Component.createTag "form" "form"
  |> Component.setDocs ["Represents a document section that contains interactive controls for submitting information to a web server."]
  |> Component.inheritsPropsFrom "prop"
  |> addChildrenProp
  |> addChildrenComponentOverload
  |> Component.addProp (
      Prop.create "accept" "accept"
      |> Prop.setDocs ["List of types the server accepts, typically a file type."]
      |> Prop.addRegularOverload standardStringPropOverload
  )
  |> Component.addProp (
    Prop.create "action" "action"
    |> Prop.setDocs ["The URI of a program that processes the information submitted via the form."]
    |> Prop.addRegularOverload standardStringPropOverload
  )
  // TODO: Other form props

  // TODO: other components
]


let api =
  (ComponentApi.create "Feliz" "Html", components)
  ||> List.fold (flip ComponentApi.addComponent)


[<EntryPoint>]
let main argv =
  File.WriteAllText(@"..\..\..\OUTPUT_COMPONENTS.fs", Render.componentDocument api)
  File.WriteAllText(@"..\..\..\OUTPUT_PROPS.fs", Render.propsDocument api)
  0
