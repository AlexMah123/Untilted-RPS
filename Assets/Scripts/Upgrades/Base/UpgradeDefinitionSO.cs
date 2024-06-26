using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering.Universal;
using UnityEngine;
using UnityEngine.UI;

public abstract class UpgradeDefinitionSO : ScriptableObject
{
    [Header("User Interface Configs")]
    public Image upgradeImage;
    public string upgradeName;
    
    [Multiline]
    public string upgradeDefinition;

    [Header("Gameplay Configs")]
    public bool isActivatable;
    public UPGRADE_TYPE upgradeType;

    public virtual void ApplyPassiveEffect(IPlayer player)
    {

    }

    public virtual void ApplyActivatableEffect(IPlayer player)
    {
        Debug.Log($"Activating Effect of {this.GetType()}");
    }

    public virtual void OnWinRound(IPlayer player)
    {
        Debug.Log($"Applying OnWin Effect of {this.GetType()}");

    }

    public virtual void OnLoseRound(IPlayer player)
    {
        Debug.Log($"Applying OnLose Effect of {this.GetType()}");

    }

    public virtual void OnDrawRound(IPlayer player)
    {
        Debug.Log($"Applying OnDraw Effect of {this.GetType()}");

    }
}
