using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataView : MonoBehaviour
{
    [SerializeField] private SO_PlayerData so_PlayerData;
    private void OnEnable()
    {
        so_PlayerData.GetPlayerHealth();
        Debug.Log((so_PlayerData.GetPlayerHealth()));
    }
}
