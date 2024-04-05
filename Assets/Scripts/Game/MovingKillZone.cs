using UnityEngine;

public class MovingKillZone : MonoBehaviour
{
    [Header("Kill Zone stats")]
    public float Speed = 2f;
    [SerializeField]
    private PlayerMain _mPlayer;
    [SerializeField]
    private bool _stopMoving = false;

    private void Start()
    {
        _mPlayer.PlayerAliveEvent += Notify;
    }

    private void FixedUpdate()
    {
        this.transform.Translate(Vector3.right * Speed * Time.deltaTime);
        AddMovingSpeed();
    }

    public void AddMovingSpeed()
    {
        if (!_stopMoving)
        {
            Speed += 0.003f;
        }
    }

    public void Notify(bool playerAlive)
    {
        if (!playerAlive)
        {
            _stopMoving = true;
            Speed = 0f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _mPlayer.PParticles.PlayerInPoisonMist.Play();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _mPlayer.PParticles.PlayerInPoisonMist.Stop();
        }
    }
}
