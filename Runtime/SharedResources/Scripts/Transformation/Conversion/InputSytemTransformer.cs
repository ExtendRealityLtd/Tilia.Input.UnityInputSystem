namespace Tilia.Input.UnityInputSystem.Transformation.Conversion
{
    using System;
    using UnityEngine;
    using UnityEngine.Events;
    using UnityEngine.InputSystem;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Type.Transformation;

    /// <summary>
    /// Provides an abstract base to transform a given Unity Input System <see cref="TInput"/> type to the <see cref="TOutput"/> data type.
    /// </summary>
    /// <typeparam name="TOutput">The variable type that will be used for the input.</typeparam>
    /// <typeparam name="TOutput">The variable type that will be output from the result of the transformation.</typeparam>
    /// <typeparam name="TEvent">The <see cref="UnityEvent"/> type the transformation will emit.</typeparam>
    public abstract class InputSystemTransformer<TInput, TOutput, TEvent> : Transformer<TInput, TOutput, TEvent> where TEvent : UnityEvent<TOutput>, new()
    {
        /// <summary>
        /// The <see cref="InputAction.CallbackContext"/> event context.
        /// </summary>
        [Flags]
        public enum ContextType
        {
            /// <summary>
            /// Whether the event is the started state.
            /// </summary>
            Started = 1 << 0,
            /// <summary>
            /// Whether the event is the performed state.
            /// </summary>
            Performed = 1 << 1,
            /// <summary>
            /// Whether the event is the canceled state.
            /// </summary>
            Canceled = 1 << 2
        }

        [Tooltip("The ContextType event to process the transformation for.")]
        [SerializeField]
        [UnityFlags]
        private ContextType contextToProcess = ContextType.Performed;
        /// <summary>
        /// The <see cref="ContextType"/> event to process the transformation for.
        /// </summary>
        public ContextType ContextToProcess
        {
            get
            {
                return contextToProcess;
            }
            set
            {
                contextToProcess = value;
            }
        }
    }
}