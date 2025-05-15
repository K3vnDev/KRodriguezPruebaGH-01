using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabInteractableHandler : MonoBehaviour
{
    XRGrabInteractable xrGrabInteractable;

    private void Awake()
    {
        xrGrabInteractable = GetComponent<XRGrabInteractable>();

        xrGrabInteractable.interactionManager = GameObject
            .FindWithTag("InteractionManager").GetComponent<XRInteractionManager>();
    }
}