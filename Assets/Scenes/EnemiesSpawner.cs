using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;


public class EnemiesSpawner : MonoBehaviour
{
   
    public int countEnemies = 3;
    public float marginTop = -0.7f;
    public Floor enemiesPrefab;
    public PlayerControler playerLevel;
    // Start is called before the first frame update
    void Start()
    {
        int minLevel = 8;
        int maxLevel = playerLevel.playerLevel;
        UnityEngine.Debug.Log(maxLevel + "player level");
        marginTop = -0.7f;
        for (int i = 0; i< countEnemies; i++)
        {
            Instantiate(enemiesPrefab, new Vector3(1.18291f, marginTop, 0), Quaternion.identity);
            marginTop += 3.3f;
            TextMeshPro level = enemiesPrefab.level.GetComponent<TextMeshPro>();
            int enemieLevel = UnityEngine.Random.Range(minLevel, maxLevel-1);
            level.text = enemieLevel.ToString();
            UnityEngine.Debug.Log(minLevel + "level min");
            UnityEngine.Debug.Log(maxLevel + "level max");
            minLevel = playerLevel.playerLevel + enemieLevel;
            maxLevel += enemieLevel;
            
        }
    }
}
