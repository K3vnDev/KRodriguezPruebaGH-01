using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportHandler : MonoBehaviour
{
    XRSimpleInteractable xRSimpleInteractable;

    void Start()
    {
        xRSimpleInteractable = GetComponent<XRSimpleInteractable>();
        xRSimpleInteractable.interactionManager = GameObject
            .FindWithTag("InteractionManager").GetComponent<XRInteractionManager>();
    }

    public void Teleport(int index)
    {
        SceneManager.LoadScene(index);
    }
}
