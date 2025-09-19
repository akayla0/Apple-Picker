using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class ApplePicker : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    private Stack<GameObject> basketStack;

    void Start()
    {
        basketStack = new Stack<GameObject>();
        for (int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketG0 = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketG0.transform.position = pos;
            basketStack.Push(tBasketG0);
        }

    }

    public void RemoveBasket()
    {
        if (basketStack.Count == 0)
        {

        }
        else
        {
            GameObject basket = basketStack.Pop();
            AppleMissed();
            Destroy(basket);
        }


    }
    public void AppleMissed()
    {
        GameObject[] appleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach (GameObject tempG0 in appleArray)
        {
            Destroy(tempG0);
        }
    }
}
