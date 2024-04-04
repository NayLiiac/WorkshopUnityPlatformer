using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    public PlayerMovement PMove;
    public PlayerToggleCollisions PToggle;
    public PlayerJump PJump;
    public Transform PlayerVisuals;
    public Rigidbody2D PlayerRb2D;
    public PlayerAnimations PAnim;
    public PlayerParticles PParticles;

    public bool PlayerAlive;

    private void Start()
    {
        PMove = GetComponent<PlayerMovement>();
        PToggle = GetComponent<PlayerToggleCollisions>();
        PJump = GetComponent<PlayerJump>();
        PlayerRb2D = GetComponent<Rigidbody2D>();
        PAnim = GetComponent<PlayerAnimations>();
        PParticles = GetComponent<PlayerParticles>();

        PlayerAlive = true;
    }
}
