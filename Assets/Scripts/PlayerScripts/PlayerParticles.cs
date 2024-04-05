using System.Collections.Generic;
using UnityEngine;

public class PlayerParticles : MonoBehaviour
{
    [Header("Speed Particles")]
    public List<ParticleSystem> PlayerSpeedEffects = new List<ParticleSystem>();

    [Header("Death Particles")]
    public ParticleSystem PlayerHurtAnObstacleEffect;
    public ParticleSystem PlayerDiedInPoisonMist;

    [Header("Player States Particles")]
    public ParticleSystem PlayerInPoisonMist;
    public ParticleSystem PlayerBlueStateEffect;
    public ParticleSystem PlayerGreenStateEffect;

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
    public void PlayerHurtAnObstacle()
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