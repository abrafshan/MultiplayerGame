using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopControler : MonoBehaviour
{
    public static int KnifeSpriteChenged;
    public void ChangeKnife1()
    {
        KnifeSpriteChenged = 1;
    }
    public void ChangeKnife2()
    {
        KnifeSpriteChenged = 2; 
    }
    public void ChangeKnife3()
    {
        KnifeSpriteChenged = 3;
    }
    public void ChangeKnife4()
    {
        KnifeSpriteChenged = 4;
    }
    public void ChangeKnife5()
    {
        KnifeSpriteChenged = 5;
    }
    public void ChangeKnife6()
    {
       KnifeSpriteChenged = 6;
    }
    void Start()

    {
        KnifeSpriteChenged = 1;
    }
}

