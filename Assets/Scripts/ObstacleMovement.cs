using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public ObstacleGenerator obstacleGenerator;


    void Update()
    {
        transform.Translate(Vector2.left * obstacleGenerator.Speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Next"))
        {
            obstacleGenerator.GenerateObstacle();
        }
    }
}
