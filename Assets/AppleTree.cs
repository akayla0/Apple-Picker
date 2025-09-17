using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]

    public GameObject applePrefab;
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float changeDirChance = 0.02f;
    public float appleDropDelay = 1f;
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if(pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if(pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
    }
    private void FixedUpdate()
    {
        if (Random.value < changeDirChance)
        {
            speed *= -1;
        }
    }
}
