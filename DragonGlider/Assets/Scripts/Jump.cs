using UnityEngine;

public class Jump : MonoBehaviour
{
    public Vector2 JumpForce;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !PauseMenu.GameIsPaused)
        {
            GetComponent<Rigidbody2D>().AddForce(JumpForce);
            GetComponent<AudioSource>().Play();
        }
    }
}
