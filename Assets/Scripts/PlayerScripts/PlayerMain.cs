using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    public PlayerMovement PMove;
    public PlayerToggleCollisions PToggle;
    public PlayerJump PJump;
    public SpriteRenderer PlayerSprite;
    public Rigidbody2D PlayerRb2D;

    private void Start()
    {
        PMove = GetComponent<PlayerMovement>();
        PToggle = GetComponent<PlayerToggleCollisions>();
        PJump = GetComponent<PlayerJump>();
        PlayerRb2D = GetComponent<Rigidbody2D>();
    }
}
