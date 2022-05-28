using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clicker : MonoBehaviour
{

    [SerializeField] private TMP_Text _ClickAmt;

    [SerializeField] private int _multiplier = 1;

    private int _clickCount;

    private int _ClickFinal;

    public void OnButtonPressed()
    {
        _clickCount++;
        print(_clickCount);
        _ClickFinal = _clickCount * _multiplier;
        print(_ClickFinal);
        _ClickAmt.text = _ClickFinal.ToString();
    }
}