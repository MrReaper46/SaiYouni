using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthRandom : MonoBehaviour
{
    //----------------------Edit below here --------------------
    public Slider slider;
    public int minHealth = 100;
    public int maxHealth = 0;
    public int currentHealth = 100;
    //----------------------Edit above here --------------------
    private void Awake()
    {
        slider = GameObject.Find("Slider").GetComponent<Slider>();
        slider.minValue = maxHealth;
        slider.maxValue = minHealth;
        Debug.Log(slider.GetHashCode());
        Debug.Log(slider.minValue + " - " + slider.maxValue);
    }
    public void Start()
    {
        
    }
    private void Update()
    {
        slider.value = currentHealth;
        Debug.Log(slider.value);
    }

    // On Click function
    public void OnClick()
    {
        RandomHealth();
    }

    //----------------------Edit below here --------------------
    public void RandomHealth()
    {
        currentHealth = Random.Range(minHealth, maxHealth);
        Debug.Log(currentHealth);
    }
}
