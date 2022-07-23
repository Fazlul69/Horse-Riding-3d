using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateHorse : MonoBehaviour
{
    public GameObject horse;
     public Transform firstPos;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(horse, firstPos.position, firstPos.rotation);
        StartCoroutine(AnimStart());
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public IEnumerator AnimStart()
    {
        Instantiate(horse, firstPos.position, firstPos.rotation);
        yield return new WaitForSeconds(12);
        StartCoroutine(AnimStart());
    }
}
