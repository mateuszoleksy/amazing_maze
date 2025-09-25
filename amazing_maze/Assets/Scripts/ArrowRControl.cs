using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArrowRControl : MonoBehaviour
{
    public LevelShowControl level;

    private void OnMouseDown()
    {
        if (SceneManager.sceneCountInBuildSettings-2 > level.id)
            level.id++;
    }
}