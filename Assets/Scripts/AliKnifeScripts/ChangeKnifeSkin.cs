using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeKnifeSkin : MonoBehaviour
{
    public static Sprite KnifeSkin;
    public void ChangeSkin(Sprite Skin)
    {
        KnifeSkin = Skin;
    }
}