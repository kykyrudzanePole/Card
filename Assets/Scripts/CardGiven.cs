using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardGiven : MonoBehaviour
{
    public Card SelfCard;
    public Image image = null;

    public void ShowCardInfo(Card card)
    {
        SelfCard = card;
        image.GetComponent<Image>().sprite = card.Logo;
        image.preserveAspect = true;
    }

    public void HideCardInfo(Card card)
    {
        SelfCard = card;
        image.sprite = card.Logo;
    }
}
