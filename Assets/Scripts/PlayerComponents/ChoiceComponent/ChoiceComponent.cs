using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public enum GameChoice
{
    ROCK,
    PAPER,
    SCISSOR
}

public class ChoiceComponent : MonoBehaviour
{
    public event Action OnSealChoiceEvent;

    public Dictionary<GameChoice, bool> choicesAvailable = new Dictionary<GameChoice, bool> {
        { GameChoice.ROCK, true },
        { GameChoice.PAPER, true },
        { GameChoice.SCISSOR, true },
    };

    public bool IsChoiceAvailable(GameChoice choice)
    {
        return choicesAvailable[choice];
    }

    public void SealChoice(GameChoice choice)
    {
        choicesAvailable[choice] = false;

        //#TODO: broadcast event to PlayerHandUIManager to update
        OnSealChoiceEvent?.Invoke();
    }

    public void ResetChoicesAvailable()
    {
        foreach(var key in choicesAvailable.Keys)
        {
            choicesAvailable[key] = true;
        }
    }

    public List<GameChoice> FetchAllChoicesAvailable()
    {
        //query through the dictionary to get all game choices that are true, and return the key.
        List<GameChoice> queriedChoices = choicesAvailable.Where(x => x.Value == true).Select(x => x.Key).ToList();
        return queriedChoices;
    }
}
