/*
 * File Name: UnitWorldUI.cs
 * Description: This script is for ...
 * 
 * Author(s): DefaultCompany, Will Lacey
 * Date Created: July 28, 2022
 * 
 * Additional Comments:
 *		File Line Length: 120
 */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UnitWorldUI : MonoBehaviour
{
    /************************************************************/
    #region Fields

    [SerializeField] private TextMeshProUGUI actionPointsText;
    [SerializeField] private Unit unit;
    [SerializeField] private Image healthBarImage;
    [SerializeField] private HealthSystem healthSystem;

    #endregion
    /************************************************************/
    #region Functions

    private void Start()
    {
        Unit.OnAnyActionPointsChanged += Unit_OnAnyActionPointsChanged;
        healthSystem.OnDamaged += HealthSystem_OnDamaged;

        UpdateActionPointsText();
        UpdateHealthBar();
    }

    private void UpdateActionPointsText()
    {
        actionPointsText.text = unit.GetActionPoints().ToString();
    }

    private void Unit_OnAnyActionPointsChanged(object sender, EventArgs e)
    {
        UpdateActionPointsText();
    }

    private void UpdateHealthBar()
    {
        healthBarImage.fillAmount = healthSystem.GetHealthNormalized();
    }

    private void HealthSystem_OnDamaged(object sender, EventArgs e)
    {
        UpdateHealthBar();
    }

    #endregion
    /************************************************************/
}
