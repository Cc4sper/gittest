using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ballmovement : MonoBehaviour
{
    TextMeshProUGUI scoreText;
    Vector3 dir;
    int rightPlayerGoals = 0;
    int leftPlayerGoals = 0;
    
    private void ResetBall()
    {
            scoreText.text = leftPlayerGoals + " - " + rightPlayerGoals;
            transform.position = new Vector3(0, -5, 0);

            int x = Random.Range(0, 2);
            if (x == 0)
            {
                x = -1;
            }
            
            int y = Random.Range(0, 2);
            if (y == 0)
            {
            y = -1;
            }


        dir = new Vector3(x, y, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "paddle")
        {
            dir.x *= -1;
        }
        else if(collision.gameObject.tag == "wall")
        {
            dir.y *= -1;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText = FindObjectOfType<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetBall();
        }

        transform.position += dir * 5 * Time.deltaTime;

        if (transform.position.x < -9)
        {
            rightPlayerGoals += 1;
            ResetBall();
        }
        if (transform.position.x > 9)
        {
            leftPlayerGoals += 1;
            ResetBall();
        }
    }
}
