/*
 * File Name: GridDebugObject.cs
 * Description: This script is for ...
 * 
 * Author(s): DefaultCompany, Will Lacey
 * Date Created: July 22, 2022
 * 
 * Additional Comments:
 *		File Line Length: 120
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GridDebugObject : MonoBehaviour
{
    /************************************************************/
    #region Fields

    [SerializeField] private TextMeshPro textMeshPro;

    private GridObject gridObject;

    #endregion
    /************************************************************/
    #region Functions

    public void SetGridObject(GridObject gridObject)
    {
        this.gridObject = gridObject;
    }

    private void Update()
    {
        textMeshPro.text = gridObject.ToString();
    }

    #endregion
    /************************************************************/
}
