using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public GameObject Mermi;
    public GameObject AtesNoktasi;  // Merminin nerden çýkacaðýný belirlemek için bu kodu yazdýk ! ! ! ! !
    // public Transform AtesNoktasi2;

    public GameObject mermizi;


    private void Update()
    {

        #region Second Tell Part

        // Þimdi karekterim Ýçinden ateþ'ler ( Silah mermi mantýðý gibi düþün) çýkacak ve öyle engeller yok olacak.Þimdi bu iþlemi yapýcaz ve geliþtirebiliriz bu iþlemleri..

        if (Input.GetButtonDown("Fire1"))
        {
            // Instantiate(Mermi, AtesNoktasi.transform.position, AtesNoktasi.transform.rotation);
            //Instantiate(Mermi, AtesNoktasi2.position, AtesNoktasi2.rotation);

            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
            {
                Instantiate(mermizi, hit.point, Quaternion.identity);

                hit.transform.gameObject.GetComponent<Dusman>().DarbeAl(25);


                /*
                if (hit.rigidbody!=null)
                {
                    hit.rigidbody.AddForce(Vector3.back * 1000); // Iþýnlarla hem mermi oluþturmadan hemde mermiyi yok etmeden ve dolayýsýyla sistemi yormadan bir

                                                                 // mini bir oyun yapmýþ olduk.
                }
                  //  hit.point // point : Iþýnýn çarpmýþ olduðu noktayý bize gösterir.
                */

            }

        }

            #endregion


    }

    private void FixedUpdate()
    {


        #region Second Tell Part Devamý

       float horizontal =  Input.GetAxis("Horizontal");
       float vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal, 0f, vertical)* 8*Time.deltaTime);
        #endregion


        #region First Tell Part

        /*

              int layerMask = 1 << 6; // Iþýnýn hangi objeleri dikkate alýp almayacaðýný katmanlarla belirleyebiliyorum. Yani ýþýnýn davranýþlarýný katmanlara göre belirleyebiliyoruz.

              // 6'ýncý katmaný dikkate al ya da alma iþlemini yapýcaz.

              // layermask: ýþýðýn hangi katmaný dikkate alacaðýný veya almayacaðýný belirlediðimiz yerdir.

              // YANÝ BU KOD  IÞININ UNÝTY'DE  SADECE 6'INCI KATMANA SAHÝP OLAN OBJELERÝ DÝKKATE ALIR ! ! ! ! ! ! ! ! !

              layerMask = ~ layerMask ;   

              // YANÝ BU KOD IÞININ   UNÝTY'DE SADECE 6 'INCI KATMANI SAHÝP OLAN OBJELERÝ DÝKKATE ALMAZ ! ! ! ! ! ! ! ! !

              // ~ : Bu iþareti Ctrl + Alt + Ü ÝLE YAPARSIN ! ! ! !

               RaycastHit hit;

              if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity,layerMask))
              {

                  hit.transform.gameObject.name = "Vuruldum";
                  // hit.transform.GetComponent<MeshRenderer>().enabled = false;
                  // Destroy(hit.transform.gameObject);
                  Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                  Debug.Log("Hedef var.");



                  /* ------------------------- AÇIKLAMALAR -------------------------

                   RaycastHit hit : Iþýnýn çarptýðý objenin bilgilerini alabileceðimiz bir kontroldür.
                   transform.position : Iþýnýn baþlangýç noktasýný girmiþ olduk.
                   transform.TransformDirection = Iþýnýn hangi yönde ilerleyeceðine burdan karar veririz.
                   out hit : ýþýný dýþarý veriyoruz.
                   Mathf.Infitiy : Iþýnýn menzilini belirttiðimiz yerdir. Sonsuzluðu belirttik. Yani ýþýn ne kadarlýk bir mesafede objeleri yakalayabilsin.
                   Debug.DrawRay : Oyunun baþlangýcýnda ýþýný görebilmemiz için yazdýk.


              }

              else
              {
                  Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
                  Debug.Log("Hedef yok.");
              }

      */

        #endregion


    }


}
