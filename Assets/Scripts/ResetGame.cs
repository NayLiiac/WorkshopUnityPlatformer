using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{
    public Camera Camera;
    public int CooldownBeforeRestart;

    private void Start()
    {
        if (Gamepad.current.added)
        {
            Gamepad.current.SetMotorSpeeds(0, 0);
        }
    }

    public void RestartGame()
    {
        StartCoroutine(RestartCooldown(CooldownBeforeRestart));
    }

    public IEnumerator RestartCooldown(int i)
    {
        yield return new WaitForSeconds(i);
        GC.Collect();
        SceneManager.LoadScene(0);
    }
}
