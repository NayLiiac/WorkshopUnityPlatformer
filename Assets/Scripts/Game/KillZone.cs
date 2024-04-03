using UnityEngine;

public class KillZone : MonoBehaviour
{
    [SerializeField]
    private ResetGame _resetGame;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Feedback : mort
            _resetGame.RestartGame();
        }
    }
}
