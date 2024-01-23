using UnityEngine;

public class FireParticleSystem : MonoBehaviour
{
    public ParticleSystem waterParticleSystem; 
    private ParticleSystem fireParticles;

    void Start()
    {
        fireParticles = GetComponent<ParticleSystem>();
    }

    void OnParticleCollision(GameObject other)
    {
        if (other == waterParticleSystem.gameObject)
        {
            fireParticles.Stop(); 
            Destroy(gameObject, 1f); 
        }
    }
}
