/*
 * File Name: Unit.cs
 * Description: This script is for ...
 * 
 * Author(s): DefaultCompany, Will Lacey
 * Date Created: July 21, 2022
 * 
 * Additional Comments:
 *		File Line Length: 120
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    /************************************************************/
    #region Fields

    Vector3 targetPosition;

    #endregion
	/************************************************************/
    #region Properties

    #endregion
    /************************************************************/
    #region Functions

    private void Update()
    {
        float stoppingDistance = .1f;
        if (Vector3.Distance(transform.position, targetPosition) > stoppingDistance)
        {
            Vector3 moveDirection = (targetPosition - transform.position).normalized;
            float moveSpeed = 4f;
            transform.position += moveDirection * moveSpeed * Time.deltaTime;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Move(MouseWorld.GetPosition());
        }

    }

    private void Move(Vector3 targetPosition)
    {
        this.targetPosition = targetPosition;
    }


    #endregion
    /************************************************************/
}