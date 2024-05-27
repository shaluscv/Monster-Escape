using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject monster;
    public float maxX;
    public Transform spawnPoint;
    public float spawnRate;
    bool gameStart = false;
    public GameObject tapText;
    public TextMeshProUGUI scoreText;
    int score = 0;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !gameStart)
        {
            StartSpawning();
            gameStart = true;
            tapText.SetActive(false);
        }
    }
    void SpawnBlock()
    {
        Vector2 spawnPos = spawnPoint.position;
        spawnPos.x = Random.Range(-maxX, maxX);   
        Instantiate(monster, spawnPos, Quaternion.identity);
       // if (spawnPos.y < -5f)
      //  {
            score++;
            scoreText.text = score.ToString();
       // }
    }

    private void StartSpawning()
    {
        InvokeRepeating("SpawnBlock", 0.5f, spawnRate);
        
    }
}
