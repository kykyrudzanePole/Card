using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardGiven : MonoBehaviour
{
    public Card SelfCard;
    public Image image = null;
    public int Cost;
    public GameObject HideObj;

    public void ShowCardInfo(Card card)
    {
        SelfCard = card;
        image.GetComponent<Image>().sprite = card.Logo;
        Cost = card.Cost;
        image.preserveAspect = true;

        HideObj.SetActive(false);
    }

    public void HideCardInfo(Card card)
    {
        Cost = card.Cost;
        SelfCard = card;
        HideObj.SetActive(true);
        //image.sprite = card.Logo;
    }
}
