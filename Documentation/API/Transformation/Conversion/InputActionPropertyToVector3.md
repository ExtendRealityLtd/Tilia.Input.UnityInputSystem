# Class InputActionPropertyToVector3

Transforms a InputActionProperty to a Vector3.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Methods]
  * [Process(InputAction)]

## Details

##### Inheritance

* System.Object
* [InputSystemTransformer]<InputAction, Vector3, [InputActionPropertyToVector3.UnityEvent]\>
* [InputActionPropertyTransformer]<Vector3, [InputActionPropertyToVector3.UnityEvent]\>
* InputActionPropertyToVector3

##### Inherited Members

[InputActionPropertyTransformer<Vector3, InputActionPropertyToVector3.UnityEvent>.Source]

[InputActionPropertyTransformer<Vector3, InputActionPropertyToVector3.UnityEvent>.OnEnable()]

[InputActionPropertyTransformer<Vector3, InputActionPropertyToVector3.UnityEvent>.OnDisable()]

[InputActionPropertyTransformer<Vector3, InputActionPropertyToVector3.UnityEvent>.BindActions()]

[InputActionPropertyTransformer<Vector3, InputActionPropertyToVector3.UnityEvent>.UnbindActions()]

[InputActionPropertyTransformer<Vector3, InputActionPropertyToVector3.UnityEvent>.ProcessAction(InputAction.CallbackContext)]

[InputSystemTransformer<InputAction, Vector3, InputActionPropertyToVector3.UnityEvent>.ContextToProcess]

##### Namespace

* [Tilia.Input.UnityInputSystem.Transformation.Conversion]

##### Syntax

```
public class InputActionPropertyToVector3 : InputActionPropertyTransformer<Vector3, InputActionPropertyToVector3.UnityEvent>
```

### Methods

#### Process(InputAction)

##### Declaration

```
protected override Vector3 Process(InputAction action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InputAction | action | n/a |

##### Returns

| Type | Description |
| --- | --- |
| Vector3 | n/a |

[InputSystemTransformer]: InputSystemTransformer-3.md
[InputActionPropertyTransformer]: InputActionPropertyTransformer-2.md
[InputActionPropertyToVector3.UnityEvent]: InputActionPropertyToVector3.UnityEvent.md
[InputActionPropertyTransformer<Vector3, InputActionPropertyToVector3.UnityEvent>.Source]: InputActionPropertyTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputActionPropertyTransformer_2_Source
[InputActionPropertyTransformer<Vector3, InputActionPropertyToVector3.UnityEvent>.OnEnable()]: InputActionPropertyTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputActionPropertyTransformer_2_OnEnable
[InputActionPropertyTransformer<Vector3, InputActionPropertyToVector3.UnityEvent>.OnDisable()]: InputActionPropertyTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputActionPropertyTransformer_2_OnDisable
[InputActionPropertyTransformer<Vector3, InputActionPropertyToVector3.UnityEvent>.BindActions()]: InputActionPropertyTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputActionPropertyTransformer_2_BindActions
[InputActionPropertyTransformer<Vector3, InputActionPropertyToVector3.UnityEvent>.UnbindActions()]: InputActionPropertyTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputActionPropertyTransformer_2_UnbindActions
[InputActionPropertyTransformer<Vector3, InputActionPropertyToVector3.UnityEvent>.ProcessAction(InputAction.CallbackContext)]: InputActionPropertyTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputActionPropertyTransformer_2_ProcessAction_InputAction_CallbackContext_
[InputSystemTransformer<InputAction, Vector3, InputActionPropertyToVector3.UnityEvent>.ContextToProcess]: InputSystemTransformer-3.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputSystemTransformer_3_ContextToProcess
[Tilia.Input.UnityInputSystem.Transformation.Conversion]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Methods]: #Methods
[Process(InputAction)]: #ProcessInputAction
