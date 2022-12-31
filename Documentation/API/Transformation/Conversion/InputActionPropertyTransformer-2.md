# Class InputActionPropertyTransformer<TOutput, TEvent>

Provides an abstract base to transform a given InputAction to the TOutput data type.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [Source]
* [Methods]
  * [BindActions()]
  * [OnDisable()]
  * [OnEnable()]
  * [ProcessAction(InputAction.CallbackContext)]
  * [UnbindActions()]

## Details

##### Inheritance

* System.Object
* [InputSystemTransformer]<InputAction, TOutput, TEvent>
* InputActionPropertyTransformer<TOutput, TEvent>
* [InputActionPropertyToBoolean]
* [InputActionPropertyToFloat]
* [InputActionPropertyToVector2]
* [InputActionPropertyToVector3]

##### Inherited Members

[InputSystemTransformer<InputAction, TOutput, TEvent>.ContextToProcess]

##### Namespace

* [Tilia.Input.UnityInputSystem.Transformation.Conversion]

##### Syntax

```
public abstract class InputActionPropertyTransformer<TOutput, TEvent> : InputSystemTransformer<InputAction, TOutput, TEvent> where TEvent : UnityEvent<TOutput>, new()
```

##### Type Parameters

| Name | Description |
| --- | --- |
| TOutput | The variable type that will be output from the result of the transformation. |
| TEvent | The UnityEvent type the transformation will emit. |

### Properties

#### Source

The InputAction source.

##### Declaration

```
public InputActionProperty Source { get; set; }
```

### Methods

#### BindActions()

Binds the [Source] actions to the appropriate ContextToProcess type.

##### Declaration

```
protected virtual void BindActions()
```

#### OnDisable()

##### Declaration

```
protected virtual void OnDisable()
```

#### OnEnable()

##### Declaration

```
protected virtual void OnEnable()
```

#### ProcessAction(InputAction.CallbackContext)

Processes the given action to transform it.

##### Declaration

```
protected virtual void ProcessAction(InputAction.CallbackContext context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InputAction.CallbackContext | context | The context to process. |

#### UnbindActions()

Unbinds the [Source] actions from the appropriate ContextToProcess type.

##### Declaration

```
protected virtual void UnbindActions()
```

[InputSystemTransformer]: InputSystemTransformer-3.md
[InputActionPropertyToBoolean]: InputActionPropertyToBoolean.md
[InputActionPropertyToFloat]: InputActionPropertyToFloat.md
[InputActionPropertyToVector2]: InputActionPropertyToVector2.md
[InputActionPropertyToVector3]: InputActionPropertyToVector3.md
[InputSystemTransformer<InputAction, TOutput, TEvent>.ContextToProcess]: InputSystemTransformer-3.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputSystemTransformer_3_ContextToProcess
[Tilia.Input.UnityInputSystem.Transformation.Conversion]: README.md
[Source]: InputActionPropertyTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputActionPropertyTransformer_2_Source
[Source]: InputActionPropertyTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_InputActionPropertyTransformer_2_Source
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[Source]: #Source
[Methods]: #Methods
[BindActions()]: #BindActions
[OnDisable()]: #OnDisable
[OnEnable()]: #OnEnable
[ProcessAction(InputAction.CallbackContext)]: #ProcessActionInputAction.CallbackContext
[UnbindActions()]: #UnbindActions
