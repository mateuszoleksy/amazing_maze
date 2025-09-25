using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelShowControl : MonoBehaviour
{
    public int id;
    public TextMesh textMesh;

    void Update()
    {
        if (PlayerPrefs.GetInt("Level" + id, 0) == 1)
        {
            textMesh.color = Color.green;
        } else if (PlayerPrefs.GetInt("Level" + (id - 1), 0) == 1)
        {
            textMesh.color = Color.white;
        } else if (PlayerPrefs.GetInt("Level" + (id - 1), 0) == 0)
        {
            textMesh.color = Color.gray;
        }
        textMesh.text = "Level " + id;
    }
}
