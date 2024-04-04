using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField]
    private ResetGame _resetGame;
    [SerializeField]
    private GameObject _poisonMist;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        { 
            // EFFECTS
            GameFinished();
            _poisonMist.SetActive(false);
        }
    }

    public void GameFinished()
    {
        Debug.Log("Game finished");
        _resetGame.RestartGame();
    }
}
