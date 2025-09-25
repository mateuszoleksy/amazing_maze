using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public GameObject character;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == character)
        {
            Vector3 pos = new Vector3(character.transform.position.x, character.transform.position.y, transform.position.z);
            character.transform.position = pos;
        }
    }
}
