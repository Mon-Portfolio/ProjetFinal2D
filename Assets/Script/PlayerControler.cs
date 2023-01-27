using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class PlayerControler : MonoBehaviour
{
    public GameObject levelPlayerText;
    public int playerLevel;


    void Start()
    {
        playerLevel = Random.Range(10, 16);
        levelPlayerText.GetComponent<TextMeshPro>().text = playerLevel.ToString();
        
        Debug.Log(playerLevel);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
