using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickGreenGrenade : MonoBehaviour
{
    public GameObject _GreenGrenade;
    public GameObject _PickedGreenGrenade;
    public GameObject _GreenGrenadeTrigger;

    public void OnTriggerStay(Collider other)
    {
        if (Input.GetMouseButtonDown(0))
        {
            _GreenGrenade.SetActive(false);
            _PickedGreenGrenade.SetActive(true);
            _GreenGrenadeTrigger.SetActive(false);
        }
    }
}
