using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusman : MonoBehaviour
{
    // Not :  public Static =  Bu Script dosyasını başka bir Script dosyasından örneklemeden yazdığımız değişkeni metodu vs vs  kullanabiliriz.
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
