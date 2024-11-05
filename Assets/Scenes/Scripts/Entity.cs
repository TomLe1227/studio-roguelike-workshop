using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;
using Unity.VisualScripting;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting.Antlr3.Runtime.Misc;

[Serializable]
public class EntityStats{
    public float MaxHealth;
    public float MovementSpeed;
}
public class Entity : MonoBehaviour
{
    public EntityStats stats;
    [NonSerialized]
    public float CurrentHealth;
    bool dead = false;
    public void Start()
    {
    CurrentHealth = stats.MaxHealth;
    }
    public void TakeDamage(float damage){
        CurrentHealth -= Mathf.Ceil(damage);
        if (CurrentHealth <= 0){
            Die();
        }
    }
    private void Die(){
        dead = true;
        Destroy(gameObject);
    }
    public float health;
}