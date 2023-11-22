using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaftTrigger : MonoBehaviour
{
    public int distance;
    public float speed;
    private Vector3 startPos, targetPos;

    private void Awake()
    {
        startPos = transform.position;
        targetPos = startPos + transform.forward * distance;
    }

    private void OnCollisionStay(Collision other)
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }

}
