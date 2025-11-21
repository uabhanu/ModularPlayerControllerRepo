namespace Interfaces
{
    using UnityEngine;
    
    public interface IInputReceiver
    {
        public void JumpInput();
        public void MovementInput(Vector2 direction);
    }
}
