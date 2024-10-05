using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
     public GameObject obstacle;

     public float MinSpeed;
     public float MaxSpeed;
     public float Speed;
    public float SpeedMultiplier;

    void Awake()
    {
        Speed = MinSpeed;
        GenerateObstacle();

    }

    public void GenerateObstacleRandom()
    {
        float rd = Random.Range(0.1f, 4.0f);
        Invoke("GenerateObstacle", rd);
    }

    void GenerateObstacle()
    {
       GameObject ObstacleIns = Instantiate(obstacle, transform.position, transform.rotation);
        ObstacleIns.GetComponent<ObstacleMovement>().obstacleGenerator = this;
    }

    void Update()
    {
        if(Speed < MaxSpeed)
        {
            Speed += SpeedMultiplier;
        }
    }
}
