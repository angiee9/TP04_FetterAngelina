using UnityEngine;

[CreateAssetMenu(fileName = "ObstacleData", menuName = "Obstacle", order = 1)]

public class ObstacleData : ScriptableObject
{
    public float MinSpeed;
    public float MaxSpeed;
    public float Speed;
    public float SpeedMultiplier;

    public void setSpeed()
    {
        Speed = MinSpeed;
    }

    public void multiplierSpeed()
    {
        if(Speed < MaxSpeed)
        {
            Speed += SpeedMultiplier;
        }
    }
}
