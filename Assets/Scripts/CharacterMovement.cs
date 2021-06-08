using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float _speedMove; // скорость персонажа

    private Vector3 _moveVector; // направление движения

    public TrajectoryRenderer Trajectory;

    private CharacterController _ch_controller; // ссылка на компонент
    void Start()
    {
        _ch_controller = GetComponent<CharacterController>();
    }

 
    void Update()
    {
        CharacterMove();
        Trajectory.ShowTrajectory(transform.position, _moveVector);
    }

   // метод перемещения персонажа
    private void CharacterMove()
    {
        // перемещение по поверхности
        _moveVector = Vector3.zero;
        _moveVector.x = Input.GetAxis("Horizontal") * _speedMove;
        _moveVector.z = Input.GetAxis("Vertical") * _speedMove;

        _ch_controller.Move(_moveVector * Time.deltaTime); // передвижение по направлению
    }
}
