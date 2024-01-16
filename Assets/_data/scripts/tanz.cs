using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tanz : MonoBehaviour
{
    public GameObject character;

    private void OnCollisionEnter(Collision collision)
    {
        character.GetComponent<Animator>().Play("posa2");
    }

    private void OnCollisionExit(Collision collision)
    {
        character.GetComponent<Animator>().Play("posa1");
    }


}
