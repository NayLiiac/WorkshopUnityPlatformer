using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField]
    private ResetGame _resetGame;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        { 
            // EFFECTS
            GameFinished();
        }
    }

    public void GameFinished()
    {
        _resetGame.RestartGame();
    }
}
