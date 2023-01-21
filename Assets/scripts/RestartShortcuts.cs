using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartShortcuts : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            SceneManager.LoadScene(LevelNumber.Level + 1);
        }

        if (Input.GetButtonDown("Fire3"))
        {
            LevelNumber.Level = 0;
            SceneManager.LoadScene(LevelNumber.Level + 1);
        }
    }
}
