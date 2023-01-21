using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D col)
    {
        SceneManager.LoadScene(12);
    }
}
