using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField] int hp;
    private string name;

    // Start is called before the first frame update
    void Start()
    {
        name = gameObject.name;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        DecreaseHealth();
    }

    private void DecreaseHealth()
    {
        hp--;
        if (hp <= 0)
        {
            Destroy(gameObject);
            if (name == "R_Brick")
            {
                FindObjectOfType<ScoreKeeper>().IncreaseScore(5);
            }
            else if (name == "Y_Brick")
            {
                FindObjectOfType<ScoreKeeper>().IncreaseScore(3);
            }
            else if (name == "LG_Brick")
            {
                FindObjectOfType<ScoreKeeper>().IncreaseScore(2);
            }
            else if (name == "DG_Brick")
            {
                FindObjectOfType<ScoreKeeper>().IncreaseScore(1);
            }
            else
            {
                Debug.LogError("Invalid Brick Error");
            }
        }
        else
        {
            Debug.Log("Brick's hp: " + hp);
        }
    }
}
