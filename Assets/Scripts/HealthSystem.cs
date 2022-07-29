/*
 * File Name: HealthSystem.cs
 * Description: This script is for ...
 * 
 * Author(s): DefaultCompany, Will Lacey
 * Date Created: July 28, 2022
 * 
 * Additional Comments:
 *		File Line Length: 120
 */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    /************************************************************/
    #region Events

    public event EventHandler OnDead;
    public event EventHandler OnDamaged;

    #endregion
    /************************************************************/
    #region Fields

    [SerializeField] private int health = 100;

    private int healthMax;

    #endregion
    /************************************************************/
    #region Functions

    private void Awake()
    {
        healthMax = health;
    }

    public void Damage(int damageAmount)
    {
        health -= damageAmount;

        if (health < 0)
        {
            health = 0;
        }

        OnDamaged?.Invoke(this, EventArgs.Empty);

        if (health == 0)
        {
            Die();
        }

        Debug.Log(health);
    }

    private void Die()
    {
        OnDead?.Invoke(this, EventArgs.Empty);
    }

    public float GetHealthNormalized()
    {
        return (float)health / healthMax;
    }

    #endregion
    /************************************************************/
}
