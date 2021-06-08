using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMouse : MonoBehaviour
{
    float _rotationX;
    float _rotationY;
    float _rotationXcurrent;
    float _rotationYcurrent;
    public Camera _Player;
    public GameObject _PlayerGameObj;
    public float _sensivity = 5f;
    public float _smoothTime = 0.5f;
    float _currentVelosityX;
    float _currentVelosityY;

    private void Update()
    {
        MouseMove();
    }
    void MouseMove()
    {
        if (Input.GetMouseButton(0))
        {
            _rotationX += Input.GetAxis("Mouse X") * _sensivity;
            _rotationY += Input.GetAxis("Mouse Y") * _sensivity;
            _rotationY = Mathf.Clamp(_rotationY, -90, 90);

            _rotationXcurrent = Mathf.SmoothDamp(_rotationXcurrent, _rotationX, ref _currentVelosityX, _smoothTime);
            _rotationYcurrent = Mathf.SmoothDamp(_rotationYcurrent, _rotationY, ref _currentVelosityY, _smoothTime);

            _Player.transform.rotation = Quaternion.Euler(-_rotationYcurrent, _rotationXcurrent, 0f);
            _PlayerGameObj.transform.rotation = Quaternion.Euler(0f, _rotationXcurrent, 0f);
        }
        
    }
}
