using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameplay : MonoBehaviour
{

    public Floor enemiesPrefab;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject player = collision.gameObject;
        GameObject enemyInScene = enemiesPrefab.enemy;
        int playerLevel = player.GetComponent<PlayerControler>().playerLevel;
        TextMeshPro enemieLevelText = enemiesPrefab.level.GetComponent<TextMeshPro>();
        int enemieLevel = Convert.ToInt32(enemieLevelText.text);
        player.transform.position = enemiesPrefab.PlayerPosition.transform.position;
        GameObject playerText = player.GetComponent<PlayerControler>().levelPlayerText;
            if (playerLevel >= enemieLevel)
            {
                int newLevel = playerLevel + enemieLevel;
                player.GetComponent<PlayerControler>().playerLevel = newLevel;
                playerText.GetComponent<TextMeshPro>().text = newLevel.ToString();
                Destroy(enemyInScene);
            }
            else
            {
                SceneManager.LoadScene("LooseMenu");
            }
        }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GameObject player = collision.gameObject;
        player.transform.position = new Vector3(-9.14f, -3.74f, 0);
        Destroy(enemiesPrefab.stage);
    }
}
