using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPortal : MonoBehaviour
{
    public List<Color> list = new List<Color>(9) {Color.black, Color.white, Color.red, new Color(1f, 0.5f, 0f), new Color(1f, 1f, 0f), Color.green, new Color(0f, 0.5f, 1f), Color.blue, new Color(0.5f, 0f, 1f)};
    public int number;
    public bool type;

    private void OnTriggerEnter(Collider other)
    {
        Camera.main.backgroundColor = list[number];
    }
}
