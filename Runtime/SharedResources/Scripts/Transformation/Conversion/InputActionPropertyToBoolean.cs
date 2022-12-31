namespace Tilia.Input.UnityInputSystem.Transformation.Conversion
{
    using System;
    using UnityEngine.Events;
    using UnityEngine.InputSystem;

    /// <summary>
    /// Transforms a <see cref="InputActionProperty"/> to a <see cref="bool"/>.
    /// </summary>
    public class InputActionPropertyToBoolean : InputActionPropertyTransformer<bool, InputActionPropertyToBoolean.UnityEvent>
    {
        /// <summary>
        /// Defines the event with the transformed <see cref="bool"/> value.
        /// </summary>
        [Serializable]
        public class UnityEvent : UnityEvent<bool> { }

        /// <inheritdoc />
        protected override bool Process(InputAction action)
        {
            return action.triggered;
        }
    }
}