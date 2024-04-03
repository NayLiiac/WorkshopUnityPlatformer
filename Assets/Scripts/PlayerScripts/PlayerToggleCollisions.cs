using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

public class PlayerToggleCollisions : MonoBehaviour
{
    [SerializeField]
    private Light2D _playerLight;

    public void ToggleCollision(InputAction.CallbackContext ctx)
    {
        if(ctx.started)
        {
            switch (this.gameObject.layer)
            {
                case 6:
                    // effect
                    this.gameObject.layer = 7;
                    _playerLight.color = Color.green;
                    break;
                case 7:
                    // effect 
                    this.gameObject.layer = 6;
                    _playerLight.color = Color.blue;
                    break;
            }
        }
    }
}
