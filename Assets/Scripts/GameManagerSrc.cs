using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game
{
    public List<Card> EnemyDeck, PlayerDeck;
    public int Rand = 0;        

    public Game ()
    {
        EnemyDeck = GiveDeckCard();
        PlayerDeck = GiveDeckCard();
    }
    
    List<Card> GiveDeckCard()
    {
        List<Card> list = new List<Card>();

        for (int i = 0; i < 3; i++)
        {
            Rand = Random.Range(0, ChosenCards.copySelectedCards.Count);
            list.Add(ChosenCards.copySelectedCards[Rand]);
            ChosenCards.copySelectedCards.RemoveAt(Rand);
            Rand = 0;
        }
        return list;
    }
}

public class GameManagerSrc : MonoBehaviour
{
    public Game CurrentGame;
    public Transform EnemyHand, PlayerHand,
                     EnemyFirstField, EnemySecondField,
                     PlayerFirstField, PlayerFirstField;
                     
    public GameObject CardPref;
    int turn, turnTime = 30;

    public TextMeshProUGUI turnTimeTxt;
    public Button endTurnButton;

    public Text Gold, EnemyGold;

    public GameObject preview;
    public GameObject previewInGame;
    public static int a = 350, b = 250, c = 0;

    public static GameManagerSrc GMS;

    public List<CardGiven> PlayerHandCards = new List<CardGiven>(),
                             PlayerFieldCards = new List<CardGiven>(),
                             PlayerBuildFieldCards = new List<CardGiven>(),
                             EnemyHandCards = new List<CardGiven>(),
                             EnemyFieldCards = new List<CardGiven>(),
                             EnemyBuildFieldCards = new List<CardGiven>();

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
        GMS = new GameManagerSrc();
        GiveHandCards(CurrentGame.EnemyDeck, EnemyHand);
        GiveHandCards(CurrentGame.PlayerDeck, PlayerHand);

        StartCoroutine(TurnFunc());
    }
    
    void GiveHandCards(List<Card> deck, Transform hand)
    {
        int i = 0;
        while (i++ < 5)
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
            EnemyHandCards.Add(cardGO.GetComponent<CardGiven>());
        }
        else
        {
            a += 150;
            previewInGame = Instantiate(preview, new Vector3(a, b, c), transform.rotation = Quaternion.identity);
            previewInGame.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, true);
            previewInGame.GetComponent<Image>().sprite = card.Logo;
            Destroy(previewInGame, 3f);
            cardGO.GetComponent<CardGiven>().ShowCardInfo(card);
            PlayerHandCards.Add(cardGO.GetComponent<CardGiven>());
        }
        deck.RemoveAt(0);
    }
    public void ChangeTurn()
    {

        StopAllCoroutines();
        turn++;


        endTurnButton.interactable = isPlayerTurn;

        if (isPlayerTurn)
            GiveNewCard();
        else
            if (EnemyHandCards.Count > 0)
        {
            EnemyTurn(EnemyHandCards);
            GiveNewCard();
            turn++;
            endTurnButton.interactable = isPlayerTurn;
            StartCoroutine(TurnFunc());
        }
    }

    void GiveNewCard()
    {
        GiveCardToHand(CurrentGame.EnemyDeck, EnemyHand);
        a = 350;
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
            if (EnemyHandCards.Count > 0)
                EnemyTurn(EnemyHandCards);
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
    void EnemyTurn(List<CardGiven> cards)
    {
        int field = Random.Range(0, 2);
        int counts = 2;             // one card

        for (int i = 0; i < counts; i++)
        {

            if (field == 1)
            {
                EnemyGold.text = (int.Parse(EnemyGold.text) - cards[0].Cost).ToString();
                cards[0].ShowCardInfo(cards[0].SelfCard);
                cards[0].transform.SetParent(EnemyFirstField);
            }
            else
            {
                //Debug.Log((int.Parse(EnemyGold.text) - cards[0].Cost).ToString());
                Debug.Log(cards[0].Cost);
                EnemyGold.text = (int.Parse(EnemyGold.text) - cards[0].Cost).ToString();
                cards[0].ShowCardInfo(cards[0].SelfCard);
                cards[0].transform.SetParent(EnemySecondField);
            }

            EnemyFieldCards.Add(cards[0]);
            EnemyHandCards.Remove(cards[0]);
        }
    }
    public static void Change(Card card)
    {
        Debug.Log("Im HERE");
        /*
        foreach(Card element in ChosenCards.selectedCards)
        {
            Debug.Log("Element ID:" + element.ID + "card ID" + card.ID);
            if(element.ID == AnimationAttack.tempAttackCard[0].ID)
            {
                element.HP = 50;
                for(int i = 0; i < GMS.EnemyFieldCards.Count; i++)
                {
                    Debug.Log(GMS.EnemyFieldCards[i].ID);
                }
            }
        }
        */
        for(int i = 0; i < ChosenCards.selectedCards.Count;i++) {
            if(ChosenCards.selectedCards[i].ID == card.ID)
            {
                var Temp = ChosenCards.selectedCards[i];
                Temp.HP += 10;
                ChosenCards.selectedCards[i] = Temp;
            }
        }
    }
}
