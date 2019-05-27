using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game
{
    public List<Card> EnemyDeck, PlayerDeck,
                      EnemyHand, PlayerHand,
                      EnemyField, PlayerField;

    public Game ()
    {
        EnemyDeck = GiveDeckCard();
        PlayerDeck = GiveDeckCard();

        EnemyHand = new List<Card>();
        PlayerHand = new List<Card>();

        EnemyField = new List<Card>();
        PlayerField = new List<Card>();
    }
    
    List<Card> GiveDeckCard()
    {
        List<Card> list = new List<Card>();

        for (int i = 0; i < 2; i++)
            list.Add(ChosenCards.selectedCards[Random.Range(0, ChosenCards.selectedCards.Count)]);
        return list;
    }
}

public class GameManagerSrc : MonoBehaviour
{
    public Game CurrentGame;
    public Transform EnemyHand, PlayerHand;
    public GameObject CardPref;
    int turn, turnTime = 30;
    public TextMeshProUGUI turnTimeTxt;
    public Button endTurnButton;
    public GameObject preview;
    public GameObject previewInGame;
    public static int a = 300, b = 250, c = 0;

    public bool isPlayerTurn
    {
        get
        {
            return turn % 2 == 0;
        }
    }

    void Start()
    {
        turn = 0;
        CurrentGame = new Game();
        GiveHandCards(CurrentGame.EnemyDeck, EnemyHand);
        GiveHandCards(CurrentGame.PlayerDeck, PlayerHand);

        StartCoroutine(TurnFunc());
    }
    
    void GiveHandCards(List<Card> deck, Transform hand)
    {
        int i = 0;
        while (i++ < 3)
            GiveCardToHand(deck, hand);
    }

    void GiveCardToHand(List<Card> deck, Transform hand)
    {
        if (deck.Count == 0)
            return;

        Card card = deck[0];

        GameObject cardGO = Instantiate(CardPref, hand, false);

        if (hand == EnemyHand)
        {
            cardGO.GetComponent<CardGiven>().HideCardInfo(card);
        }
        else
        {
            a += 150;
            previewInGame = Instantiate(preview, new Vector3(a, b, c), transform.rotation = Quaternion.identity);
            previewInGame.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, true);
            previewInGame.GetComponent<Image>().sprite = card.Logo;
            Destroy(previewInGame, 3f);
            cardGO.GetComponent<CardGiven>().ShowCardInfo(card);
        }
        deck.RemoveAt(0);
    }
    public void ChangeTurn()
    {
        turn++;

        StopAllCoroutines();

        endTurnButton.interactable = isPlayerTurn;

        if (isPlayerTurn)
            GiveNewCard();
    }

    void GiveNewCard()
    {
        GiveCardToHand(CurrentGame.EnemyDeck, EnemyHand);
        GiveCardToHand(CurrentGame.PlayerDeck, PlayerHand);
    }

    IEnumerator TurnFunc ()
    {
        turnTime = 30;
        turnTimeTxt.text = turnTime.ToString();

        if (isPlayerTurn)
        {
            while (turnTime-- > 0)
            {
                turnTimeTxt.text = turnTime.ToString();
                yield return new WaitForSeconds(1);
            }
        } else
        {
            while (turnTime-- > 27)
            {
                turnTimeTxt.text = turnTime.ToString();
                yield return new WaitForSeconds(1);
                
            } 
        }
        ChangeTurn();
    }
}
