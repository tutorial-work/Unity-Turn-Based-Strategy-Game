/*
 * File Name: UnitActionSystem.cs
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
using System;

public class UnitActionSystem : MonoBehaviour
{
    /************************************************************/
    #region Fields

    [SerializeField] private Unit selectedUnit;
    [SerializeField] private LayerMask unitLayerMask;
    
    public event EventHandler OnSelectedUnitChanged;

    #endregion
    /************************************************************/
    #region Properties

    public static UnitActionSystem Instance { get; private set; }

    #endregion
    /************************************************************/
    #region Functions

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("There's more than one UnitActionSystem! " + transform + " - " + Instance);
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (TryHandleUnitSelection()) return;

            selectedUnit.Move(MouseWorld.GetPosition());
        }
    }

    private bool TryHandleUnitSelection()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, unitLayerMask))
        {
            if (raycastHit.transform.TryGetComponent(out Unit unit))
            {
                SetSelectedUnit(unit);
                return true;
            }
        }

        return false;
    }

    private void SetSelectedUnit(Unit unit)
    {
        selectedUnit = unit;

        OnSelectedUnitChanged?.Invoke(this, EventArgs.Empty);
    }

    public Unit GetSelectedUnit()
    {
        return selectedUnit;
    }


    #endregion
    /************************************************************/
}
