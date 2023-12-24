using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void OnCollisionEnter(Collision other) 
    {
        Debug.Log(this.name + "--Collided With--" + other.gameObject.name);
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{this.name} **Triggerd by** {other.gameObject.name}");
    }
}
