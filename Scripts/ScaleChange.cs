using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChange : MonoBehaviour
{
    void OnMouseDown()
    {
        transform.localScale = new Vector3(1.1f, 1.1f, 1f);
        print("Hello");
    }

    void OnMouseUp()
    {
        transform.localScale = new Vector3(1.2f, 1.2f, 1f);
    }
}
