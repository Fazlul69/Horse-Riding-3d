using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class FirstAnimation : MonoBehaviour
{
    public PathCreator pathCreator;
    public float moveSpeed =1.5f;
    float distancetravel;
     
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        distancetravel += moveSpeed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distancetravel);
    }

}
