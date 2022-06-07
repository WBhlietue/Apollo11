using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownBarButton : MonoBehaviour
{
    public Animator ani;
    public bool isHome;
    public Transform target;
    public float padding;
    public static DownBarButton selected;
    public PanelMove panel;
    private void Awake()
    {
        if (isHome)
        {
            ani.SetBool("select", true);
            selected = this;
        }
    }
    private void Update()
    {
        transform.position = target.position + Vector3.left * ((300 - padding) + 60);
    }
    public void OnClick()
    {
        if (selected != null)
        {
            selected.ani.SetBool("select", false);
        }
        selected = this;
        ani.SetBool("select", true);
        panel.Call();
    }
}
