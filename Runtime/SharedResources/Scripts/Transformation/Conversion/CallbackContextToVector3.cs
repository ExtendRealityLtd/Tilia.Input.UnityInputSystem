namespace Tilia.Input.UnityInputSystem.Transformation.Conversion
{
    using System;
    using UnityEngine;
    using UnityEngine.Events;
#if ENABLE_INPUT_SYSTEM
    using UnityEngine.InputSystem;
#endif

    /// <summary>
    /// Transforms a <see cref="InputAction.CallbackContext"/> to a <see cref="Vector3"/>.
    /// </summary>
    public class CallbackContextToVector3 : CallbackContextTransformer<Vector3, CallbackContextToVector3.UnityEvent>
    {
        /// <summary>
        /// Defines the event with the transformed <see cref="Vector3"/> value.
        /// </summary>
        [Serializable]
        public class UnityEvent : UnityEvent<Vector3> { }

#if ENABLE_INPUT_SYSTEM
        /// <summary>
        /// Transforms the given input <see cref="InputAction.CallbackContext"/> to the equivalent <see cref="Vector3"/> value.
        /// </summary>
        /// <param name="input">The value to transform.</param>
        /// <returns>The transformed value.</returns>
        protected override Vector3 Process(InputAction.CallbackContext input)
        {
            return input.ReadValue<Vector3>();
        }
#endif
    }
}