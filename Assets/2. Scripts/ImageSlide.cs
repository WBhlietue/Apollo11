using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class ImageSlide : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    public Vector3 startX;

    Vector3 initPos;
    public float moveDuration;
    float posX
    {
        get
        {
            return transform.position.x - startX.x;
        }
        set
        {
            transform.position = startX + Vector3.right * value;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 pos = transform.position;
        pos.x = initPos.x + eventData.position.x;
        transform.position = pos;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        initPos = transform.position - (Vector3)eventData.position;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        int pos = GetImageNum() * -1080;
        transform.DOMoveX(startX.x + pos, moveDuration);
    }

    private void Awake()
    {
        startX = transform.position;
    }
    public int x;
    int GetImageNum()
    {
        x = (int)posX;
        if (x > 0)
        {
            x = 0;
        }

        int num = Mathf.Abs(x) / 540;
        if (num % 2 == 1)
        {
            num++;
        }
        int a = num / 2;
        if (a < 0)
        {
            a = 0;
        }
        else if (a > 3)
        {
            a = 3;
        }
        return a;
    }
}
