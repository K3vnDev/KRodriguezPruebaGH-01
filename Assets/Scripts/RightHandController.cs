using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class RightHandController : MonoBehaviour
{
    [SerializeField] GameObject grabController;
    [SerializeField] GameObject teleportController;

    [Space, SerializeField] InputActionReference inputAction;

    private void OnEnable()
    {
        inputAction.action.performed += OnTeleportButtonPress;
        inputAction.action.canceled += OnTeleportButtonRelease;
    }

    private void OnDisable()
    {
        inputAction.action.performed -= OnTeleportButtonPress;
        inputAction.action.canceled -= OnTeleportButtonRelease;
    }

    private void OnTeleportButtonPress(InputAction.CallbackContext _)
    {
        grabController.SetActive(false);
        teleportController.SetActive(true);
    }

    private void OnTeleportButtonRelease(InputAction.CallbackContext _)
    {
        grabController.SetActive(true);
        teleportController.SetActive(false);
    }
}
