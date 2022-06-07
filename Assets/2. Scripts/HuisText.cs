using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuisText : MonoBehaviour
{
    public bool isDefault;
    public Animator ani;
    public static HuisText selected;
    private void Awake() {
        if(isDefault){
            ani.SetBool("select", true);
            selected = this;
        }
    }

    public void OnClick(){
        selected.ani.SetBool("select", false);
        ani.SetBool("select", true);
        selected = this;
    }
}
