using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private Rigidbody rigidbody;
    Vector3 vector;

    private void Start()
    {
        rigidbody = transform.GetComponent<Rigidbody>();

        vector = Vector3.zero;
        Cursor.visible = false;
    }

    void Update()
    {
        changePosition();
    }

    void changePosition()
    {
        bool isSomething;
        vector = Vector3.zero;
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            isSomething = Physics.Raycast(transform.position, -Vector3.left, 1f);
            if (!isSomething)
            {
                vector = -Vector3.forward;
            }
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            isSomething = Physics.Raycast(transform.position, Vector3.forward, 1f);
            if (!isSomething)
            {
                vector = -Vector3.left;
            }
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            isSomething = Physics.Raycast(transform.position, Vector3.back, 1f);
            if (!isSomething)
            {
                vector = Vector3.left;
            }
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            isSomething = Physics.Raycast(transform.position, Vector3.left, 1f);
            if (!isSomething)
            {
                vector = Vector3.forward;
            }
        }

        rigidbody.AddTorque(vector * 50f);
    }
}
