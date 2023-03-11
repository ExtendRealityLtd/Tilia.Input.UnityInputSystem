namespace Tilia.Input.UnityInputSystem.Transformation.Conversion
{
    using System;
    using UnityEngine.Events;
#if ENABLE_INPUT_SYSTEM
    using UnityEngine.InputSystem;
#endif

    /// <summary>
    /// Transforms a <see cref="InputActionProperty"/> to a <see cref="float"/>.
    /// </summary>
    public class InputActionPropertyToFloat : InputActionPropertyTransformer<float, InputActionPropertyToFloat.UnityEvent>
    {
        /// <summary>
        /// Defines the event with the transformed <see cref="float"/> value.
        /// </summary>
        [Serializable]
        public class UnityEvent : UnityEvent<float> { }

#if ENABLE_INPUT_SYSTEM
        /// <inheritdoc />
        protected override float Process(InputAction action)
        {
            return action != null ? action.ReadValue<float>() : default;
        }
#endif
    }
}