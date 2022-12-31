# Class CallbackContextToVector2

Transforms a InputAction.CallbackContext to a Vector2.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Methods]
  * [Process(InputAction.CallbackContext)]

## Details

##### Inheritance

* System.Object
* [InputSystemTransformer]<InputAction.CallbackContext, Vector2, [CallbackContextToVector2.UnityEvent]\>
* [CallbackContextTransformer]<Vector2, [CallbackContextToVector2.UnityEvent]\>
* CallbackContextToVector2

##### Inherited Members

[CallbackContextTransformer<Vector2, CallbackContextToVector2.UnityEvent>.ProcessResult(InputAction.CallbackContext)]

[InputSystemTransformer<InputAction.CallbackContext, Vector2, CallbackContextToVector2.UnityEvent>.ContextToProcess]

##### Namespace

* [Tilia.Input.UnityInputSystem.Transformation.Conversion]

##### Syntax

```
public class CallbackContextToVector2 : CallbackContextTransformer<Vector2, CallbackContextToVector2.UnityEvent>
```

### Methods

#### Process(InputAction.CallbackContext)

Transforms the given input InputAction.CallbackContext to the equivalent Vector2 value.

##### Declaration

```
protected override Vector2 Process(InputAction.CallbackContext input)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InputAction.CallbackContext | input | The value to transform. |

##### Returns

| Type | Description |
| --- | --- |
| Vector2 | The transformed value. |

[InputSystemTransformer]: InputSystemTransformer-3.md
[CallbackContextTransformer]: CallbackContextTransformer-2.md
[CallbackContextToVector2.UnityEvent]: CallbackContextToVector2.UnityEvent.md
[CallbackContextTransformer<Vector2, CallbackContextToVector2.UnityEvent>.ProcessResult(InputAction.CallbackContext)]: CallbackContextTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_CallbackContextTransformer_2_ProcessResult_InputAction_CallbackContext_
[InputSystemTransformer<InputAction.CallbackContext, Vector2, CallbackContextToVector2.UnityEvent>.ContextToProcess]: InputSystemTransformer-3.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputSystemTransformer_3_ContextToProcess
[Tilia.Input.UnityInputSystem.Transformation.Conversion]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Methods]: #Methods
[Process(InputAction.CallbackContext)]: #ProcessInputAction.CallbackContext
