using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    // Starts game after click on start game button
    public void StartGame()
    {
        LevelNumber.Level = 0;
        SceneManager.LoadScene(LevelNumber.Level+1);
    }
}
