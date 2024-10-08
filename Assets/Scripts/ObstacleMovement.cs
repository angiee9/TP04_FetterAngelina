using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public ObstacleGenerator obstacleGenerator;
    [SerializeField] ObstacleData obstacleData;

    void Update()
    {
        transform.Translate(Vector2.left * obstacleData.Speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Next"))
        {
            obstacleGenerator.GenerateObstacleRandom();
        }

        if (collision.gameObject.CompareTag("finishLine"))
        {
            Destroy(this.gameObject);
        }
    }
}
