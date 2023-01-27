using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        GameObject[] enemiesCount = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemiesCount.Length <= 0)
        {
            SceneManager.LoadScene("WinMenu");
        }
    }
}
