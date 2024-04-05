using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

public class PlayerToggleCollisions : MonoBehaviour
{
    [SerializeField]
    private Light2D _playerLight;
    [SerializeField]
    private PlayerMain _mPlayer;

    private void Start()
    {
        _mPlayer = GetComponent<PlayerMain>();
    }

    public void ToggleCollision(InputAction.CallbackContext ctx)
    {
        if(_mPlayer.GetPlayerAlive() && ctx.started)
        {
            switch (this.gameObject.layer)
            {
                case 6:
                    _mPlayer.PAnim.PlayColorChanges("blue");
                    this.gameObject.layer = 7;
                    _playerLight.color = Color.green;
                    break;
                case 7:
                    _mPlayer.PAnim.PlayColorChanges("green");
                    this.gameObject.layer = 6;
                    _playerLight.color = Color.blue;
                    break;
            }
        }
    }
}
