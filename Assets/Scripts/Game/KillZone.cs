using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.PostProcessing;

public class KillZone : MonoBehaviour
{
    public KillZoneTypes KillZoneType;
    [SerializeField]
    private ResetGame _resetGame;

    [Header("Cam Shaker Values")]
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
            tempPlayerMain.SetPlayerAlive(false);

            if (KillZoneType == KillZoneTypes.Crystal)
            {
                _resetGame.Camera.DOShakePosition(_shakeDuration, _shakeStrength, _shakeVibrato, 90, fadeOut: true);
                tempPlayerMain.PParticles.PlayerHurtAnObstacle();
            }
            else
            {
                tempPlayerMain.PParticles.PlayDiedInPoisonMistEffect();
            }

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

public enum KillZoneTypes
{
    Crystal,
    PoisonMist,
}
