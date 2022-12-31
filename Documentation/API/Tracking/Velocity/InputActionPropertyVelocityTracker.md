# Class InputActionPropertyVelocityTracker

Retrieves the velocity and angular velocity from the specified InputActionProperty.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [currentAngularVelocity]
  * [currentVelocity]
* [Properties]
  * [AngularVelocitySource]
  * [VelocitySource]
* [Methods]
  * [AngularVelocityActionCanceled(InputAction.CallbackContext)]
  * [AngularVelocityActionPerformed(InputAction.CallbackContext)]
  * [BindAngularVelocityActions()]
  * [BindVelocityActions()]
  * [DisableAction(InputActionProperty)]
  * [DoGetAngularVelocity()]
  * [DoGetVelocity()]
  * [EnableAction(InputActionProperty)]
  * [OnDisable()]
  * [OnEnable()]
  * [UnbindAngularVelocityActions()]
  * [UnbindVelocityActions()]
  * [VelocityActionCanceled(InputAction.CallbackContext)]
  * [VelocityActionPerformed(InputAction.CallbackContext)]

## Details

##### Inheritance

* System.Object
* InputActionPropertyVelocityTracker

##### Namespace

* [Tilia.Input.UnityInputSystem.Tracking.Velocity]

##### Syntax

```
public class InputActionPropertyVelocityTracker : VelocityTracker
```

### Fields

#### currentAngularVelocity

The current angular velocity.

##### Declaration

```
protected Vector3 currentAngularVelocity
```

#### currentVelocity

The current velocity.

##### Declaration

```
protected Vector3 currentVelocity
```

### Properties

#### AngularVelocitySource

The InputActionProperty containing the angular velocity source.

##### Declaration

```
public InputActionProperty AngularVelocitySource { get; set; }
```

#### VelocitySource

The InputActionProperty containing the velocity source.

##### Declaration

```
public InputActionProperty VelocitySource { get; set; }
```

### Methods

#### AngularVelocityActionCanceled(InputAction.CallbackContext)

Processes the context when the angular velocity InputActionProperty is canceled.

##### Declaration

```
protected virtual void AngularVelocityActionCanceled(InputAction.CallbackContext context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InputAction.CallbackContext | context | The action context data. |

#### AngularVelocityActionPerformed(InputAction.CallbackContext)

Processes the context when the angular velocity InputActionProperty is performed.

##### Declaration

```
protected virtual void AngularVelocityActionPerformed(InputAction.CallbackContext context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InputAction.CallbackContext | context | The action context data. |

#### BindAngularVelocityActions()

Binds the angular velocity performed and canceled actions to the processing methods.

##### Declaration

```
protected virtual void BindAngularVelocityActions()
```

#### BindVelocityActions()

Binds the velocity performed and canceled actions to the processing methods.

##### Declaration

```
protected virtual void BindVelocityActions()
```

#### DisableAction(InputActionProperty)

Disables the given InputActionProperty.

##### Declaration

```
protected virtual void DisableAction(InputActionProperty property)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InputActionProperty | property | The property to disable. |

#### DoGetAngularVelocity()

##### Declaration

```
protected override Vector3 DoGetAngularVelocity()
```

##### Returns

| Type | Description |
| --- | --- |
| Vector3 | n/a |

#### DoGetVelocity()

##### Declaration

```
protected override Vector3 DoGetVelocity()
```

##### Returns

| Type | Description |
| --- | --- |
| Vector3 | n/a |

#### EnableAction(InputActionProperty)

Enables the given InputActionProperty.

##### Declaration

```
protected virtual void EnableAction(InputActionProperty property)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InputActionProperty | property | The property to enable. |

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

#### UnbindAngularVelocityActions()

Unbinds the velocity performed and canceled actions from the processing methods.

##### Declaration

```
protected virtual void UnbindAngularVelocityActions()
```

#### UnbindVelocityActions()

Unbinds the velocity performed and canceled actions from the processing methods.

##### Declaration

```
protected virtual void UnbindVelocityActions()
```

#### VelocityActionCanceled(InputAction.CallbackContext)

Processes the context when the velocity InputActionProperty is canceled.

##### Declaration

```
protected virtual void VelocityActionCanceled(InputAction.CallbackContext context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InputAction.CallbackContext | context | The action context data. |

#### VelocityActionPerformed(InputAction.CallbackContext)

Processes the context when the velocity InputActionProperty is performed.

##### Declaration

```
protected virtual void VelocityActionPerformed(InputAction.CallbackContext context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InputAction.CallbackContext | context | The action context data. |

[Tilia.Input.UnityInputSystem.Tracking.Velocity]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[currentAngularVelocity]: #currentAngularVelocity
[currentVelocity]: #currentVelocity
[Properties]: #Properties
[AngularVelocitySource]: #AngularVelocitySource
[VelocitySource]: #VelocitySource
[Methods]: #Methods
[AngularVelocityActionCanceled(InputAction.CallbackContext)]: #AngularVelocityActionCanceledInputAction.CallbackContext
[AngularVelocityActionPerformed(InputAction.CallbackContext)]: #AngularVelocityActionPerformedInputAction.CallbackContext
[BindAngularVelocityActions()]: #BindAngularVelocityActions
[BindVelocityActions()]: #BindVelocityActions
[DisableAction(InputActionProperty)]: #DisableActionInputActionProperty
[DoGetAngularVelocity()]: #DoGetAngularVelocity
[DoGetVelocity()]: #DoGetVelocity
[EnableAction(InputActionProperty)]: #EnableActionInputActionProperty
[OnDisable()]: #OnDisable
[OnEnable()]: #OnEnable
[UnbindAngularVelocityActions()]: #UnbindAngularVelocityActions
[UnbindVelocityActions()]: #UnbindVelocityActions
[VelocityActionCanceled(InputAction.CallbackContext)]: #VelocityActionCanceledInputAction.CallbackContext
[VelocityActionPerformed(InputAction.CallbackContext)]: #VelocityActionPerformedInputAction.CallbackContext
