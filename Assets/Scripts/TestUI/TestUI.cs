using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TestUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _textTL1, _textTL2, _textTR1, _textB;
    
    [SerializeField] private RawImage _imageTR, _imageB;

    [SerializeField] private List<Texture> _images;
    

    public void OnButtonPressed()
    {
        _textTL1.text = "Patatas fritas";
    }

    public void OnTogglePressed(bool check)
    {
        string text = check ? "Never gonna give you up" : "Never gonna let you down";
        _textTL2.text = text;
    }
    
    public void OnSliderChanged(float value)
    {
        _textTR1.text = ((int)(value * 100)).ToString();
    }
    
    public void OnDropdownSelected(int value)
    {
        _imageTR.texture = _images[value];
    }

    public void OnInputFieldChanged(string text)
    {
        foreach (Texture t in _images)
        {
            if (t.name == text)
            {
                _textB.gameObject.SetActive(false);
                _imageB.texture = t;
                _imageB.color = Color.white;
                return;
            }
        }
        _textB.gameObject.SetActive(true);
        _textB.text = text;
        _imageB.texture = null;
        _imageB.color = Color.yellow;
    }
}