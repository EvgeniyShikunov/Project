using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrajectoryRenderer : MonoBehaviour
{
    public LineRenderer _lineRendererComponent;
    public GameObject _LRC;
    void Start()
    {
        _lineRendererComponent = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        MoveLineRenderer();
    }

    public void ShowTrajectory(Vector3 origin, Vector3 speed)
    {
        Vector3[] points = new Vector3[100];
        _lineRendererComponent.positionCount = points.Length;

        for (int i = 0; i < points.Length; i++)
        {
            float time = i * 0.1f;
            points[i] = origin + speed * time + Physics.gravity * time * time / 2f;
        }

        _lineRendererComponent.SetPositions(points);
    }

    void MoveLineRenderer()
    {
        if (Input.GetMouseButton(1))
        {
            _LRC.SetActive(true);
        }
    }

}
