using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterFolga : MonoBehaviour
{
    public GameObject PressClosed;
    public GameObject PressAnim;
    public GameObject PressOpen;
  //  public GameObject LastFolga;

    float reloadTimer = 0.1f;
    void Start()
    {
        
    }
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "FolgaThi001"){
            Debug.Log("Enter folga");
            PressClosed.SetActive(false);
            // PressOpen.SetActive(false);
            PressAnim.SetActive(true);

            //reloadTimer -= Time.deltaTime;
            //if (reloadTimer>0)
            //{
            //    Debug.Log(reloadTimer);
            //}
            
           // if (reloadTimer <= 0)
          //  {


                Debug.Log("Plaied animation");
                //PressAnim.SetActive(false);
                //PressOpen.SetActive(true);
                //Debug.Log("Model changed to open");



          //  }


                

            
        }
    }


    void Update()
    {
    }
}
