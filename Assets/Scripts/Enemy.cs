using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int _maxHealth = 100; // максимальное хп врага
    public int _health = 100; // текущее хп врага
    public Text _HPText;

   public Enemy(int _maxHealth, int _health)
    {
        this._maxHealth = _maxHealth;
        this._health = _health;
    }

    public int getMaxHealth() { return _maxHealth; }
    public void setMaxHealth(int maxHP) { _maxHealth = maxHP; }
    public int getHealth() { return _health; }
    public void setHealth(int hp) { _health = hp; }

    public GameObject EnemyObject;

    public void Start()
    {
        
    }
    public void Enemy_Death()
    {
        if (_health == 0)
        {
            //Destroy(EnemyObject);
        }
    }
    void Update()
    {
        Enemy_Death();
    }
}
