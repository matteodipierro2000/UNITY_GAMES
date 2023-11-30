using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Player player;

    public TextMeshProUGUI scoreText;

    public GameObject playButton;

    public GameObject gameOver;

    public GameObject youwin;
    
    private int score;

    private void Awake()
    {
        gameOver.SetActive(false);

        youwin.SetActive(false);

        Application.targetFrameRate = 60;

        Pause(); 
    }

    public void Play()
    {
        score = 0;

        scoreText.text = score.ToString();

        playButton.SetActive(false);

        gameOver.SetActive(false);

        youwin.SetActive(false);

        Time.timeScale = 1f;

        player.enabled = true;

        Asteroidi[] asteroidi = FindObjectsOfType<Asteroidi>();

        for (int i = 0; i < asteroidi.Length; i++){

            Destroy(asteroidi[i].gameObject);
        }
    }
    public void Pause()
    {
        Time.timeScale = 0f;

        player.enabled = false;

    }

    public void GameOver()

    {
        gameOver.SetActive(true);

        playButton.SetActive(true);

        Pause();
    }

    public void IncreaseScore()

    {
        score++;

        scoreText.text = score.ToString();

        if (score == 15)
        {
            youwin.SetActive(true);

            playButton.SetActive(true);

            Pause();
        }
    }
}
