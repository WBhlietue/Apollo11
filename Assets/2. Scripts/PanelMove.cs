using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PanelMove : MonoBehaviour
{
    public float duration;
    public Ease easeCall;
    public Ease easeBack;
    public Transform fromTarget;
    public Vector3 startPos;
    public GameObject block;
    private void Awake()
    {
        startPos = transform.position;
        transform.position = fromTarget.position;
    }
    public void Call()
    {
        block.SetActive(true);
        transform.SetAsLastSibling();
        transform.DOMoveY(startPos.y, duration).SetEase(easeCall).From(fromTarget.position.y).OnComplete(() =>
        {
            block.SetActive(false);
        });
    }

    public void Back()
    {
        block.SetActive(true);
        transform.DOMoveY(fromTarget.position.y, duration).SetEase(easeBack).OnComplete(() =>
        {
            block.SetActive(false);
        });
    }
}
