using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJump : MonoBehaviour
{
    [SerializeField]
    private Transform _groundChecker;
    [SerializeField]
    private LayerMask _layerMask;
    [SerializeField]
    private float _jumpForce;
    [SerializeField]
    private PlayerMain _mPlayer;

    private void Start()
    {
        _mPlayer = GetComponent<PlayerMain>();
    }

    public void OnJump(InputAction.CallbackContext ctx)
    {
        if (ctx.performed && PlayerIsOnTheGround())
        {
            _mPlayer.PlayerRb2D.velocity = new Vector2(_mPlayer.PlayerRb2D.velocity.x, _jumpForce);
        }
        if(ctx.canceled && _mPlayer.PlayerRb2D.velocity.y > 0) 
        {
            _mPlayer.PlayerRb2D.velocity = new Vector2(_mPlayer.PlayerRb2D.velocity.x, _mPlayer.PlayerRb2D.velocity.y * 0.5f);
        }
    }

    public bool PlayerIsOnTheGround()
    {
        return Physics2D.OverlapCircle(_groundChecker.position, 0.2f, _layerMask);
    }
}
