/*
 * File Name: GridSystemVisualSingle.cs
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

public class GridSystemVisualSingle : MonoBehaviour
{
    /************************************************************/
    #region Fields

    [SerializeField] private MeshRenderer meshRenderer;

    #endregion
    /************************************************************/
    #region Functions

    public void Show()
    {
        meshRenderer.enabled = true;
    }

    public void Hide()
    {
        meshRenderer.enabled = false;
    }

    #endregion
    /************************************************************/
}
