# Class CallbackContextTransformer<TOutput, TEvent>

Provides an abstract base to transform a given InputAction.CallbackContext to the TOutput data type.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Methods]
  * [ProcessResult(InputAction.CallbackContext)]

## Details

##### Inheritance

* System.Object
* [InputSystemTransformer]<InputAction.CallbackContext, TOutput, TEvent>
* CallbackContextTransformer<TOutput, TEvent>
* [CallbackContextToBoolean]
* [CallbackContextToFloat]
* [CallbackContextToVector2]
* [CallbackContextToVector3]

##### Inherited Members

[InputSystemTransformer<InputAction.CallbackContext, TOutput, TEvent>.ContextToProcess]

##### Namespace

* [Tilia.Input.UnityInputSystem.Transformation.Conversion]

##### Syntax

```
public abstract class CallbackContextTransformer<TOutput, TEvent> : InputSystemTransformer<InputAction.CallbackContext, TOutput, TEvent> where TEvent : UnityEvent<TOutput>, new()
```

##### Type Parameters

| Name | Description |
| --- | --- |
| TOutput | The variable type that will be output from the result of the transformation. |
| TEvent | The UnityEvent type the transformation will emit. |

### Methods

#### ProcessResult(InputAction.CallbackContext)

Processes the given input into the output result as long as the context event is allowed to be processed based on the ContextToProcess value.

##### Declaration

```
protected override TOutput ProcessResult(InputAction.CallbackContext input)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InputAction.CallbackContext | input | The value to transform. |

##### Returns

| Type | Description |
| --- | --- |
| TOutput | The transformed value. |

[InputSystemTransformer]: InputSystemTransformer-3.md
[CallbackContextToBoolean]: CallbackContextToBoolean.md
[CallbackContextToFloat]: CallbackContextToFloat.md
[CallbackContextToVector2]: CallbackContextToVector2.md
[CallbackContextToVector3]: CallbackContextToVector3.md
[InputSystemTransformer<InputAction.CallbackContext, TOutput, TEvent>.ContextToProcess]: InputSystemTransformer-3.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputSystemTransformer_3_ContextToProcess
[Tilia.Input.UnityInputSystem.Transformation.Conversion]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Methods]: #Methods
[ProcessResult(InputAction.CallbackContext)]: #ProcessResultInputAction.CallbackContext
