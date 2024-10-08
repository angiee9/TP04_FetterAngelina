using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawn : MonoBehaviour
{
    public Powerup powerupGenerator;
    private int totalTime;

    void Update()
    {
        transform.Translate(Vector2.left * powerupGenerator.speedPowerup * Time.deltaTime);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
               
            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("Next"))
        {
            powerupGenerator.GeneratePowerup();
        }

        if (collision.gameObject.CompareTag("finishLine"))
        {
            Destroy(this.gameObject);
        }
    }

}
