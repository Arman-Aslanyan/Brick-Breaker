using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    int score = 0;
    [SerializeField] int lives = 3;
    [SerializeField] Text scoreText;
    [SerializeField] Text livesText;
    [SerializeField] GameObject ballPrefab;

    private void Awake()
    {
        LevelController[] objs = FindObjectsOfType<LevelController>();

        if (objs.Length > 1)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }


    public void DecreaseLives()
    {
        lives--;
        livesText.text = lives.ToString();

        if (lives > 0)
        {
            RespawnPlayer();
        }
        else
        {
            SceneManager.LoadScene("End Scene");
        }
    }

    private void RespawnPlayer()
    {
        Vector3 respawnPos = new Vector3(0, -4, 0);
        Instantiate(ballPrefab, respawnPos, Quaternion.identity);
    }

    public void IncreaseScore(int increment)
    {
        score += increment;
        scoreText.text = score.ToString();
    }

    public void Reset()
    {
        lives = 3;
        livesText.text = lives.ToString();
        score = 0;
        scoreText.text = score.ToString();
    }
}
