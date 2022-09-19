using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keypickup : MonoBehaviour
{
    public AudioSource PickupSFX;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<keycontrol>().KeyHas = true;
            PickupSFX.Play();
            Destroy(gameObject, 1);
        }
    }
}
