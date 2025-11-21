namespace Player
{
    using Interfaces;
    using UnityEngine;

    [RequireComponent(typeof(Rigidbody))]
    public class PlayerController : MonoBehaviour , IInputReceiver
    {
        #region Variables
        
        private Vector2 _currentInput;
        private bool _isGrounded = true;
        private bool _jumpRequested;

        [Header("Movement Settings")]
        [SerializeField] private float jumpForce;
        [SerializeField] private float moveSpeed;
        [SerializeField] private Rigidbody playerBody;
        
        #endregion
        
        #region Unity Methods

        private void FixedUpdate()
        {
            HandleMovement();
            HandleJump();
        }
        
        private void OnCollisionStay(Collision collision)
        {
            if(Vector3.Dot(collision.contacts[0].normal , Vector3.up) > 0.7f) { _isGrounded = true; }
        }
        
        #endregion
        
        #region My Input Methods
        
        private void HandleJump()
        {
            if(_jumpRequested)
            {
                _isGrounded = false;
                _jumpRequested = false;
                playerBody.AddForce(Vector3.up * jumpForce , ForceMode.Impulse);
            }
        }

        private void HandleMovement()
        {
            Vector3 targetVelocity = new Vector3(_currentInput.x * moveSpeed , playerBody.linearVelocity.y , _currentInput.y * moveSpeed);
            playerBody.linearVelocity = targetVelocity;
        }
        
        #endregion
        
        #region IInputReceiver Methods
        
        public void JumpInput()
        {
            if(_isGrounded) { _jumpRequested = true; }
        }
        
        public void MovementInput(Vector2 direction) { _currentInput = direction; }
        
        #endregion
    }
}