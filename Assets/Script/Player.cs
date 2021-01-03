using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour

{
    [SerializeField] private float point;
    // [SerializeField] private float maxSpeed;

    private Collider myCO;
    private Vector3 mousePosition;
   
    


    private void OnEnable()
    {
        var input = new Input();
        input.Enable();
        input.Player.Movement.performed += MovementOnperformed;
        input.Player.Movement.canceled += MovementOncanceled;
        

    }

    private void MovementOnperformed(InputAction.CallbackContext mouse)

    {
     // Vector3 mousePosition = mousePositionReference.ReadValue<Vector2>();


    }
    private void MovementOncanceled(InputAction.CallbackContext mouse)

    {
     //  Vector3 mousePosition = Input.mousePosition;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    { 
    }
}