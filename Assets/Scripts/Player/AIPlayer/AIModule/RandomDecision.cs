using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy/Decision/RandomDecisionSO")]
public class RandomDecision : AIDecision
{
    public override GameChoice MakeDecision()
    {
        GameChoice aiDecision = RandomChoice();
        if (choiceComponent.IsChoiceAvailable(aiDecision))
        {
            return aiDecision;
        }
        else
        {
            return MakeDecision();
        }
    }
}
