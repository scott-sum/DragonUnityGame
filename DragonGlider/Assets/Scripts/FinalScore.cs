using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    Text finalScore;

    // Start is called before the first frame update
    void Start()
    {
        finalScore = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        finalScore.text = "Final Score: " + Score.scoreValue;
    }
}
