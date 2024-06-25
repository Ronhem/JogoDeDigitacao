using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthText : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    public PlayerHealth pHealth;
    public void Healthtext()
    {
        healthText.text = $"{pHealth.GetHealth()}";
    }

    private void Update()
    {
        Healthtext();
    }

}
