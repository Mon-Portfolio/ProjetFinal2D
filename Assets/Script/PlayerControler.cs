using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class PlayerControler : MonoBehaviour
{
    public GameObject levelPlayerText;
    public int playerLevel;


    void Awake()
    {
        playerLevel = Random.Range(10, 16);
        levelPlayerText.GetComponent<TextMeshPro>().text = playerLevel.ToString();

    }


    void Update()
    {
        
    }
}
