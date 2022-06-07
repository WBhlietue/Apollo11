using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager instance;
    public PanelMove baraaPanel;
    public List<Data> datas = new List<Data>();
    private void Awake()
    {
        instance = this;
        Application.targetFrameRate = 60;
    }

    public void AddData(Data data)
    {
        datas.Add(data);
    }

    public void RemoveData(Data data)
    {
        datas.Remove(data);
    }
}
