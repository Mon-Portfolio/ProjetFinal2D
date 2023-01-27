using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] enemiesCount = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemiesCount.Length <= 0)
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
