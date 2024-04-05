using UnityEngine;

public class PlayerThroughObstacle : MonoBehaviour
{
    [SerializeField]
    private PlayerMain _mPlayer;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (_mPlayer.GetPlayerAlive())
        {
            if (other.gameObject.CompareTag("ObstacleA"))
            {
                _mPlayer.PParticles.ThroughBlueObstacleEffect.Play();
            }
            else if (other.gameObject.CompareTag("ObstacleB"))
            {
                _mPlayer.PParticles.ThroughGreenObstacleEffect.Play();
            }
        }
    }
}
