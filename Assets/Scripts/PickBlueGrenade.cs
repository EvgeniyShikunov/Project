using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickBlueGrenade : MonoBehaviour
{
    public GameObject _BlueGrenade;
    public GameObject _PickedBlueGrenade;
    public GameObject _BlueGrenadeTrigger;

    public void OnTriggerStay(Collider other)
    {
        if (Input.GetMouseButtonDown(0))
        {
            _BlueGrenade.SetActive(false);
            _PickedBlueGrenade.SetActive(true);
            _BlueGrenadeTrigger.SetActive(false);
        }
    }
}
