using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleAnimate : MonoBehaviour
{
    public GameObject Reticle;
    public Transform ReticleTransform;
    void Update()
    {
        ReticleTransform = transform;
        transform.Rotate(0f, 10f * Time.deltaTime, 0f, Space.Self);
    }
}
