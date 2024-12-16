using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayerDamageReceiver : MonoBehaviour
{
    [SerializeField] private SO_PlayerData so_PlayerData;
    [SerializeField] private float damageToDeduct;

    private void OnDisable()
    {
        so_PlayerData.ReducedHealth(damageToDeduct);
    }
}
