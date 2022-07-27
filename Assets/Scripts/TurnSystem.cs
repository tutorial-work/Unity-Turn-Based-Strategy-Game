/*
 * File Name: TurnSystem.cs
 * Description: This script is for ...
 * 
 * Author(s): DefaultCompany, Will Lacey
 * Date Created: July 26, 2022
 * 
 * Additional Comments:
 *		File Line Length: 120
 */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSystem : MonoBehaviour
{
    /************************************************************/
    #region Fields

    public event EventHandler OnTurnChanged;

    private int turnNumber = 1;

    #endregion
    /************************************************************/
    #region Properties

    public static TurnSystem Instance { get; private set; }

    #endregion
    /************************************************************/
    #region Functions

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("There's more than one TurnSystem! " + transform + " - " + Instance);
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }


    public void NextTurn()
    {
        turnNumber++;

        OnTurnChanged?.Invoke(this, EventArgs.Empty);
    }

    public int GetTurnNumber()
    {
        return turnNumber;
    }

    #endregion
    /************************************************************/
}
