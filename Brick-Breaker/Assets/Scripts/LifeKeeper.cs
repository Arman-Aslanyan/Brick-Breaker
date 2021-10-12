using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeKeeper : MonoBehaviour
{
    int lives;

    [SerializeField] GameObject ballPrefab;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = lives.ToString();
    }

 /*   public void DecreaseLives()
    {
        lives--;
        GetComponent<Text>().text = lives.ToString();

        if (lives > 0)
        {
            RespawnPlayer();
        }
    }

    private void RespawnPlayer()
    {
        Vector3 respawnPos = new Vector3(0, -4, 0);
        Instantiate(ballPrefab, respawnPos, Quaternion.identity);
    }*/
}
