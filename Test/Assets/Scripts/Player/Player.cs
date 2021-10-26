using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public float GetDamage(float health, float damage)
    {
        return health - damage;
    }

    /* Health bar работает только если здоровье у игрока ровна 10-ти
 * В ТЗ не было про то сколько нужно жизней 
 * И я указал жесткие значения!
 * На будущее могу составить процентное соотношение -
 * - колличества здоровья урона и шкалы жизни (Health bar)
    */
    public void HealthBar(Image healthBar, float health)
    {
        healthBar.fillAmount = health / 10; 
    }
}
