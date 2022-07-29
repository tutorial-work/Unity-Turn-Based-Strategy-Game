/*
 * File Name: EnemyAI.cs
 * Description: This script is for ...
 * 
 * Author(s): DefaultCompany, Will Lacey
 * Date Created: July 27, 2022
 * 
 * Additional Comments:
 *		File Line Length: 120
 */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    /************************************************************/
    #region Functions

    private float timer;

    #endregion
    /************************************************************/
    #region Functions

    private void Start()
    {
        TurnSystem.Instance.OnTurnChanged += TurnSystem_OnTurnChanged;
    }

    private void Update()
    {
        if (TurnSystem.Instance.IsPlayerTurn())
        {
            return;
        }

        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            TurnSystem.Instance.NextTurn();
        }
    }

    private void TurnSystem_OnTurnChanged(object sender, EventArgs e)
    {
        timer = 2f;
    }

    #endregion
    /************************************************************/
}
