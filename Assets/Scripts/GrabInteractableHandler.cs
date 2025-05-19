using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabInteractableHandler : MonoBehaviour
{
    private void Awake()
    {
        XRGrabInteractable xrGrabInteractable = GetComponent<XRGrabInteractable>();

        xrGrabInteractable.interactionManager = GameObject
            .FindWithTag("InteractionManager").GetComponent<XRInteractionManager>();
    }
}