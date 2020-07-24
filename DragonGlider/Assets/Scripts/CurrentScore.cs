using UnityEngine;
using UnityEngine.UI;

public class CurrentScore : MonoBehaviour
{

    Text currentScore;

    // Start is called before the first frame update
    void Start()
    {
        currentScore = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        currentScore.text = "Current Score: " + Score.scoreValue;
    }
}
