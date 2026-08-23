using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] Transform playerTransform;
    Vector3 playerPosition;
    
    void Start()
    {
        playerPosition = playerTransform.position;
    }

    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void MoveToPlayer()
    {
         transform.position = 
        Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime*speed);
    }

    void DestroyWhenReached()
    {
       if (transform.position == playerPosition)
       {
           Destroy(gameObject);
       }
    }
}
