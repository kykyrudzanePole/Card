using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomCardFilling : MonoBehaviour
{
    public Image Logo;
    public Sprite test;
 



    private void Start()
    {
        Logo = GetComponent<Image>();
    }
    public void Update() 
    {
        if (CardMovementScript.flag)
        {
            foreach (Card element in CardManager.AllCards)
            {
                if(element.Logo == CardMovementScript.ZoomLogo)
                {
                    Logo.sprite = element.Logo;
                    var tempColor = Logo.color;
                    tempColor.a = 255f;
                    Logo.color = tempColor;
                }
            }
        }
        else
        {
            Logo.sprite = null;
            var tempColor = Logo.color;
            tempColor.a = 0f;
            Logo.color = tempColor;
        }
    }
}
