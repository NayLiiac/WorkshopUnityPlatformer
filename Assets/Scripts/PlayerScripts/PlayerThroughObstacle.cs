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
                Debug.Log("Play Blue");

                _mPlayer.PParticles.ThroughBlueObstacleEffect.Play();
            }
            else if (other.gameObject.CompareTag("ObstacleB"))
            {
                Debug.Log("Play Green");
                _mPlayer.PParticles.ThroughGreenObstacleEffect.Play();
            }
        }
    }
}
