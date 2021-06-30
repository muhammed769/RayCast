using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mermi : MonoBehaviour
{


    private void Start()
    {
        Destroy(gameObject, 0.7f);
    }


    private void Update()
    {
        transform.Translate(Vector3.forward * 50 * Time.deltaTime); 
    }





}
