using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusman : MonoBehaviour
{
    // Not :  public Static =  Bu Script dosyas�n� ba�ka bir Script dosyas�ndan �rneklemeden yazd���m�z de�i�keni metodu vs vs  kullanabiliriz.
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
