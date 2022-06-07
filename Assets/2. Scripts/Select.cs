using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    public bool isDefault;
    public Animator ani;
    public SelectManager1 manager;
    public bool color;
    public UnityEngine.UI.Image[] image;
    private void Awake()
    {
        if (isDefault)
        {
            ani.SetBool("select", true);
            manager.selected = this;
        }
    }
    public void OnClick()
    {
        if (color)
        {
            foreach (var item in image)
            {
                item.color = transform.GetChild(1). GetComponent<UnityEngine.UI.Image>().color;
            }
        }
        manager.selected.ani.SetBool("select", false);
        ani.SetBool("select", true);
        manager.selected = this;
    }
}
