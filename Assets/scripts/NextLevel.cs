using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string LevelToLoad = "";
    public GameObject complete;
    void OnTriggerEnter(Collider other)
    {
        if (LevelToLoad == "end")
        {
            complete.SetActive(true);
        }
        
        if (other.gameObject.tag == "Player" && LevelToLoad != "" && complete == null)
        {
           
            SceneManager.LoadScene(LevelToLoad);
        
           
        }
    }
}
