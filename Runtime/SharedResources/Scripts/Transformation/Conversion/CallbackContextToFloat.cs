namespace Tilia.Input.UnityInputSystem.Transformation.Conversion
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using System;
    using UnityEngine.Events;
    using UnityEngine.InputSystem;

    /// <summary>
    /// Transforms a <see cref="InputAction.CallbackContext"/> to a <see cref="float"/>.
    /// </summary>
    public class CallbackContextToFloat : CallbackContextTransformer<float, CallbackContextToFloat.UnityEvent>
    {
        /// <summary>
        /// Defines the event with the transformed <see cref="float"/> value.
        /// </summary>
        [Serializable]
        public class UnityEvent : UnityEvent<float> { }

        /// <summary>
        /// The minimum value to consider as a zero float value.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public float DeadZoneValue { get; set; } = 0.00001f;

        /// <summary>
        /// Transforms the given input <see cref="InputAction.CallbackContext"/> to the equivalent <see cref="float"/> value.
        /// </summary>
        /// <param name="input">The value to transform.</param>
        /// <returns>The transformed value.</returns>
        protected override float Process(InputAction.CallbackContext input)
        {
            float value = input.ReadValue<float>();
            return value >= DeadZoneValue ? value : 0f;
        }
    }
}