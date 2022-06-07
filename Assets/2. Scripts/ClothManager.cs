using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ClothManager : MonoBehaviour
{
    public Data data;
    public TextMeshProUGUI clothName;
    public TextMeshProUGUI tailbar;
    public Image[] pictures;
    public TextMeshProUGUI price;
    public Image[] imageSelectedToggle;
    public GameObject removeBtn;
    public void Set(Data d)
    {
        data = d;
        clothName.text = data.clothName;
        tailbar.text = data.tailbar;
        for (int i = 0; i < pictures.Length; i++)
        {
            pictures[i].sprite = data.pictures[i];
        }
        price.text = "₮" + data.price;

    }
    public void AddCart()
    {
        Manager.instance.AddData(data);
        removeBtn.SetActive(true);
    }
    public void Remove()
    {
        Manager.instance.RemoveData(data);
        removeBtn.SetActive(false);
    }
}
