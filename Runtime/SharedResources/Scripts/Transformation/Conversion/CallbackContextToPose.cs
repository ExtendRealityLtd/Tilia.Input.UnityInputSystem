namespace Tilia.Input.UnityInputSystem.Transformation.Conversion
{
    using System;
    using UnityEngine.Events;
    using UnityEngine.InputSystem;
#if OPENXR_DEFINED
    using Pose = UnityEngine.XR.OpenXR.Input.Pose;
#else
    using Pose = UnityEngine.Pose;
#endif

    /// <summary>
    /// Transforms a <see cref="InputAction.CallbackContext"/> to a <see cref="Pose"/>.
    /// </summary>
    public class CallbackContextToPose : CallbackContextTransformer<Pose, CallbackContextToPose.UnityEvent>
    {
        /// <summary>
        /// Defines the event with the transformed <see cref="Pose"/> value.
        /// </summary>
        [Serializable]
        public class UnityEvent : UnityEvent<Pose> { }

        /// <summary>
        /// Transforms the given input <see cref="InputAction.CallbackContext"/> to the equivalent <see cref="Pose"/> value.
        /// </summary>
        /// <param name="input">The value to transform.</param>
        /// <returns>The transformed value.</returns>
        protected override Pose Process(InputAction.CallbackContext input)
        {
            return input.ReadValue<Pose>();
        }
    }
}