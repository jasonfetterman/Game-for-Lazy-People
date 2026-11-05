using UnityEngine;
using UnityEngine.InputSystem;

namespace Game.Player
{
    [DisallowMultipleComponent]
    [RequireComponent(typeof(CharacterController))]
    public sealed class PlayerController : MonoBehaviour
    {
        [Header("Movement")]
        [SerializeField, Min(0.1f)] private float walkSpeed = 4f;
        [SerializeField, Min(0.1f)] private float sprintSpeed = 6.5f;
        [SerializeField, Min(0.1f)] private float acceleration = 18f;
        [SerializeField, Min(0.1f)] private float deceleration = 24f;
        [SerializeField, Min(0.1f)] private float jumpHeight = 1.2f;
        [SerializeField, Min(0.1f)] private float gravity = 20f;

        [Header("Camera")]
        [SerializeField] private Transform cameraTransform;
        [SerializeField, Min(0.01f)] private float mouseSensitivity = 0.12f;
        [SerializeField, Range(-89f, 0f)] private float minimumPitch = -75f;
        [SerializeField, Range(0f, 89f)] private float maximumPitch = 75f;
        [SerializeField] private bool lockCursorOnStart = true;

        [Header("Ground Detection")]
        [SerializeField] private LayerMask groundLayers = ~0;

        private CharacterController characterController;
        private InputAction movementAction;
        private InputAction lookAction;
        private InputAction jumpAction;
        private InputAction sprintAction;

        private Vector3 horizontalVelocity;
        private float verticalVelocity;
        private float cameraPitch;
        private bool isSprinting;
        private bool inputEnabled = true;

        public bool IsGrounded => characterController != null && characterController.isGrounded;
        public bool IsSprinting => isSprinting;
        public float CurrentSpeed => horizontalVelocity.magnitude;

        private void Awake()
        {
            characterController = GetComponent<CharacterController>();

            if (cameraTransform == null)
            {
                Camera mainCamera = GetComponentInChildren<Camera>();
                if (mainCamera == null)
                    mainCamera = Camera.main;

                if (mainCamera != null)
                    cameraTransform = mainCamera.transform;
            }

            if (cameraTransform != null)
            {
                float initialPitch = cameraTransform.localEulerAngles.x;

                if (initialPitch > 180f)
                    initialPitch -= 360f;

                cameraPitch = Mathf.Clamp(
                    initialPitch,
                    minimumPitch,
                    maximumPitch);
            }

            ConfigureInput();
        }

        private void Start()
        {
            if (cameraTransform == null)
            {
                Debug.LogWarning(
                    "PlayerController: No camera assigned. Movement will work, but mouse look will be unavailable.",
                    this);
            }

            if (lockCursorOnStart)
                SetCursorLocked(true);
        }

        private void ConfigureInput()
        {
            movementAction = new InputAction("Movement", InputActionType.Value);
            movementAction.AddCompositeBinding("2DVector")
                .With("Up", "<Keyboard>/w")
                .With("Down", "<Keyboard>/s")
                .With("Left", "<Keyboard>/a")
                .With("Right", "<Keyboard>/d");
            movementAction.AddBinding("<Gamepad>/leftStick");

            lookAction = new InputAction("Look", InputActionType.Value);
            lookAction.AddBinding("<Mouse>/delta");
            lookAction.AddBinding("<Gamepad>/rightStick");

            jumpAction = new InputAction("Jump", InputActionType.Button);
            jumpAction.AddBinding("<Keyboard>/space");
            jumpAction.AddBinding("<Gamepad>/buttonSouth");

            sprintAction = new InputAction("Sprint", InputActionType.Button);
            sprintAction.AddBinding("<Keyboard>/leftShift");
            sprintAction.AddBinding("<Gamepad>/leftStickPress");
        }

        private void OnEnable()
        {
            movementAction?.Enable();
            lookAction?.Enable();
            jumpAction?.Enable();
            sprintAction?.Enable();
        }

