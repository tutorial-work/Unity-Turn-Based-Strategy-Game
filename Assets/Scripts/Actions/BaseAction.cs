/*
 * File Name: BaseAction.cs
 * Description: This script is for ...
 * 
 * Author(s): DefaultCompany, Will Lacey
 * Date Created: July 26, 2022
 * 
 * Additional Comments:
 *		File Line Length: 120
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class BaseAction : MonoBehaviour
{
    /************************************************************/
    #region Fields

    protected Unit unit;
    protected bool isActive;
    protected Action onActionComplete;

    #endregion
    /************************************************************/
    #region Fields

    protected virtual void Awake()
    {
        unit = GetComponent<Unit>();
    }

    #endregion
    /************************************************************/
}
