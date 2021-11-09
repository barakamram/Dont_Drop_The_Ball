using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleObject : MonoBehaviour
{
    [SerializeField]
    float speed = 1f;
    Vector3 scale;
    int gos = 0; //grow or shrink
    void Update()
    {
        switch (gos)
        {
            case 0:
                scale = transform.localScale;
                scale.x += 1f * speed * Time.deltaTime;
                scale.y += 1f * speed * Time.deltaTime;
                scale.z += 1f * speed * Time.deltaTime;

                transform.localScale = scale;
                if (scale.x > 2)
                    gos = 1;
                    break;
            case 1:
            scale = transform.localScale;
            scale.x -= 1f * speed * Time.deltaTime;
            scale.y -= 1f * speed * Time.deltaTime;
            scale.z -= 1f * speed * Time.deltaTime;

                transform.localScale = scale;
            if (scale.x < 1)
                gos = 0;
                break;
        }
    }
}
