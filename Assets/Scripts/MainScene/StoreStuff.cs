using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreStuff : MonoBehaviour
{
    [SerializeField]
    private GameObject ClickerPart;
    [SerializeField]
    private GameObject ShopPart;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShopButton()
    {
        ClickerPart.SetActive(false);
        ShopPart.SetActive(true);
    }
    public void Close()
    {
        ClickerPart.SetActive(true);
        ShopPart.SetActive(false);
    }
}
