using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizePosition : MonoBehaviour
{
    void Start()
    {
        transform.position += new Vector3(Random.Range(-4, 4), Random.Range(-4, 4), 0);
    }
}
