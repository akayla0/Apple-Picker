using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]

    public GameObject applePrefab;
    public GameObject branchPrefab;
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float changeDirChance = 0.02f;
    public float itemDropDelay = 1f;
    void Start()
    {
        Invoke("DropItems", 2f);
 
    }

    void DropItems()
    {
        if (Random.value > 0.15f)
        {
            GameObject apple = Instantiate<GameObject>(applePrefab);
            apple.transform.position = transform.position;
        }
        else
        {
            GameObject branch = Instantiate<GameObject>(branchPrefab);
            branch.transform.position = transform.position;
        }
        Invoke("DropItems", itemDropDelay);
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
