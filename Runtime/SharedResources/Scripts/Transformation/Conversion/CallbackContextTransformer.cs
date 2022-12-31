namespace Tilia.Input.UnityInputSystem.Transformation.Conversion
{
    using UnityEngine.Events;
    using UnityEngine.InputSystem;

    /// <summary>
    /// Provides an abstract base to transform a given <see cref="InputAction.CallbackContext"/> to the <see cref="TOutput"/> data type.
    /// </summary>
    /// <typeparam name="TOutput">The variable type that will be output from the result of the transformation.</typeparam>
    /// <typeparam name="TEvent">The <see cref="UnityEvent"/> type the transformation will emit.</typeparam>
    public abstract class CallbackContextTransformer<TOutput, TEvent> : InputSystemTransformer<InputAction.CallbackContext, TOutput, TEvent> where TEvent : UnityEvent<TOutput>, new()
    {
        /// <summary>
        /// Processes the given input into the output result as long as the context event is allowed to be processed based on the <see cref="ContextToProcess"/> value.
        /// </summary>
        /// <param name="input">The value to transform.</param>
        /// <returns>The transformed value.</returns>
        protected override TOutput ProcessResult(InputAction.CallbackContext input)
        {
            if ((input.started && (ContextToProcess & ContextType.Started) == 0) ||
                (input.performed && (ContextToProcess & ContextType.Performed) == 0) ||
                (input.canceled && (ContextToProcess & ContextType.Canceled) == 0))
            {
                return Result;
            }

            return base.ProcessResult(input);
        }
    }
}