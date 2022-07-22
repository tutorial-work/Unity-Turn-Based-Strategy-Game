/*
 * File Name: MouseWorld.cs
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

public class MouseWorld : MonoBehaviour
{
    /************************************************************/
    #region Fields

    private static MouseWorld instance;

    [SerializeField] private LayerMask mousePlaneLayerMask;

    #endregion
    /************************************************************/
    #region Functions

    private void Awake()
    {
        instance = this;
    }

    private void Update() {
        transform.position = GetPosition();
    }

    public static Vector3 GetPosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, instance.mousePlaneLayerMask);
        return raycastHit.point;
    }


    #endregion
    /************************************************************/
}
