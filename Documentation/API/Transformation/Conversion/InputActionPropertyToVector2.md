# Class InputActionPropertyToVector2

Transforms a InputActionProperty to a Vector2.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Methods]
  * [Process(InputAction)]

## Details

##### Inheritance

* System.Object
* [InputSystemTransformer]<InputAction, Vector2, [InputActionPropertyToVector2.UnityEvent]\>
* [InputActionPropertyTransformer]<Vector2, [InputActionPropertyToVector2.UnityEvent]\>
* InputActionPropertyToVector2

##### Inherited Members

[InputActionPropertyTransformer<Vector2, InputActionPropertyToVector2.UnityEvent>.Source]

[InputActionPropertyTransformer<Vector2, InputActionPropertyToVector2.UnityEvent>.OnEnable()]

[InputActionPropertyTransformer<Vector2, InputActionPropertyToVector2.UnityEvent>.OnDisable()]

[InputActionPropertyTransformer<Vector2, InputActionPropertyToVector2.UnityEvent>.BindActions()]

[InputActionPropertyTransformer<Vector2, InputActionPropertyToVector2.UnityEvent>.UnbindActions()]

[InputActionPropertyTransformer<Vector2, InputActionPropertyToVector2.UnityEvent>.ProcessAction(InputAction.CallbackContext)]

[InputSystemTransformer<InputAction, Vector2, InputActionPropertyToVector2.UnityEvent>.ContextToProcess]

##### Namespace

* [Tilia.Input.UnityInputSystem.Transformation.Conversion]

##### Syntax

```
public class InputActionPropertyToVector2 : InputActionPropertyTransformer<Vector2, InputActionPropertyToVector2.UnityEvent>
```

### Methods

#### Process(InputAction)

##### Declaration

```
protected override Vector2 Process(InputAction action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InputAction | action | n/a |

##### Returns

| Type | Description |
| --- | --- |
| Vector2 | n/a |

[InputSystemTransformer]: InputSystemTransformer-3.md
[InputActionPropertyTransformer]: InputActionPropertyTransformer-2.md
[InputActionPropertyToVector2.UnityEvent]: InputActionPropertyToVector2.UnityEvent.md
[InputActionPropertyTransformer<Vector2, InputActionPropertyToVector2.UnityEvent>.Source]: InputActionPropertyTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputActionPropertyTransformer_2_Source
[InputActionPropertyTransformer<Vector2, InputActionPropertyToVector2.UnityEvent>.OnEnable()]: InputActionPropertyTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputActionPropertyTransformer_2_OnEnable
[InputActionPropertyTransformer<Vector2, InputActionPropertyToVector2.UnityEvent>.OnDisable()]: InputActionPropertyTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputActionPropertyTransformer_2_OnDisable
[InputActionPropertyTransformer<Vector2, InputActionPropertyToVector2.UnityEvent>.BindActions()]: InputActionPropertyTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputActionPropertyTransformer_2_BindActions
[InputActionPropertyTransformer<Vector2, InputActionPropertyToVector2.UnityEvent>.UnbindActions()]: InputActionPropertyTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputActionPropertyTransformer_2_UnbindActions
[InputActionPropertyTransformer<Vector2, InputActionPropertyToVector2.UnityEvent>.ProcessAction(InputAction.CallbackContext)]: InputActionPropertyTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputActionPropertyTransformer_2_ProcessAction_InputAction_CallbackContext_
[InputSystemTransformer<InputAction, Vector2, InputActionPropertyToVector2.UnityEvent>.ContextToProcess]: InputSystemTransformer-3.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputSystemTransformer_3_ContextToProcess
[Tilia.Input.UnityInputSystem.Transformation.Conversion]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Methods]: #Methods
[Process(InputAction)]: #ProcessInputAction
