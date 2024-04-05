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
        StartStateEffect();
    }
    
    public void StartStateEffect()
    {
        switch (this.gameObject.layer)
        {
            case 6:
                _mPlayer.PParticles.PlayerBlueStateEffect.Play();
                break;
            case 7:
                _mPlayer.PParticles.PlayerGreenStateEffect.Play();
                break;
        }
    }

    public void ToggleCollision(InputAction.CallbackContext ctx)
    {
        if(_mPlayer.GetPlayerAlive() && ctx.started)
        {
            switch (this.gameObject.layer)
            {
                case 6:
                    _mPlayer.PParticles.PlayerBlueStateEffect.Stop();
                    _mPlayer.PAnim.PlayColorChanges("blue");
                    this.gameObject.layer = 7;
                    _playerLight.color = Color.green;
                    _mPlayer.PParticles.PlayerGreenStateEffect.Play();
                    break;
                case 7:
                    _mPlayer.PParticles.PlayerGreenStateEffect.Stop();
                    _mPlayer.PAnim.PlayColorChanges("green");
                    this.gameObject.layer = 6;
                    _playerLight.color = Color.blue;
                    _mPlayer.PParticles.PlayerBlueStateEffect.Play();
                    break;
            }
        }
    }
}
