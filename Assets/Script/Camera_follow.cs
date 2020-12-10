using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_follow : MonoBehaviour
{
 public Transform Player;
    public float cameraDistance = 30.0f;

    private void Awake()
    {
       GetComponent<UnityEngine.Camera>().orthographicSize = (Screen.height / 2) / cameraDistance);
    }

    void FixedUpdate ()

    {

        transform.position = new Vector3(Player.position.x,Player.position.y, transform.position.z);
    }

}



