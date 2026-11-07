using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    public int destroyTime;
    void Start()
    {
        Destroy(gameObject, destroyTime);
    }
}
