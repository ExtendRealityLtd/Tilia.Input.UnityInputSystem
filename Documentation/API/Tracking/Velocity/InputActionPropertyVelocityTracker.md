# Class InputActionPropertyVelocityTracker

Retrieves the velocity and angular velocity from the specified InputActionProperty.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [currentAngularVelocity]
  * [currentVelocity]
* [Methods]
  * [DoGetAngularVelocity()]
  * [DoGetVelocity()]
  * [OnDisable()]
  * [OnEnable()]

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

### Methods

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

[Tilia.Input.UnityInputSystem.Tracking.Velocity]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[currentAngularVelocity]: #currentAngularVelocity
[currentVelocity]: #currentVelocity
[Methods]: #Methods
[DoGetAngularVelocity()]: #DoGetAngularVelocity
[DoGetVelocity()]: #DoGetVelocity
[OnDisable()]: #OnDisable
[OnEnable()]: #OnEnable
