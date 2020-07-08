using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HigherLower : MonoBehaviour
{

    public GameObject cardHolder;
    public Text totalCardsLeft;
    public Text currentRecord;

    public static HigherLower instance;

    void Start(){
        instance = this;
    }

    public void PressedButton(int direction, Card playedCard){
        cardHolder.GetComponentInChildren<Text>().text = "" + playedCard.cardName + " of " + playedCard.suit;
        totalCardsLeft.text = "" + GameManager.instance.deck.Count.ToString() + "/" + 56;
        if(GameManager.instance.deck.Count <= 1){
            GameOver(true);
        }
    }

    public void GameOver(bool win){
        currentRecord.text = "Current Record: "  + (56 - GameManager.instance.deck.Count);
        totalCardsLeft.text = "Game Over!";
        if(win)
            totalCardsLeft.text += " You won!";
        else
            totalCardsLeft.text += " You lost.";
    }
    
}
