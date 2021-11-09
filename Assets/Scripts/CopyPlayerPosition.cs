using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyPlayerPosition : MonoBehaviour
{
    [SerializeField] Transform tranTarget;
    void Update()
    {
        transform.position = tranTarget.position;
    }
}
