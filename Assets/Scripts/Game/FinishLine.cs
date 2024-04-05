using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class FinishLine : MonoBehaviour
{
    [SerializeField]
    private ResetGame _resetGame;
    [SerializeField] 
    private PlayerMain _playerMain;
    [SerializeField]
    private GameObject _poisonMist;
    [SerializeField]
    private Animator _fadeInFadeOut;
    [SerializeField]
    private SpriteRenderer _finishLineSprite;
    [SerializeField]
    private List<VisualEffect> _victoryEffects;

    private void Start()
    {
        _fadeInFadeOut = GetComponent<Animator>();
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (_playerMain.GetPlayerAlive() && collider.gameObject.CompareTag("Player"))
        {
            _fadeInFadeOut.SetTrigger("EndReached");
            StartVictoryEffects();
            GameFinished();
            _poisonMist.SetActive(false);
        }
    }

    public void GameFinished()
    {
        _resetGame.RestartGame();
    }

    public void StartVictoryEffects()
    {
        for (int i = 0;  i < _victoryEffects.Count; i++) {
            _victoryEffects[i].gameObject.SetActive(true);
        }
    }
}
