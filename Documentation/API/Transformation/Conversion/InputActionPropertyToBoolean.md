# Class InputActionPropertyToBoolean

Transforms a InputActionProperty to a System.Boolean.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Methods]
  * [Process(InputAction)]

## Details

##### Inheritance

* System.Object
* [InputSystemTransformer]<InputAction, System.Boolean, [InputActionPropertyToBoolean.UnityEvent]\>
* [InputActionPropertyTransformer]<System.Boolean, [InputActionPropertyToBoolean.UnityEvent]\>
* InputActionPropertyToBoolean

##### Inherited Members

[InputActionPropertyTransformer<Boolean, InputActionPropertyToBoolean.UnityEvent>.Source]

[InputActionPropertyTransformer<Boolean, InputActionPropertyToBoolean.UnityEvent>.OnEnable()]

[InputActionPropertyTransformer<Boolean, InputActionPropertyToBoolean.UnityEvent>.OnDisable()]

[InputActionPropertyTransformer<Boolean, InputActionPropertyToBoolean.UnityEvent>.BindActions()]

[InputActionPropertyTransformer<Boolean, InputActionPropertyToBoolean.UnityEvent>.UnbindActions()]

[InputActionPropertyTransformer<Boolean, InputActionPropertyToBoolean.UnityEvent>.ProcessAction(InputAction.CallbackContext)]

[InputSystemTransformer<InputAction, Boolean, InputActionPropertyToBoolean.UnityEvent>.ContextToProcess]

##### Namespace

* [Tilia.Input.UnityInputSystem.Transformation.Conversion]

##### Syntax

```
public class InputActionPropertyToBoolean : InputActionPropertyTransformer<bool, InputActionPropertyToBoolean.UnityEvent>
```

### Methods

#### Process(InputAction)

##### Declaration

```
protected override bool Process(InputAction action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InputAction | action | n/a |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | n/a |

[InputSystemTransformer]: InputSystemTransformer-3.md
[InputActionPropertyTransformer]: InputActionPropertyTransformer-2.md
[InputActionPropertyToBoolean.UnityEvent]: InputActionPropertyToBoolean.UnityEvent.md
[InputActionPropertyTransformer<Boolean, InputActionPropertyToBoolean.UnityEvent>.Source]: InputActionPropertyTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputActionPropertyTransformer_2_Source
[InputActionPropertyTransformer<Boolean, InputActionPropertyToBoolean.UnityEvent>.OnEnable()]: InputActionPropertyTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputActionPropertyTransformer_2_OnEnable
[InputActionPropertyTransformer<Boolean, InputActionPropertyToBoolean.UnityEvent>.OnDisable()]: InputActionPropertyTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputActionPropertyTransformer_2_OnDisable
[InputActionPropertyTransformer<Boolean, InputActionPropertyToBoolean.UnityEvent>.BindActions()]: InputActionPropertyTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputActionPropertyTransformer_2_BindActions
[InputActionPropertyTransformer<Boolean, InputActionPropertyToBoolean.UnityEvent>.UnbindActions()]: InputActionPropertyTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputActionPropertyTransformer_2_UnbindActions
[InputActionPropertyTransformer<Boolean, InputActionPropertyToBoolean.UnityEvent>.ProcessAction(InputAction.CallbackContext)]: InputActionPropertyTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputActionPropertyTransformer_2_ProcessAction_InputAction_CallbackContext_
[InputSystemTransformer<InputAction, Boolean, InputActionPropertyToBoolean.UnityEvent>.ContextToProcess]: InputSystemTransformer-3.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputSystemTransformer_3_ContextToProcess
[Tilia.Input.UnityInputSystem.Transformation.Conversion]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Methods]: #Methods
[Process(InputAction)]: #ProcessInputAction
