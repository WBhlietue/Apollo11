using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huvtsas : MonoBehaviour
{
    public Data data;
    public void OnClick(){
        Manager.instance.baraaPanel.Call();
        Manager.instance.baraaPanel.GetComponent<ClothManager>().Set(data);
    }
}
