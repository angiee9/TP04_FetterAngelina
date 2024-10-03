using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
     public GameObject obstacle;

     public float MinSpeed;
     public float MaxSpeed;
     public float Speed;

    void Awake()
    {
        Speed = MinSpeed;
        GenerateObstacle();

    }

    public void GenerateObstacle()
    {
       GameObject ObstacleIns = Instantiate(obstacle, transform.position, transform.rotation);
       ObstacleIns.GetComponent<ObstacleMovement>().obstacleGenerator = this;
    }

    void Update()
    {
        
    }
}
