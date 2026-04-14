using System;
using TMPro;
using UnityEngine;

public class UIhealthdisplay : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    public playerhealth playerhealth; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerhealth.OnHealthChanged += OnHealthChanged;
        playerhealth.OnHealthInitialized += OnHealthInit;
    }

    private void OnHealthInit(float newhealth)
    {
        healthText.text = newhealth.ToString();
    }

    public void OnHealthChanged(float newhealth, float amountChanged)

    {
       // Debug.Log("On Health Changed Event");
       healthText.text = newhealth.ToString();
    }
}
