using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = score.ToString();
    }

    public void IncreaseScore(int increment)
    {
        score += increment;
        GetComponent<Text>().text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
