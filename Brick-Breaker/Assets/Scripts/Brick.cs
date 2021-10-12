using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField] int hp;
    private int start_hp;

    // Start is called before the first frame update
    void Start()
    {
        start_hp = hp;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        DecreaseHealth(start_hp);
    }

    private void DecreaseHealth(int score_change)
    {
        hp--;
        if (hp <= 0)
        {
            FindObjectOfType<LevelController>().IncreaseScore(score_change);
            FindObjectOfType<LevelLoader>().DeductBrick();
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Brick's hp: " + hp);
        }
    }
}
