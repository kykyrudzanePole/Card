﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public struct Parcel
{
    Sprite Path;
    public Parcel(Sprite LogoPath)
    {
        Path = LogoPath;
    }
}
public class AnimationAttack : MonoBehaviour, IPointerClickHandler
{
    public Game curentGame;
    public static GameObject clone;
    public static GameObject clone2;
    public GameObject Explosion;
    public GameObject cloneExplosion;

    public float speed = 500;
    public GameObject bullet;
    public GameObject BG;
    public static int click = 0;
    public bool trigger = false;
    public static bool flag1 = false;
    public static bool flag2 = false;
    public static bool attacked = false;
    public static int timer;
    public static string whoAttack;
    public static string ID;
    public static string changeHp;
    public static List<Card> tempAttackCard = new List<Card>();

    public void OnPointerClick(PointerEventData eventData)
    {
            if (click == 0 && (bullet.transform.parent.name == "firstLine" || bullet.transform.parent.name == "secondLine"))
            {
                if (bullet.transform.parent.name == "firstLine")
                {
                    whoAttack = "Melee";
                }
                else
                {
                    whoAttack = "Missile";
                }
                bullet.GetComponent<Image>().sprite = null;
                Debug.Log("0");
                clone = Instantiate(bullet, new Vector3(500, -150, 0), Quaternion.identity);
                clone.transform.localScale = new Vector3(0.35f, 0.35f, 0.35f);
                clone.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, true);
                clone.tag = "enemyCards";
                flag1 = true;

            }
            if (whoAttack == "Melee")
            {
                if (click == 1 && (bullet.transform.parent.name == "EfirstLine"))
                {
                    Debug.Log("1");
                    clone2 = Instantiate(bullet, new Vector3(500, 700, 0), Quaternion.identity);
                    clone2.transform.localScale = new Vector3(0.35f, 0.35f, 0.35f);
                    clone2.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, true);
                    clone2.tag = "enemyCards";
                    flag2 = true;
                tempAttackCard.Add(new Card(bullet.GetComponent<CardGiven>().ID, bullet.GetComponent<CardGiven>().Name,
                                            bullet.GetComponent<CardGiven>().LogoPath, bullet.GetComponent<CardGiven>().HP,
                                            bullet.GetComponent<CardGiven>().Defense, bullet.GetComponent<CardGiven>().Attack,
                                            bullet.GetComponent<CardGiven>().Leader, bullet.GetComponent<CardGiven>().Cost,
                                            bullet.GetComponent<CardGiven>().Upkeep, bullet.GetComponent<CardGiven>().Status));
                Debug.Log(tempAttackCard[0].ID);
                GameManagerSrc.Change(tempAttackCard[0]);
            }
            else { click = 0; }
            }
            else
            {
                if ((click == 1 && (bullet.transform.parent.name == "EsecondLine")))
                {
                    Debug.Log("1");
                    clone2 = Instantiate(bullet, new Vector3(500, 700, 0), Quaternion.identity);
                    clone2.transform.localScale = new Vector3(0.35f, 0.35f, 0.35f);
                    clone2.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, true);
                    clone2.tag = "enemyCards";
                    flag2 = true;
                    tempAttackCard.Add(new Card(bullet.GetComponent<CardGiven>().ID, bullet.GetComponent<CardGiven>().Name,
                                            bullet.GetComponent<CardGiven>().LogoPath, bullet.GetComponent<CardGiven>().HP,
                                            bullet.GetComponent<CardGiven>().Defense, bullet.GetComponent<CardGiven>().Attack,
                                            bullet.GetComponent<CardGiven>().Leader, bullet.GetComponent<CardGiven>().Cost,
                                            bullet.GetComponent<CardGiven>().Upkeep, bullet.GetComponent<CardGiven>().Status));

                    GameManagerSrc.Change(tempAttackCard[0]);
            }
            else
                {
                     click = 0;
                }
            }
            click++;
    }



    public void Attack(bool f1, bool f2)
    {
        if (flag1 == true && flag2 == true)
        {
            clone.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 20) * 620);
            clone2.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -20) * 520);
            attacked = true;
            Invoke("delayAttack", 1.62f);
        }
    }

    public void delayAttack()
    {
        Debug.Log(clone.transform.position);
        Debug.Log("hello, im delay");
        /*clone.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -150) * 150);
        clone2.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 150) * 150);*/
        cloneExplosion = Instantiate(Explosion, clone.transform.position, clone.transform.rotation = Quaternion.identity);
        cloneExplosion.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, true);
        Destroy(clone);
        Destroy(clone2);
        click = 0;
        flag1 = false;
        flag2 = false;
        attacked = false;
    }
    
    private void Update()
    {

        if (attacked == false)
        {
            Attack(flag1, flag2);
        }

        
        if (Input.GetKey("space"))
        {
            Destroy(clone);
            Destroy(clone2);
            click = 0;
            attacked = false;
            flag1 = false;
            flag2 = false;
        }
    }
}
    