        private void OnDisable()
        {
            movementAction?.Disable();
            lookAction?.Disable();
            jumpAction?.Disable();
            sprintAction?.Disable();
        }

        private void Update()
        {
            if (!inputEnabled || characterController == null)
                return;

            HandleCursorInput();
            HandleLook();
            HandleMovement();
        }

        private void HandleCursorInput()
        {
            if (Keyboard.current != null &&
                Keyboard.current.escapeKey.wasPressedThisFrame)
            {
                SetCursorLocked(false);
            }

            if (Mouse.current != null &&
                Mouse.current.leftButton.wasPressedThisFrame &&
                Cursor.lockState != CursorLockMode.Locked)
            {
                SetCursorLocked(true);
            }
        }

        private void HandleLook()
        {
            if (cameraTransform == null ||
                Cursor.lockState != CursorLockMode.Locked)
                return;

            Vector2 lookInput = lookAction.ReadValue<Vector2>();

            bool usingGamepad = Gamepad.current != null &&
                                Gamepad.current.rightStick.ReadValue().sqrMagnitude > 0.01f;

            float sensitivity = usingGamepad
                ? mouseSensitivity * 120f * Time.deltaTime
                : mouseSensitivity;

            float yaw = lookInput.x * sensitivity;
            float pitch = lookInput.y * sensitivity;

            transform.Rotate(Vector3.up * yaw);

            cameraPitch = Mathf.Clamp(
                cameraPitch - pitch,
                minimumPitch,
                maximumPitch);

            cameraTransform.localRotation =
                Quaternion.Euler(cameraPitch, 0f, 0f);
        }

        private void HandleMovement()
        {
            Vector2 input = Vector2.ClampMagnitude(
                movementAction.ReadValue<Vector2>(), 1f);

            Vector3 forward = transform.forward;
            Vector3 right = transform.right;

            Vector3 desiredDirection =
                (forward * input.y + right * input.x).normalized;

            isSprinting = sprintAction.IsPressed() && input.y > 0.1f;

            float targetSpeed = isSprinting ? sprintSpeed : walkSpeed;
            Vector3 targetVelocity = desiredDirection * targetSpeed;

            float rate = input.sqrMagnitude > 0.001f
                ? acceleration
                : deceleration;

            horizontalVelocity = Vector3.MoveTowards(
                horizontalVelocity,
                targetVelocity,
                rate * Time.deltaTime);

            if (characterController.isGrounded && verticalVelocity < 0f)
                verticalVelocity = -2f;

            if (characterController.isGrounded && jumpAction.WasPressedThisFrame())
            {
                verticalVelocity = Mathf.Sqrt(2f * gravity * jumpHeight);
            }

            verticalVelocity -= gravity * Time.deltaTime;

            Vector3 movement =
                horizontalVelocity + Vector3.up * verticalVelocity;

            characterController.Move(movement * Time.deltaTime);
        }

        public void SetInputEnabled(bool enabled)
        {
            inputEnabled = enabled;

            if (!enabled)
            {
                horizontalVelocity = Vector3.zero;
                isSprinting = false;
            }
        }

        public void SetCursorLocked(bool locked)
        {
            Cursor.lockState = locked
                ? CursorLockMode.Locked
                : CursorLockMode.None;

            Cursor.visible = !locked;
        }

        private void OnDestroy()
        {
            movementAction?.Dispose();
            lookAction?.Dispose();
            jumpAction?.Dispose();
            sprintAction?.Dispose();
        }

        private void OnValidate()
        {
            walkSpeed = Mathf.Max(0.1f, walkSpeed);
            sprintSpeed = Mathf.Max(walkSpeed, sprintSpeed);
            acceleration = Mathf.Max(0.1f, acceleration);
            deceleration = Mathf.Max(0.1f, deceleration);
            jumpHeight = Mathf.Max(0.1f, jumpHeight);
            gravity = Mathf.Max(0.1f, gravity);
            mouseSensitivity = Mathf.Max(0.01f, mouseSensitivity);
        }
    }
}

