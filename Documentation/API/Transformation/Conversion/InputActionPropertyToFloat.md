# Class InputActionPropertyToFloat

Transforms a InputActionProperty to a System.Single.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Methods]
  * [Process(InputAction)]

## Details

##### Inheritance

* System.Object
* [InputSystemTransformer]<InputAction, System.Single, [InputActionPropertyToFloat.UnityEvent]\>
* [InputActionPropertyTransformer]<System.Single, [InputActionPropertyToFloat.UnityEvent]\>
* InputActionPropertyToFloat

##### Inherited Members

[InputActionPropertyTransformer<Single, InputActionPropertyToFloat.UnityEvent>.Source]

[InputActionPropertyTransformer<Single, InputActionPropertyToFloat.UnityEvent>.OnEnable()]

[InputActionPropertyTransformer<Single, InputActionPropertyToFloat.UnityEvent>.OnDisable()]

[InputActionPropertyTransformer<Single, InputActionPropertyToFloat.UnityEvent>.BindActions()]

[InputActionPropertyTransformer<Single, InputActionPropertyToFloat.UnityEvent>.UnbindActions()]

[InputActionPropertyTransformer<Single, InputActionPropertyToFloat.UnityEvent>.ProcessAction(InputAction.CallbackContext)]

[InputSystemTransformer<InputAction, Single, InputActionPropertyToFloat.UnityEvent>.ContextToProcess]

##### Namespace

* [Tilia.Input.UnityInputSystem.Transformation.Conversion]

##### Syntax

```
public class InputActionPropertyToFloat : InputActionPropertyTransformer<float, InputActionPropertyToFloat.UnityEvent>
```

### Methods

#### Process(InputAction)

##### Declaration

```
protected override float Process(InputAction action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InputAction | action | n/a |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | n/a |

[InputSystemTransformer]: InputSystemTransformer-3.md
[InputActionPropertyTransformer]: InputActionPropertyTransformer-2.md
[InputActionPropertyToFloat.UnityEvent]: InputActionPropertyToFloat.UnityEvent.md
[InputActionPropertyTransformer<Single, InputActionPropertyToFloat.UnityEvent>.Source]: InputActionPropertyTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputActionPropertyTransformer_2_Source
[InputActionPropertyTransformer<Single, InputActionPropertyToFloat.UnityEvent>.OnEnable()]: InputActionPropertyTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputActionPropertyTransformer_2_OnEnable
[InputActionPropertyTransformer<Single, InputActionPropertyToFloat.UnityEvent>.OnDisable()]: InputActionPropertyTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputActionPropertyTransformer_2_OnDisable
[InputActionPropertyTransformer<Single, InputActionPropertyToFloat.UnityEvent>.BindActions()]: InputActionPropertyTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputActionPropertyTransformer_2_BindActions
[InputActionPropertyTransformer<Single, InputActionPropertyToFloat.UnityEvent>.UnbindActions()]: InputActionPropertyTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputActionPropertyTransformer_2_UnbindActions
[InputActionPropertyTransformer<Single, InputActionPropertyToFloat.UnityEvent>.ProcessAction(InputAction.CallbackContext)]: InputActionPropertyTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputActionPropertyTransformer_2_ProcessAction_InputAction_CallbackContext_
[InputSystemTransformer<InputAction, Single, InputActionPropertyToFloat.UnityEvent>.ContextToProcess]: InputSystemTransformer-3.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputSystemTransformer_3_ContextToProcess
[Tilia.Input.UnityInputSystem.Transformation.Conversion]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Methods]: #Methods
[Process(InputAction)]: #ProcessInputAction
