using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour

{
    [SerializeField] private float speed;
    [SerializeField] private float maxSpeed;

    private Rigidbody2D myRB;
    private Vector2 mousePosition;

    private void OnEnable()
    {
        var input = new Input();
        input.Enable();
        input.Player.Movement.performed += MovementOnperformed;
        input.Player.Movement.canceled += MovementOncanceled;
    }

    private void MovementOnperformed(InputAction.CallbackContext obj)

    {
       mousePosition = obj.ReadValue<Vector2>();
      

    }
    private void MovementOncanceled(InputAction.CallbackContext obj)

    {
        mousePosition = Vector2.zero;
    }

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (myRB.velocity.sqrMagnitude < maxSpeed)

        {
            myRB.AddForce(mousePosition * speed);
        }
       

    }
}
