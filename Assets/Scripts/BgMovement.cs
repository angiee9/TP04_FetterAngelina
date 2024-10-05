using UnityEngine;

public class BgMovement : MonoBehaviour
{
    [SerializeField] private Vector2 velocity;

    private Vector2 offset;

    private Material material;

    private void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    
    private void Update()
    {
        offset = velocity * Time.deltaTime;
        material.mainTextureOffset += offset;
    }
}
