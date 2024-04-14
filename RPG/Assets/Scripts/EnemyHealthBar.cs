using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyHealthBar : MonoBehaviour
{
    public Character enemy;
    public Slider healthSlider;
    private void Start()
    {
        healthSlider.maxValue = enemy.maxHealth;
    }
    void Update()
    {
        healthSlider.value = enemy.health;
    }
}
