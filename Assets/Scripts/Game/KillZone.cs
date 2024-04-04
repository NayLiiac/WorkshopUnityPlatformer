using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class KillZone : MonoBehaviour
{
    [SerializeField]
    private ResetGame _resetGame;
    [SerializeField]
    private float _shakeDuration;
    [SerializeField]
    private float _shakeStrength;
    [SerializeField]
    private int _shakeVibrato;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerMain tempPlayerMain = collision.gameObject.GetComponent<PlayerMain>();
            tempPlayerMain.PAnim.PlayerDeathAnim();
            tempPlayerMain.PlayerAlive = false;

            _resetGame.Camera.DOShakePosition(_shakeDuration, _shakeStrength, _shakeVibrato, 90, fadeOut: true);

            if (Gamepad.current.added)
            {
                StartCoroutine(GamepadShake());
            }

            _resetGame.RestartGame();
        }
    }

    public IEnumerator GamepadShake()
    {
        Gamepad.current.SetMotorSpeeds(0.25f, 0.75f);
        yield return new WaitForSeconds(0.5f);
        Gamepad.current.SetMotorSpeeds(0,0);
    }
}
