using UnityEngine;
using UnityEngine.SceneManagement;

public class Rectangle : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

    private void Awake()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(move*speed, 0);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
