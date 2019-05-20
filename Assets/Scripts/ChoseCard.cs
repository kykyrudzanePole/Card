using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChoseCard : MonoBehaviour , IPointerClickHandler
{

    public Image choseCard;
    public static List<Card> selectedCards = new List<Card>();
    public void OnPointerClick(PointerEventData eventData)
    {
        foreach(Card element in CardManager.AllCards)
        {
            if(element.Logo == choseCard.sprite)
            {
                selectedCards.Add(new Card(element.ID, element.Name, element.LogoPath, element.Attack, element.Defense, element.Status));
            }
        }
        foreach (Card test in selectedCards)
        {
            Debug.Log(test.Name);
        }
        choseCard.sprite = Resources.Load<Sprite>("Cards/BG/BackgroundForEmpire");
    }
}
