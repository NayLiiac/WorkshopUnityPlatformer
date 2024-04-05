using DG.Tweening;
using System;
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
    [SerializeField] 
    private Camera _camera;

    private void Start()
    {
        _mPlayer = GetComponent<PlayerMain>();
    }

    private void FixedUpdate()
    {
        _mPlayer.PlayerRb2D.velocity = new Vector2(_horizontalDir * _playerSpeed, _mPlayer.PlayerRb2D.velocity.y);
        if(_mPlayer.GetPlayerAlive() && _mPlayer.PlayerRb2D.velocity.x == 0)
        {
            _mPlayer.PAnim.PlayerIdleAnim();
        }
    }
    public void OnMove(InputAction.CallbackContext ctx)
    {
        if (_mPlayer.GetPlayerAlive() && ctx.performed && _mPlayer.PJump.PlayerIsOnTheGround())
        {
            _mPlayer.PParticles.PlaySpeedParticlesEffects();
            _camera.DOOrthoSize(6, 1f);
            _horizontalDir = ctx.ReadValue<Vector2>().x;
            _mPlayer.PAnim.PlayerRunningAnim();

            if (_horizontalDir < 0)
            {
                _mPlayer.PlayerVisuals.rotation = Quaternion.Euler(0, 180, 0);
            }
            else
            {
                _mPlayer.PlayerVisuals.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
        else if (_mPlayer.GetPlayerAlive() && ctx.canceled || !_mPlayer.PJump.PlayerIsOnTheGround()) 
        {
            _mPlayer.PParticles.StopSpeedParticlesEffects();
            _camera.DOOrthoSize(5, 1f);
        } 
    }
}
