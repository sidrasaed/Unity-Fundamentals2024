using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData",menuName = "ScriptableObject/EnemyData", order = 1)]
public class SO_EnemyDataModel : ScriptableObject
{
    [SerializeField] float enemyHealth;
    [SerializeField] Color enemyColor;
}
