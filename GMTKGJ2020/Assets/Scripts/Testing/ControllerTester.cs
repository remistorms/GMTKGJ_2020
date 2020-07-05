using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerTester : MonoBehaviour
{
    private Controls controls;

    public Vector2 moveDirection;

    private void Awake()
    {
        controls = new Controls();
    }

    private void Start()
    {
        controls.Player.Move.performed  += ctx => { moveDirection = ctx.ReadValue<Vector2>();  };
        controls.Player.Move.canceled += ctx => { moveDirection = Vector2.zero; };
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
