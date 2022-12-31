# Class CallbackContextToBoolean

Transforms a InputAction.CallbackContext to a System.Boolean.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Methods]
  * [Process(InputAction.CallbackContext)]

## Details

##### Inheritance

* System.Object
* [InputSystemTransformer]<InputAction.CallbackContext, System.Boolean, [CallbackContextToBoolean.UnityEvent]\>
* [CallbackContextTransformer]<System.Boolean, [CallbackContextToBoolean.UnityEvent]\>
* CallbackContextToBoolean

##### Inherited Members

[CallbackContextTransformer<Boolean, CallbackContextToBoolean.UnityEvent>.ProcessResult(InputAction.CallbackContext)]

[InputSystemTransformer<InputAction.CallbackContext, Boolean, CallbackContextToBoolean.UnityEvent>.ContextToProcess]

##### Namespace

* [Tilia.Input.UnityInputSystem.Transformation.Conversion]

##### Syntax

```
public class CallbackContextToBoolean : CallbackContextTransformer<bool, CallbackContextToBoolean.UnityEvent>
```

### Methods

#### Process(InputAction.CallbackContext)

Transforms the given input InputAction.CallbackContext to the equivalent System.Boolean value.

##### Declaration

```
protected override bool Process(InputAction.CallbackContext input)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InputAction.CallbackContext | input | The value to transform. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | The transformed value. |

[InputSystemTransformer]: InputSystemTransformer-3.md
[CallbackContextTransformer]: CallbackContextTransformer-2.md
[CallbackContextToBoolean.UnityEvent]: CallbackContextToBoolean.UnityEvent.md
[CallbackContextTransformer<Boolean, CallbackContextToBoolean.UnityEvent>.ProcessResult(InputAction.CallbackContext)]: CallbackContextTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_CallbackContextTransformer_2_ProcessResult_InputAction_CallbackContext_
[InputSystemTransformer<InputAction.CallbackContext, Boolean, CallbackContextToBoolean.UnityEvent>.ContextToProcess]: InputSystemTransformer-3.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputSystemTransformer_3_ContextToProcess
[Tilia.Input.UnityInputSystem.Transformation.Conversion]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Methods]: #Methods
[Process(InputAction.CallbackContext)]: #ProcessInputAction.CallbackContext
