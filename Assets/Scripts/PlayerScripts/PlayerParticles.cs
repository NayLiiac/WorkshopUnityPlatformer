using System.Collections.Generic;
using UnityEngine;

public class PlayerParticles : MonoBehaviour
{
    public List<ParticleSystem> PlayerSpeedEffects = new List<ParticleSystem>();
    public ParticleSystem PlayerHurtAnObstacleEffect;
    public ParticleSystem PlayerDiedInPoisonMist;

    /// <summary>
    ///  particles to play when player is running
    /// </summary>
    public void PlaySpeedParticlesEffects()
    {
        for (int i = 0; i < PlayerSpeedEffects.Count; i++) 
        {
            PlayerSpeedEffects[i].Play(); 
        }
    }

    /// <summary>
    /// stop particles when player stops running
    /// </summary>
    public void StopSpeedParticlesEffects()
    {
        for (int i = 0; i < PlayerSpeedEffects.Count; i++)
        {
            PlayerSpeedEffects[i].Stop();
        }
    }

    /// <summary>
    /// particles to play when player hurt an obstacle
    /// </summary>
    public void PlayerHurtAObstacle()
    {
        PlayerHurtAnObstacleEffect.Play();
    }

    /// <summary>
    /// Particle to play when the player died from the poison mist
    /// </summary>
    public void PlayDiedInPoisonMistEffect()
    {
        PlayerDiedInPoisonMist.Play();
    }
}
