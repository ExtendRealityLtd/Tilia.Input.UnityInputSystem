# Class CallbackContextToFloat

Transforms a InputAction.CallbackContext to a System.Single.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Methods]
  * [Process(InputAction.CallbackContext)]

## Details

##### Inheritance

* System.Object
* [InputSystemTransformer]<InputAction.CallbackContext, System.Single, [CallbackContextToFloat.UnityEvent]\>
* [CallbackContextTransformer]<System.Single, [CallbackContextToFloat.UnityEvent]\>
* CallbackContextToFloat

##### Inherited Members

[CallbackContextTransformer<Single, CallbackContextToFloat.UnityEvent>.ProcessResult(InputAction.CallbackContext)]

[InputSystemTransformer<InputAction.CallbackContext, Single, CallbackContextToFloat.UnityEvent>.ContextToProcess]

##### Namespace

* [Tilia.Input.UnityInputSystem.Transformation.Conversion]

##### Syntax

```
public class CallbackContextToFloat : CallbackContextTransformer<float, CallbackContextToFloat.UnityEvent>
```

### Methods

#### Process(InputAction.CallbackContext)

Transforms the given input InputAction.CallbackContext to the equivalent System.Single value.

##### Declaration

```
protected override float Process(InputAction.CallbackContext input)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InputAction.CallbackContext | input | The value to transform. |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | The transformed value. |

[InputSystemTransformer]: InputSystemTransformer-3.md
[CallbackContextTransformer]: CallbackContextTransformer-2.md
[CallbackContextToFloat.UnityEvent]: CallbackContextToFloat.UnityEvent.md
[CallbackContextTransformer<Single, CallbackContextToFloat.UnityEvent>.ProcessResult(InputAction.CallbackContext)]: CallbackContextTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_CallbackContextTransformer_2_ProcessResult_InputAction_CallbackContext_
[InputSystemTransformer<InputAction.CallbackContext, Single, CallbackContextToFloat.UnityEvent>.ContextToProcess]: InputSystemTransformer-3.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputSystemTransformer_3_ContextToProcess
[Tilia.Input.UnityInputSystem.Transformation.Conversion]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Methods]: #Methods
[Process(InputAction.CallbackContext)]: #ProcessInputAction.CallbackContext
