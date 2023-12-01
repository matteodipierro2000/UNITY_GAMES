using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Attrezzo : MonoBehaviour
{
    public float minY = -5.5f;

    public float maxVelocity = 10f;

    Rigidbody2D rb;

    int score = 0;

    int lives = 24;

    public TextMeshProUGUI scoreTxt;

    public TextMeshProUGUI livesTxt;

    public GameObject GameOverPanel;

    public GameObject youWinPanel;

    public Attrezzo attrezzo;

    public player_movement muratore;

    int brickCount;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        brickCount = FindObjectOfType<LevelGenerator>().transform.childCount;

        rb.velocity = Vector2.down * 10f;
    }

    
    void Update()
    {
       if (transform.position.y < minY)
       {
            if (lives <= 0)
            {
                GameOver();
            }

            else
            {
                transform.position = Vector3.zero;

                rb.velocity = Vector2.down * 10f;

                lives--;

                livesTxt.text = lives.ToString("00");
            }

            
       }

       if (rb.velocity.magnitude > maxVelocity)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxVelocity);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("brick"))
        {
            Destroy(collision.gameObject);

            score += 1;

            scoreTxt.text = score.ToString("00");

            brickCount--;

            if (brickCount <= 0)
            {
                youWinPanel.SetActive(true);

                muratore.enabled = false;

                attrezzo.enabled = false;

                Time.timeScale = 0f;
            }
        }
    }

    void GameOver()
    {
        GameOverPanel.SetActive(true);

        Time.timeScale = 0;

        Destroy(gameObject);
    }
}

