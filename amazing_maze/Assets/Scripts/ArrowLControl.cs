using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArrowLControl : MonoBehaviour
{
    public LevelShowControl level;

    private void OnMouseDown()
    {
        if (1 < level.id)
            level.id--;
    }
}
