using UnityEngine;
using UnityEngine.UI;

public class ResetHighScore : MonoBehaviour
{

    public Text currentHighScore;

    // Start is called before the first frame update
    void Start()
    {
        currentHighScore.text = "Highscore: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void Highscore_Reset()
    {
        PlayerPrefs.DeleteKey("HighScore");
        currentHighScore.text = "Highscore: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
}
