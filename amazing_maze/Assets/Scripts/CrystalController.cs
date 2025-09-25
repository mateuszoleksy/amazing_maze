using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrystalController : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "Character")
        {
            return;
        }

        if (leaveCrystals() == 1)
        {
            PlayerPrefs.SetInt("Level" + SceneManager.GetActiveScene().buildIndex, 1);
            SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings - 1);
        }
        else
        {
            Destroy(gameObject, 0.1f);
        }
    }

    int leaveCrystals()
    {
        CrystalController[] crystals = Component.FindObjectsOfType<CrystalController>();
        return crystals.Length;
    }
}
