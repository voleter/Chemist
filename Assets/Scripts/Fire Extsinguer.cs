using UnityEngine;
using Oculus.Interaction; // Ensure this is the correct namespace for your version of Oculus Integration

public class FireExtinguisher : MonoBehaviour
{
    public ParticleSystem waterParticles;
    private Oculus.Interaction.HandGrab.HandGrabInteractable handGrabInteractable;

    void Start()
    {
        handGrabInteractable = GetComponent<Oculus.Interaction.HandGrab.HandGrabInteractable>();
        if (handGrabInteractable == null)
        {
            Debug.LogError("HandGrabInteractable component not found on the fire extinguisher object.");
            return;
        }

        // Subscribe to grab events
        handGrabInteractable.WhenHandGrabbed += OnGrabStarted;
        handGrabInteractable.WhenHandReleased += OnGrabEnded;
    }

    private void OnGrabStarted(Oculus.Interaction.HandGrab.HandGrabInteractor handGrabInteractor)
    {
        waterParticles.Play();
    }

    private void OnGrabEnded(Oculus.Interaction.HandGrab.HandGrabInteractor handGrabInteractor)
    {
        waterParticles.Stop();
    }

    void OnDestroy()
    {
        if (handGrabInteractable != null)
        {
            handGrabInteractable.WhenHandGrabbed -= OnGrabStarted;
            handGrabInteractable.WhenHandReleased -= OnGrabEnded;
        }
    }
}
