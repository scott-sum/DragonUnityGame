using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 1;

    private Enemy enemy;

    private void Awake()
    {
        enemy = GetComponent<Enemy>();
        Time.timeScale = 1f;
        PauseMenu.GameIsPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);

        // if tree stump goes too far to the left, move it back to the right to reuse
        if(transform.position.x < -15)
        {
            transform.position += new Vector3(30, 0, 0); // could also do Vector3.right * 30;
            ShowRandomSprite();
            enemy?.Respawn();
        }
    }

    private void ShowRandomSprite()
    {
        int index = UnityEngine.Random.Range(0, 3);
        int childCount = transform.childCount;

        for (int i = 0; i < childCount; i++)
        {
            Transform child = transform.GetChild(i);
            bool shouldShow = index == i;

            child.gameObject.SetActive(shouldShow);
        }
    }

    private void OnEnable()
    {
        ShowRandomSprite();
    }
}
