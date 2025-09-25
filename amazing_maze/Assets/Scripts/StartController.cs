using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour
{
    public LevelShowControl level;

    private void Start()
    {
        Cursor.visible = true;
    }

    private void OnMouseDown()
    {
        if ((level.id-1) >= 1)
        {
            if (PlayerPrefs.GetInt("Level" + (level.id - 1), 0) == 1)
                SceneManager.LoadScene(level.id);
        } else
        {
            SceneManager.LoadScene(level.id);
        }
    }   
}
