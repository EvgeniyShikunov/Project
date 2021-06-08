using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] _enemy;
    public Transform[] _spawnPoint;

    private int _rand;
    private int _randPosition;
    public float _startTimeBtwSpawns;
    private float _timeBtwSpawns;
    // Start is called before the first frame update
    void Start()
    {
       _timeBtwSpawns = _startTimeBtwSpawns;
    }

    // Update is called once per frame
    void Update()
    {
        if (_timeBtwSpawns <= 0)
        {
            _rand = Random.Range(0, _enemy.Length);
            _randPosition = Random.Range(0, _spawnPoint.Length);
            Instantiate(_enemy[_rand], _spawnPoint[_randPosition].transform.position, Quaternion.identity);
            _timeBtwSpawns = _startTimeBtwSpawns;
        }
        else
        {
            _timeBtwSpawns -= Time.deltaTime;
        }
    }
}
