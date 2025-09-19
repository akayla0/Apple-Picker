using UnityEditorInternal;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottomY = -20f;
    public ApplePicker BasketPicker;

    private void Start()
    {
        BasketPicker = FindFirstObjectByType<ApplePicker>();
    }

    void Update()
    {
        if (transform.position.y < bottomY)
        {
            BasketPicker.RemoveBasket();
            Destroy(this.gameObject);
        }
    }
}


