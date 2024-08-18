using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public GameObject targetObject;
    public Vector3 cameraOffset;
    // Update is called once per frame
    void Update()
    {
        transform.position=targetObject.transform.position + cameraOffset;
    }
}
