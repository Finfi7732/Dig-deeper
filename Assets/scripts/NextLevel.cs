using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField] private LayerMask nextLevelLayer;
    [SerializeField] private Transform groundCheck;

    // Update is called once per frame
    private void Update()
    {
        if (IsAdvancing())
        {
            LevelNumber.Level++;
            SceneManager.LoadScene(LevelNumber.Level+1);
        }
    }

    private bool IsAdvancing()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, nextLevelLayer);
    }
}
