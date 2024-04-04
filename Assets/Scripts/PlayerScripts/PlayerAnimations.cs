using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public Animator PlayerAnimState;
    public Animator ColorLight;

    public void PlayColorChanges(string color)
    {
        float oldTimeScale = Time.timeScale;
        switch (color)
        {
            case "blue":
                Time.timeScale /= 2;
                ColorLight.SetTrigger("BlueToGreen");
                Time.timeScale = oldTimeScale;
                break;
            case "green":
                Time.timeScale /= 2;
                ColorLight.SetTrigger("GreenToBlue");
                Time.timeScale = oldTimeScale;
                break;
        }
    }

    public void PlayerRunningAnim()
    {
        PlayerAnimState.SetBool("isRunning", true);
        PlayerAnimState.SetBool("isIdle", false);
    }

    public void PlayerIdleAnim()
    {
        PlayerAnimState.SetBool("isRunning", false);
        PlayerAnimState.SetBool("isIdle", true);
    }

    public void PlayerJumpingAnim()
    {
        PlayerAnimState.SetBool("isRunning", false);
        PlayerAnimState.SetBool("isIdle", false);

        PlayerAnimState.SetTrigger("Jump");
    }
    public void PlayerFallingAnim()
    {
        PlayerAnimState.SetBool("isRunning", false);
        PlayerAnimState.SetBool("isIdle", false);

        PlayerAnimState.SetTrigger("Fall");
    }

    public void PlayerDeathAnim()
    {
        PlayerAnimState.SetBool("isRunning", false);
        PlayerAnimState.SetBool("isIdle", false);

        PlayerAnimState.SetTrigger("Dead");
    }
}
