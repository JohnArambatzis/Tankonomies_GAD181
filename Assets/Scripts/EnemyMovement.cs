using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Transform target;
    private Vector3 targetPos;
    private Vector3 thisPos;
    private float angle;
    private float offset = -90;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void LateUpdate()
    {
        targetPos = target.position;
        thisPos = transform.position;
        targetPos.x = targetPos.x - thisPos.x;
        targetPos.y = targetPos.y - thisPos.y;
        angle = Mathf.Atan2(targetPos.y, targetPos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + offset));

        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, Time.deltaTime * 1);//makes the enemy follow the player
    }
    /*void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");//getting the player based off their tag
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, Time.deltaTime * 1);//makes the enemy follow the player
        //transform.LookAt(2 * transform.position - player.transform.position); //makes enemy face the player
    }*/
}
