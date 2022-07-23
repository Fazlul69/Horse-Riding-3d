using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimDead : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
      {
        //   if (colliderOne.tag == "end"){
              Destroy(other.gameObject);
        //   }
      }
}
