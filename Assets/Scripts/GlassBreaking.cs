using UnityEngine;

public class SoldierCollision : MonoBehaviour
{
    public AudioClip collisionSound; 
    private AudioSource audioSource;

    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        audioSource.clip = collisionSound;
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Floor") 
        {
            audioSource.Play();
        }
    }
}
