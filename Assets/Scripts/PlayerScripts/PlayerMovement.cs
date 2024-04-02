using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private PlayerMain _mPlayer;
    [SerializeField]
    private float _playerSpeed;
    [SerializeField]
    private float _horizontalDir;

    private void Start()
    {
        _mPlayer = GetComponent<PlayerMain>();
    }

    private void FixedUpdate()
    {
        _mPlayer.PlayerRb2D.velocity = new Vector2(_horizontalDir * _playerSpeed, _mPlayer.PlayerRb2D.velocity.y);
    }

    public void OnMove(InputAction.CallbackContext ctx)
    {
        if (_mPlayer.PJump.PlayerIsOnTheGround())
        {
            _horizontalDir = ctx.ReadValue<Vector2>().x;
            if (_horizontalDir < 0)
            {
                _mPlayer.PlayerSprite.flipX = true;
            }
            else
            {
                _mPlayer.PlayerSprite.flipX = false;
            }
        }
    }
}
