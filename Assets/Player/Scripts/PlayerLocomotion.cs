using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLocomotion : MonoBehaviour
{
    ProjectName inputActions;
    InputAction move, look, fire;

    CharacterController characterController;
    public Transform cameraContainer;

    public float maxSpeed = 10f;
    public float jumpSPeed = 10f;
    public float mouseSensitivity = 0.2f;
    public float gravity = 20f;

    Vector3 moveDirection = Vector3.zero;
    float sleep = 6f;


}
