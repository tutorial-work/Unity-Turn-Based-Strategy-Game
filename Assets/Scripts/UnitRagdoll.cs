/*
 * File Name: UnitRagdoll.cs
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

public class UnitRagdoll : MonoBehaviour
{
    /************************************************************/
    #region Fields

    [SerializeField] private Transform ragdollRootBone;

    #endregion
    /************************************************************/
    #region Functions

    public void Setup(Transform originalRootBone)
    {
        MatchAllChildTransforms(originalRootBone, ragdollRootBone);

        // TODO: calculate the position from where the attack took place from 
        ApplyExplosionToRagdoll(ragdollRootBone, 300f, transform.position, 10f);
    }

    private void MatchAllChildTransforms(Transform root, Transform clone)
    {
        foreach (Transform child in root)
        {
            Transform cloneChild = clone.Find(child.name);
            if (cloneChild != null)
            {
                cloneChild.position = child.position;
                cloneChild.rotation = child.rotation;

                MatchAllChildTransforms(child, cloneChild);
            }
        }
    }

    private void ApplyExplosionToRagdoll(Transform root, float explosionForce, Vector3 explosionPosition, float explosionRange)
    {
        foreach (Transform child in root)
        {
            if (child.TryGetComponent<Rigidbody>(out Rigidbody childRigidbody))
            {
                childRigidbody.AddExplosionForce(explosionForce, explosionPosition, explosionRange);
            }

            ApplyExplosionToRagdoll(child, explosionForce, explosionPosition, explosionRange);
        }
    }

    #endregion
    /************************************************************/
}
