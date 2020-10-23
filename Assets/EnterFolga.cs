using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterFolga : MonoBehaviour
{
    public GameObject PressClosed;
    public GameObject PressAnim;
    public GameObject PressOpen;
    public GameObject FolgaOld;

    Animator anim;

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "FolgaSec001"){
            anim = GetComponent<Animator>();
            Debug.Log("Enter folga");
            PressClosed.SetActive(false);
            FolgaOld.SetActive(false);
            PressAnim.SetActive(true);
            Debug.Log("Plaied animation");
            StartCoroutine("OnDoneAnimation");
        }
    }
    IEnumerator OnDoneAnimation() {
        yield return new WaitForSeconds(4);
        //PressAnim.SetActive(false);
        //PressOpen.SetActive(true);
        Debug.Log("Model changed to open");
    }
}
