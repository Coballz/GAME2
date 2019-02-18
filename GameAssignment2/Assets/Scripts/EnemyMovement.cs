using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public int enemySpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        followPlayer();
    }

    void followPlayer()
    {
        //Calculate distance
        Vector3 distance = transform.position - player.position;
        transform.Translate(-distance * enemySpeed * Time.deltaTime);
    }
}
