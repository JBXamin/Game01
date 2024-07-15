using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followcam : MonoBehaviour
{
    [SerializeField] GameObject ThingToFollow;
    void Update()
    {
         transform.position = ThingToFollow.transform.position + new Vector3 (0,0,-10);
    }
}
