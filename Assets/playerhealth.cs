using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class playerhealth : MonoBehaviour
{
    public float MaxHealth = 100;
    private float health;
    private bool canReceiveDamage = true; 
    public float invincibilityTimer = 3;

    public delegate void HealthChangedHandler(float newhealth, float amountChanged);
    public event HealthChangedHandler OnHealthChanged;

    public delegate void HealthInitializedHandler(float newhealth);
    public event HealthInitializedHandler OnHealthInitialized;

    void Start()
    {
        health = MaxHealth;
        OnHealthInitialized?.Invoke(health);

    }
    public void AddDamage(float damage)
    {
        if (canReceiveDamage)
        {
            health -= damage;
            OnHealthChanged?.Invoke(health, -damage);
            canReceiveDamage = false;
            StartCoroutine(InvincibilityTimer(invincibilityTimer, ResetInvincibility));
        }
        Debug.Log(health);
    }

    IEnumerator InvincibilityTimer(float time, Action callback)
    {
        yield return new WaitForSeconds(time);
        callback.Invoke();
    }

    private void ResetInvincibility()
    {
        canReceiveDamage = true;
    }
    public void AddHealth(float healthToAdd)
    {
        health += healthToAdd;
        OnHealthChanged?.Invoke(health, healthToAdd);
        Debug.Log(health); 
    }
}
