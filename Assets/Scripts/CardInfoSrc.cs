using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CardInfoSrc : MonoBehaviour
{
    public Card SelfCard;
    public Image image = null;

    public void ShowCardInfo(Card card)
    {
        SelfCard = card;
        image.GetComponent<Image>().sprite = card.Logo;
        image.preserveAspect = true;
    }

    private void Start()
    {
        // ShowCardInfo(CardManager.AllCards[0]);
        ShowCardInfo(CardManager.AllCards[transform.GetSiblingIndex()]);       //  show enemy cards
        /*foreach(Card element in CardManager.AllCards)
        {
            ShowCardInfo(CardManager.AllCards[element.ID]);
        }*/
    }

    public void HideCardInfo(Card card)
    {
        SelfCard = card;
        image.sprite = null;
    }
}
