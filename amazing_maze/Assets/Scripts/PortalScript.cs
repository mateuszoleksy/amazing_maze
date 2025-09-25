using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    public Transform cube;
    public Transform camera;

    private void OnTriggerEnter(Collider other)
    {
        cube.position = new Vector3(0f, 0.25f, 0f);
        camera.position = new Vector3(0f, 2f, -2f);
    }
}
