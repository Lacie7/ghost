using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PLayerMovement : MonoBehaviour


{
    Vector3 targetPosition;

    private void Start()
    {


      //transform.position += Vector3.up;
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))

        {
            SetTargetPosition();

        }
    }

    void SetTargetPosition()

    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 1000))
        {

           targetPosition = hit.point;
            //this.transform.LookAt(targetPosition);
            lookAtTarget = new Vector3(targetPosition.x - transform.position.x, transform.position.y, targetPosition.z - transform.position.z);
            playerRot = Quaternion.LookRotation(lookAtTarget);
        }
    }
   
}
