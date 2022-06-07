using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
public class StartText : MonoBehaviour
{
    public float duration;
    public float delay;
    public PanelMove nextTarget;
    public Transform downBar;
    private void Awake() {
        float y = downBar.position.y;
        downBar.position += Vector3.down * 500;
        GetComponent<TextMeshProUGUI>().DOFade(1, duration).From(0).OnComplete(() => {
            GetComponent<TextMeshProUGUI>().DOFade(1, delay).OnComplete(() => {
                GetComponent<TextMeshProUGUI>().DOFade(0, duration).From(1).OnComplete(() => {
                    nextTarget.Call();
                    downBar.DOMoveY(y, duration);
                });
            });
        });
    }
}
