using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeHold : MonoBehaviour
{
    public bool _hold;
    public float _distance = 2f;
    RaycastHit2D _hit;
    public Transform _holdPoint;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!_hold)
            {
                Physics2D.queriesHitTriggers = false;
                _hit = Physics2D.Raycast(transform.position, Vector3.forward * transform.localScale.z, _distance);

                if (_hit.collider != null)
                {
                    _hold = true;
                }
            }
        }
        if (_hold)
        {
            _hit.collider.gameObject.transform.position = _holdPoint.position;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.right * transform.localScale.z * _distance);
    }
}
