/*
 * File Name: ScreenShake.cs
 * Description: This script is for ...
 * 
 * Author(s): DefaultCompany, Will Lacey
 * Date Created: July 31, 2022
 * 
 * Additional Comments:
 *		File Line Length: 120
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ScreenShake : MonoBehaviour
{
    /************************************************************/
    #region Fields

    private CinemachineImpulseSource cinemachineImpulseSource;
    
    #endregion
    /************************************************************/
    #region Properties

    public static ScreenShake Instance { get; private set; }

    #endregion
    /************************************************************/
    #region Functions

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("There's more than one ScreenShake! " + transform + " - " + Instance);
            Destroy(gameObject);
            return;
        }
        Instance = this;

        cinemachineImpulseSource = GetComponent<CinemachineImpulseSource>();
    }

    public void Shake(float intensity = 1f)
    {
        cinemachineImpulseSource.GenerateImpulse(intensity);
    }

    #endregion
    /************************************************************/
}
