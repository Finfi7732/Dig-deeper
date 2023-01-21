using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene(LevelNumber.Level+1);
    }
}
