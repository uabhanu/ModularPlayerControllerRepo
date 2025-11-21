namespace Player
{
    using Interfaces;
    using UnityEngine;
    using UnityEngine.InputSystem;
    
    public class PlayerInputHandler : MonoBehaviour
    {
        #region Variables

        private IInputReceiver _iInputReceiver;
        private InputSystem_Actions _inputActions;

        #endregion

        #region Unity Methods

        private void Awake()
        {
            _iInputReceiver = GetComponent<IInputReceiver>();
            _inputActions = new InputSystem_Actions();
        }

        private void OnEnable()
        {
            _inputActions.Player.Enable();
            
            _inputActions.Player.Move.performed += OnMove;
            _inputActions.Player.Move.canceled += OnMove;
            _inputActions.Player.Jump.performed += OnJump;
        }

        private void OnDisable()
        {
            _inputActions.Player.Disable();
            
            _inputActions.Player.Move.performed -= OnMove;
            _inputActions.Player.Move.canceled -= OnMove;
            _inputActions.Player.Jump.performed -= OnJump;
        }

        #endregion

        #region Input Callbacks

        private void OnMove(InputAction.CallbackContext context)
        {
            Vector2 input = context.ReadValue<Vector2>();
            _iInputReceiver?.MovementInput(input);
        }

        private void OnJump(InputAction.CallbackContext context)
        {
            _iInputReceiver?.JumpInput();
        }

        #endregion
    }
}