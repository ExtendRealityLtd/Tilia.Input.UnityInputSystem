# Class InputSystemTransformer<TInput, TOutput, TEvent>

Provides an abstract base to transform a given Unity Input System TInput type to the TOutput data type.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [ContextToProcess]

## Details

##### Inheritance

* System.Object
* InputSystemTransformer<TInput, TOutput, TEvent>
* [CallbackContextTransformer<TOutput, TEvent>]
* [InputActionPropertyTransformer<TOutput, TEvent>]

##### Namespace

* [Tilia.Input.UnityInputSystem.Transformation.Conversion]

##### Syntax

```
public abstract class InputSystemTransformer<TInput, TOutput, TEvent> : Transformer<TInput, TOutput, TEvent> where TEvent : UnityEvent<TOutput>, new()
```

##### Type Parameters

| Name | Description |
| --- | --- |
| TInput | n/a |
| TOutput | The variable type that will be used for the input. |
| TEvent | The UnityEvent type the transformation will emit. |

### Properties

#### ContextToProcess

The [InputSystemTransformer<TInput, TOutput, TEvent>.ContextType] event to process the transformation for.

##### Declaration

```
public InputSystemTransformer<TInput, TOutput, TEvent>.ContextType ContextToProcess { get; set; }
```

[CallbackContextTransformer<TOutput, TEvent>]: CallbackContextTransformer-2.md
[InputActionPropertyTransformer<TOutput, TEvent>]: InputActionPropertyTransformer-2.md
[Tilia.Input.UnityInputSystem.Transformation.Conversion]: README.md
[InputSystemTransformer<TInput, TOutput, TEvent>.ContextType]: InputSystemTransformer-3.ContextType.md
[InputSystemTransformer.ContextType]: InputSystemTransformer-3.ContextType.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[ContextToProcess]: #ContextToProcess
