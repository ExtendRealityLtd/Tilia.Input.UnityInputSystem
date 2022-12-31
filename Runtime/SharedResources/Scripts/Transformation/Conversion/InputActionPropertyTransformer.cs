namespace Tilia.Input.UnityInputSystem.Transformation.Conversion
{
    using UnityEngine;
    using UnityEngine.Events;
    using UnityEngine.InputSystem;

    /// <summary>
    /// Provides an abstract base to transform a given <see cref="InputAction"/> to the <see cref="TOutput"/> data type.
    /// </summary>
    /// <typeparam name="TOutput">The variable type that will be output from the result of the transformation.</typeparam>
    /// <typeparam name="TEvent">The <see cref="UnityEvent"/> type the transformation will emit.</typeparam>
    public abstract class InputActionPropertyTransformer<TOutput, TEvent> : InputSystemTransformer<InputAction, TOutput, TEvent> where TEvent : UnityEvent<TOutput>, new()
    {
        [Tooltip("The InputAction source.")]
        [SerializeField]
        private InputActionProperty source;
        /// <summary>
        /// The <see cref="InputAction"/> source.
        /// </summary>
        public InputActionProperty Source
        {
            get
            {
                return source;
            }
            set
            {
                if (Application.isPlaying)
                {
                    UnbindActions();
                }
                source = value;
                if (Application.isPlaying && isActiveAndEnabled)
                {
                    BindActions();
                }
            }
        }

        protected virtual void OnEnable()
        {
            BindActions();
        }

        protected virtual void OnDisable()
        {
            UnbindActions();
        }

        /// <summary>
        /// Binds the <see cref="Source"/> actions to the appropriate <see cref="ContextToProcess"/> type.
        /// </summary>
        protected virtual void BindActions()
        {
            if (Source == null || Source.action == null)
            {
                return;
            }

            if ((ContextToProcess & ContextType.Started) != 0)
            {
                Source.action.started += ProcessAction;
            }
            if ((ContextToProcess & ContextType.Performed) != 0)
            {
                Source.action.performed += ProcessAction;
            }
            if ((ContextToProcess & ContextType.Canceled) != 0)
            {
                Source.action.canceled += ProcessAction;
            }

            if (Source.reference == null)
            {
                Source.action.Enable();
            }
        }

        /// <summary>
        /// Unbinds the <see cref="Source"/> actions from the appropriate <see cref="ContextToProcess"/> type.
        /// </summary>
        protected virtual void UnbindActions()
        {
            if (Source == null || Source.action == null)
            {
                return;
            }

            if (Source.reference == null)
            {
                Source.action.Disable();
            }

            if ((ContextToProcess & ContextType.Started) != 0)
            {
                Source.action.started -= ProcessAction;
            }
            if ((ContextToProcess & ContextType.Performed) != 0)
            {
                Source.action.performed -= ProcessAction;
            }
            if ((ContextToProcess & ContextType.Canceled) != 0)
            {
                Source.action.canceled -= ProcessAction;
            }
        }

        /// <summary>
        /// Processes the given action to transform it.
        /// </summary>
        /// <param name="context">The context to process.</param>
        protected virtual void ProcessAction(InputAction.CallbackContext context)
        {
            DoTransform(context.action);
        }
    }
}