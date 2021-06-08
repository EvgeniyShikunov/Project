using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickYellowGrenade : MonoBehaviour
{
    public GameObject _YellowGrenade;
    public GameObject _PickedYellowGrenade;
    public GameObject _YellowGrenadeTrigger;

    public void OnTriggerStay(Collider other)
    {
        if (Input.GetMouseButtonDown(0))
        {
            _YellowGrenade.SetActive(false);
            _PickedYellowGrenade.SetActive(true);
            _YellowGrenadeTrigger.SetActive(false);
        }
    }
}
