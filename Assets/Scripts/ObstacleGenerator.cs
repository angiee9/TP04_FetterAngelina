using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
     public GameObject obstacle;

    [SerializeField] ObstacleData obstacleData;

    void Awake()
    {
        obstacleData.setSpeed();
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
        obstacleData.multiplierSpeed();
    }

    
}
