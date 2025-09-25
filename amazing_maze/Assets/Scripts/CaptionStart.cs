using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaptionStart : MonoBehaviour
{
    public string tekstStart;
    public Text tekst;
    public int duration;

    IEnumerator Start()
    {
        tekst.text = tekstStart;
        yield return new WaitForSeconds(duration);
        Destroy(this.gameObject);
    }
}
