using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform cube;
    public float x;
    public float y;
    public float z;
    public ColorPortal colorPortal;
    public bool FreeCam = false;

    public float rSpeedX = 2.0f;
    public float rSpeedY = 2.0f;

    private float rx = 0f;
    private float ry = 0f;

    void Update()
    {
        rx += rSpeedX * Input.GetAxis("Mouse X");
        ry -= rSpeedY * Input.GetAxis("Mouse Y");

        Rigidbody rigidbody = cube.GetComponent<Rigidbody>();

        float velocity = rigidbody.velocity.sqrMagnitude;

        Vector3 vector = new Vector3(x, y, z);

        vector = vector * (1f + velocity / 25f);
        Vector3 oldPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        transform.position = Vector3.Lerp(oldPosition, (cube.position + vector), Time.deltaTime * 2f);
        if (!FreeCam)
            transform.LookAt(cube);
        else if (FreeCam)
            transform.eulerAngles = new Vector3(ry, rx, 0f);
    }
}
