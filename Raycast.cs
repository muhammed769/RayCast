using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public GameObject Mermi;
    public GameObject AtesNoktasi;  // Merminin nerden ��kaca��n� belirlemek i�in bu kodu yazd�k ! ! ! ! !
    // public Transform AtesNoktasi2;

    public GameObject mermizi;


    private void Update()
    {

        #region Second Tell Part

        // �imdi karekterim ��inden ate�'ler ( Silah mermi mant��� gibi d���n) ��kacak ve �yle engeller yok olacak.�imdi bu i�lemi yap�caz ve geli�tirebiliriz bu i�lemleri..

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
                    hit.rigidbody.AddForce(Vector3.back * 1000); // I��nlarla hem mermi olu�turmadan hemde mermiyi yok etmeden ve dolay�s�yla sistemi yormadan bir

                                                                 // mini bir oyun yapm�� olduk.
                }
                  //  hit.point // point : I��n�n �arpm�� oldu�u noktay� bize g�sterir.
                */

            }

        }

            #endregion


    }

    private void FixedUpdate()
    {


        #region Second Tell Part Devam�

       float horizontal =  Input.GetAxis("Horizontal");
       float vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal, 0f, vertical)* 8*Time.deltaTime);
        #endregion


        #region First Tell Part

        /*

              int layerMask = 1 << 6; // I��n�n hangi objeleri dikkate al�p almayaca��n� katmanlarla belirleyebiliyorum. Yani ���n�n davran��lar�n� katmanlara g�re belirleyebiliyoruz.

              // 6'�nc� katman� dikkate al ya da alma i�lemini yap�caz.

              // layermask: �����n hangi katman� dikkate alaca��n� veya almayaca��n� belirledi�imiz yerdir.

              // YAN� BU KOD  I�ININ UN�TY'DE  SADECE 6'INCI KATMANA SAH�P OLAN OBJELER� D�KKATE ALIR ! ! ! ! ! ! ! ! !

              layerMask = ~ layerMask ;   

              // YAN� BU KOD I�ININ   UN�TY'DE SADECE 6 'INCI KATMANI SAH�P OLAN OBJELER� D�KKATE ALMAZ ! ! ! ! ! ! ! ! !

              // ~ : Bu i�areti Ctrl + Alt + � �LE YAPARSIN ! ! ! !

               RaycastHit hit;

              if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity,layerMask))
              {

                  hit.transform.gameObject.name = "Vuruldum";
                  // hit.transform.GetComponent<MeshRenderer>().enabled = false;
                  // Destroy(hit.transform.gameObject);
                  Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                  Debug.Log("Hedef var.");



                  /* ------------------------- A�IKLAMALAR -------------------------

                   RaycastHit hit : I��n�n �arpt��� objenin bilgilerini alabilece�imiz bir kontrold�r.
                   transform.position : I��n�n ba�lang�� noktas�n� girmi� olduk.
                   transform.TransformDirection = I��n�n hangi y�nde ilerleyece�ine burdan karar veririz.
                   out hit : ���n� d��ar� veriyoruz.
                   Mathf.Infitiy : I��n�n menzilini belirtti�imiz yerdir. Sonsuzlu�u belirttik. Yani ���n ne kadarl�k bir mesafede objeleri yakalayabilsin.
                   Debug.DrawRay : Oyunun ba�lang�c�nda ���n� g�rebilmemiz i�in yazd�k.


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
