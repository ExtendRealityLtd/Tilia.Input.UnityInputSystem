namespace Tilia.Input.UnityInputSystem.Tracking.Velocity
{
    using UnityEngine;
    using UnityEngine.InputSystem;
    using Zinnia.Tracking.Velocity;

    /// <summary>
    /// Retrieves the velocity and angular velocity from the specified <see cref="InputActionProperty"/>.
    /// </summary>
    public class InputActionPropertyVelocityTracker : VelocityTracker
    {
        [Tooltip("The InputActionProperty containing the velocity source.")]
        [SerializeField]
        private InputActionProperty velocitySource;
        /// <summary>
        /// The <see cref="InputActionProperty"/> containing the velocity source.
        /// </summary>
        public InputActionProperty VelocitySource
        {
            get
            {
                return velocitySource;
            }
            set
            {
                if (Application.isPlaying)
                {
                    UnbindVelocityActions();
                }
                velocitySource = value;
                if (Application.isPlaying && IsActive())
                {
                    BindVelocityActions();
                }
            }
        }

        [Tooltip("The InputActionProperty containing the angular velocity source.")]
        [SerializeField]
        private InputActionProperty angularVelocitySource;
        /// <summary>
        /// The <see cref="InputActionProperty"/> containing the angular velocity source.
        /// </summary>
        public InputActionProperty AngularVelocitySource
        {
            get
            {
                return angularVelocitySource;
            }
            set
            {
                if (Application.isPlaying)
                {
                    UnbindAngularVelocityActions();
                }
                angularVelocitySource = value;
                if (Application.isPlaying && IsActive())
                {
                    BindAngularVelocityActions();
                }
            }
        }

        /// <summary>
        /// The current velocity.
        /// </summary>
        protected Vector3 currentVelocity;
        /// <summary>
        /// The current angular velocity.
        /// </summary>
        protected Vector3 currentAngularVelocity;

        /// <inheritdoc />
        protected override Vector3 DoGetAngularVelocity()
        {
            return currentAngularVelocity;
        }

        /// <inheritdoc />
        protected override Vector3 DoGetVelocity()
        {
            return currentVelocity;
        }

        protected virtual void OnEnable()
        {
            BindVelocityActions();
            BindAngularVelocityActions();
        }

        protected virtual void OnDisable()
        {
            UnbindVelocityActions();
            UnbindAngularVelocityActions();
        }

        /// <summary>
        /// Binds the velocity performed and canceled actions to the processing methods.
        /// </summary>
        protected virtual void BindVelocityActions()
        {
            if (VelocitySource == null || VelocitySource.action == null)
            {
                return;
            }

            VelocitySource.action.performed += VelocityActionPerformed;
            VelocitySource.action.canceled += VelocityActionCanceled;
            EnableAction(VelocitySource);
        }

        /// <summary>
        /// Binds the angular velocity performed and canceled actions to the processing methods.
        /// </summary>
        protected virtual void BindAngularVelocityActions()
        {
            if (AngularVelocitySource == null || AngularVelocitySource.action == null)
            {
                return;
            }

            AngularVelocitySource.action.performed += AngularVelocityActionPerformed;
            AngularVelocitySource.action.canceled += AngularVelocityActionCanceled;
            EnableAction(AngularVelocitySource);
        }

        /// <summary>
        /// Unbinds the velocity performed and canceled actions from the processing methods.
        /// </summary>
        protected virtual void UnbindVelocityActions()
        {
            if (VelocitySource == null || VelocitySource.action == null)
            {
                return;
            }

            DisableAction(VelocitySource);
            VelocitySource.action.performed -= VelocityActionPerformed;
            VelocitySource.action.canceled -= VelocityActionCanceled;
        }

        /// <summary>
        /// Unbinds the velocity performed and canceled actions from the processing methods.
        /// </summary>
        protected virtual void UnbindAngularVelocityActions()
        {
            if (AngularVelocitySource == null || AngularVelocitySource.action == null)
            {
                return;
            }

            DisableAction(AngularVelocitySource);
            AngularVelocitySource.action.performed -= AngularVelocityActionPerformed;
            AngularVelocitySource.action.canceled -= AngularVelocityActionCanceled;
        }

        /// <summary>
        /// Enables the given <see cref="InputActionProperty"/>.
        /// </summary>
        /// <param name="property">The property to enable.</param>
        protected virtual void EnableAction(InputActionProperty property)
        {
            if (property.reference == null)
            {
                property.action.Enable();
            }
        }

        /// <summary>
        /// Disables the given <see cref="InputActionProperty"/>.
        /// </summary>
        /// <param name="property">The property to disable.</param>
        protected virtual void DisableAction(InputActionProperty property)
        {
            if (property.reference == null)
            {
                property.action.Disable();
            }
        }

        /// <summary>
        /// Processes the context when the velocity <see cref="InputActionProperty"/> is performed.
        /// </summary>
        /// <param name="context">The action context data.</param>
        protected virtual void VelocityActionPerformed(InputAction.CallbackContext context)
        {
            currentVelocity = context.ReadValue<Vector3>();
        }

        /// <summary>
        /// Processes the context when the velocity <see cref="InputActionProperty"/> is canceled.
        /// </summary>
        /// <param name="context">The action context data.</param>
        protected virtual void VelocityActionCanceled(InputAction.CallbackContext context)
        {
            currentVelocity = Vector3.zero;
        }

        /// <summary>
        /// Processes the context when the angular velocity <see cref="InputActionProperty"/> is performed.
        /// </summary>
        /// <param name="context">The action context data.</param>
        protected virtual void AngularVelocityActionPerformed(InputAction.CallbackContext context)
        {
            currentAngularVelocity = context.ReadValue<Vector3>();
        }

        /// <summary>
        /// Processes the context when the angular velocity <see cref="InputActionProperty"/> is canceled.
        /// </summary>
        /// <param name="context">The action context data.</param>
        protected virtual void AngularVelocityActionCanceled(InputAction.CallbackContext context)
        {
            currentAngularVelocity = Vector3.zero;
        }
    }
}