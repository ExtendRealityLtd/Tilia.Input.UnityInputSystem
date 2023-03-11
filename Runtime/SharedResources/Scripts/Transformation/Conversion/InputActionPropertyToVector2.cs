namespace Tilia.Input.UnityInputSystem.Transformation.Conversion
{
    using System;
    using UnityEngine;
    using UnityEngine.Events;
#if ENABLE_INPUT_SYSTEM
    using UnityEngine.InputSystem;
#endif

    /// <summary>
    /// Transforms a <see cref="InputActionProperty"/> to a <see cref="Vector2"/>.
    /// </summary>
    public class InputActionPropertyToVector2 : InputActionPropertyTransformer<Vector2, InputActionPropertyToVector2.UnityEvent>
    {
        /// <summary>
        /// Defines the event with the transformed <see cref="Vector2"/> value.
        /// </summary>
        [Serializable]
        public class UnityEvent : UnityEvent<Vector2> { }

#if ENABLE_INPUT_SYSTEM
        /// <inheritdoc />
        protected override Vector2 Process(InputAction action)
        {
            return action != null ? action.ReadValue<Vector2>() : default;
        }
#endif
    }
}