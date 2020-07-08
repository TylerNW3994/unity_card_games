using System; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Card> deck = new List<Card>();

    public static GameManager instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        NewGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewGame(){
        CreateDeck();
        ShuffleDeck();
    }

    public void CreateDeck(){
        //Delete deck when starting new game
        deck.Clear();

        //For each value
        for(int i = 1; i <= 14; i++){
            Card cardToAdd = new Card();
            cardToAdd.cardValue = i;
            //If not a face card
            if(i < 11){
                cardToAdd.cardName = i.ToString();
            }
            else if(i == 11){ cardToAdd.cardName = "J"; }
            else if(i == 12){ cardToAdd.cardName = "Q"; }
            else if(i == 13){ cardToAdd.cardName = "K"; }
            else if(i == 14){ cardToAdd.cardName = "A"; }

            //For each suit
            for(int suitNum = 0; suitNum < 4; suitNum++){
                switch(suitNum){
                    case 0: cardToAdd.suit = "Hearts"; break;
                    case 1: cardToAdd.suit = "Diamonds"; break;
                    case 2: cardToAdd.suit = "Spades"; break;
                    case 3: cardToAdd.suit = "Clubs"; break;
                }
            }

            deck.Add(cardToAdd);
        }
    }

    static System.Random r = new System.Random();
    public void ShuffleDeck(){
        for (int n = deck.Count - 1; n > 0; --n)
        {
            int k = r.Next(n+1);
            Card temp = deck[n];
            deck[n] = deck[k];
            deck[k] = temp;
        }
    }
}
