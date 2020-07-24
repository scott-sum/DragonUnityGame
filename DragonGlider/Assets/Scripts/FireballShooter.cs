using UnityEngine;

public class FireballShooter : MonoBehaviour
{
    public GameObject projectilePrefab;

    void Update()
    {
        if(Input.GetButtonDown("Fire1") && !PauseMenu.GameIsPaused)
        {
            var projectile = GameObject.Instantiate(
                projectilePrefab, 
                new Vector3(1.5f, 0) + transform.position, 
                Quaternion.identity);
        }
    }
}
