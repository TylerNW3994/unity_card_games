using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayCards : MonoBehaviour
{
    private int pullCardIndex;

    public static PlayCards instance;

    void Start(){
        instance = this;
    }

    public Card DrawCard(){
        Card playedCard = GameManager.instance.deck[0];
        GameManager.instance.deck.RemoveAt(0);
        return playedCard;
    }
}
