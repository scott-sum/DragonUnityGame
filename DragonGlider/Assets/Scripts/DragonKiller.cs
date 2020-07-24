using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DragonKiller : MonoBehaviour
{
    public GameObject gameOverMenuUI;
    public Text highScore;

    void Start()
    {
        highScore.text = "Highscore: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 6 || transform.position.y < -5.6)
        {
            GameOver();
        }
    }

    //what we want to do at a collision. Called everytime we get into a collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver();
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        PauseMenu.GameIsPaused = true;

        if (Score.scoreValue > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", Score.scoreValue);
            highScore.text = "New Highscore: " + Score.scoreValue.ToString();
        }
        gameOverMenuUI.SetActive(true);
        
    }
}
