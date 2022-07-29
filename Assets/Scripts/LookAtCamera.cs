/*
 * File Name: LookAtCamera.cs
 * Description: This script is for ...
 * 
 * Author(s): DefaultCompany, Will Lacey
 * Date Created: July 28, 2022
 * 
 * Additional Comments:
 *		File Line Length: 120
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    /************************************************************/
    #region Fields

    [SerializeField] private bool invert;

    private Transform cameraTransform;

    #endregion
    /************************************************************/
    #region Functions

    private void Awake()
    {
        cameraTransform = Camera.main.transform;
    }

    private void LateUpdate()
    {
        if (invert)
        {
            Vector3 dirToCamera = (cameraTransform.position - transform.position).normalized;
            transform.LookAt(transform.position + dirToCamera * -1);
        } else
        {
            transform.LookAt(cameraTransform);
        }
    }

    #endregion
    /************************************************************/
}
