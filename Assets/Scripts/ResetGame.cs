using System.Collections;
using System.Security.Authentication.ExtendedProtection;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{
    public Camera Camera;
    public int CooldownBeforeRestart;

    public void RestartGame()
    {
        StartCoroutine(RestartCooldown(CooldownBeforeRestart));
    }

    public IEnumerator RestartCooldown(int i)
    {
        yield return new WaitForSeconds(i);
        SceneManager.LoadScene(0);
    }
}
