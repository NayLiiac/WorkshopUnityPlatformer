using UnityEngine;

public class PlayerFalling : MonoBehaviour
{
    [SerializeField]
    private PlayerMain _mPlayer;

    public void CheckPlayerIsFalling()
    {
        if (_mPlayer.GetPlayerAlive() && !_mPlayer.PJump.PlayerIsOnTheGround())
        {
            _mPlayer.PAnim.PlayerFallingAnim();
        }
    }
}
