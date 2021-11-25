using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string LevelToLoad = "";

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" & LevelToLoad != "")
        {
            SceneManager.LoadScene(LevelToLoad);
        }
    }
}
