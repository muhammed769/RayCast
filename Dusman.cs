using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusman : MonoBehaviour
{
    // Not :  public Static =  Bu Script dosyasýný baþka bir Script dosyasýndan örneklemeden yazdýðýmýz deðiþkeni metodu vs vs  kullanabiliriz.
    int Saglik; 


    private void Start()
    {
        Saglik = 100;
    }


    public void DarbeAl(int darbeGucu)
    {
        if (Saglik <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            Saglik -= darbeGucu;
        }
    }





}
