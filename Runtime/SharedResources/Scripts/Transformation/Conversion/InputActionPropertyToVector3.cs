namespace Tilia.Input.UnityInputSystem.Transformation.Conversion
{
    using System;
    using UnityEngine;
    using UnityEngine.Events;
    using UnityEngine.InputSystem;

    /// <summary>
    /// Transforms a <see cref="InputActionProperty"/> to a <see cref="Vector3"/>.
    /// </summary>
    public class InputActionPropertyToVector3 : InputActionPropertyTransformer<Vector3, InputActionPropertyToVector3.UnityEvent>
    {
        /// <summary>
        /// Defines the event with the transformed <see cref="Vector3"/> value.
        /// </summary>
        [Serializable]
        public class UnityEvent : UnityEvent<Vector3> { }

        /// <inheritdoc />
        protected override Vector3 Process(InputAction action)
        {
            return action != null ? action.ReadValue<Vector3>() : default;
        }
    }
}