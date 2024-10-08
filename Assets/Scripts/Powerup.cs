using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public GameObject powerup;
    public int speedMin;
    public float speedPowerup;

    private void Awake()
    {
        speedPowerup = speedMin;
        powerupGenerator();
    }

    public void GeneratePowerup()
    {
        float rand = Random.Range(0.1f, 10.0f);
        Invoke("GeneratePowerup", rand);
    }

    void powerupGenerator()
    {
        GameObject Powerupins = Instantiate(powerup, transform.position, transform.rotation);
        Powerupins.GetComponent<PowerupSpawn>().powerupGenerator = this;
    }

    
}
