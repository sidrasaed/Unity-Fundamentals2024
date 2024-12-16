using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDataFiller : MonoBehaviour
{
    [SerializeField] private SO_EnemyDataModel _enemyDataModel;

    private void OnEnable()
    {
        var meshRenderer = GetComponent<MeshRenderer>();
        var material = meshRenderer.material;
        var color = material.color;
    }
}
