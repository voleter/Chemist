using UnityEngine;

public class ParticleCollision : MonoBehaviour
{
    public ParticleSystem collisionParticleSystem; // The particle system to play on collision

    private void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("Particle")) // Check if the collided object is tagged as "Particle"
        {
            PlayParticleSystem();
        }
    }

    private void PlayParticleSystem()
    {
        if (collisionParticleSystem != null)
        {
            collisionParticleSystem.Play(); // Start playing the particle system
            Invoke("StopParticleSystem", 5f); // Schedule to stop after 5 seconds
        }
    }

    private void StopParticleSystem()
    {
        if (collisionParticleSystem != null)
        {
            collisionParticleSystem.Stop(); // Stop playing the particle system
        }
    }
}
