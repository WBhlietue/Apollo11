using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HuisSelect : MonoBehaviour
{
    public Transform cloths;
    public float men, women, kid;
    public float duration;
    float x;
    private void Awake() {
        x = cloths.transform.position.x;
        men += x;
        women += x;
        kid += x;
    }

    public void OnClick(int num)
    {
        switch (num)
        {
            case 0:
                cloths.transform.DOMoveX(men, duration);
                break;
            case 1:
                cloths.transform.DOMoveX(women, duration);
                break;
            case 2:
                cloths.transform.DOMoveX(kid, duration);
                break;
        }
    }
}
