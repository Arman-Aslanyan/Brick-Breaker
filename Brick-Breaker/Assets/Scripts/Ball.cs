using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelayStart());
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<LevelController>().DecreaseLives();
        Destroy(gameObject);
    }

    public IEnumerator DelayStart()
    {
        yield return new WaitForSeconds(2);
        GetComponent<Rigidbody2D>().AddForce(new Vector2(250, 250));
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(5, 5);
        }
    }
}
