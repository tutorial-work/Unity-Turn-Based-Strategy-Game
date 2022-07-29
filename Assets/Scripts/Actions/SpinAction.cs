/*
 * File Name: SpinAction.cs
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

public class SpinAction : BaseAction
{
    /************************************************************/
    #region Fields

    private float totalSpinAmount;

    #endregion
    /************************************************************/
    #region Functions

    private void Update()
    {
        if (!isActive)
        {
            return;
        }
        
        float spinAddAmount = 360f * Time.deltaTime;
        transform.eulerAngles += new Vector3(0, spinAddAmount, 0);

        totalSpinAmount += spinAddAmount;
        if (totalSpinAmount >= 360f)
        {
            ActionComplete();
        }
    }

    public override void TakeAction(GridPosition gridPosition, Action onActionComplete)
    {
        totalSpinAmount = 0f;
        ActionStart(onActionComplete);
    }

    public override List<GridPosition> GetValidActionGridPositionList()
    {
        GridPosition unitGridPosition = unit.GetGridPosition();

        return new List<GridPosition>
        {
            unitGridPosition
        };
    }

    public override string GetActionName()
    {
        return "Spin";
    }

    public override int GetActionPointsCost()
    {
        return 1;
    }

    public override EnemyAIAction GetEnemyAIAction(GridPosition gridPosition)
    {
        return new EnemyAIAction
        {
            gridPosition = gridPosition,
            actionValue = 0,
        };
    }

    #endregion
    /************************************************************/
}
