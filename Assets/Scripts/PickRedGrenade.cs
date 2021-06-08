using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickRedGrenade : MonoBehaviour
{
    public GameObject _RedGrenade;
    public GameObject _PickedRedGrenade;
    public GameObject _RedGrenadeTrigger;

    public void OnTriggerStay(Collider other)
    {
        if (Input.GetMouseButtonDown(0))
        {
            _RedGrenade.SetActive(false);
            _PickedRedGrenade.SetActive(true);
            _RedGrenadeTrigger.SetActive(false);
        }
    }
}
