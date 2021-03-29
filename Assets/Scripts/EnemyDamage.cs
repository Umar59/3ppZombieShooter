using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
public class EnemyDamage : MonoBehaviour
{
    public int MaxHealth = 100;
    public GameObject enemy;
    private int health;
    public Healthbar healthbar;
    private void Start()
    {
        health = MaxHealth;
        healthbar.SetMaxHealth(MaxHealth);
    }
    public void TakeDamage(int damage)
    {
        if (health > 0)
        {

            health -= damage;
            healthbar.SetCurrentHealth(health);
        }
                 
        Debug.Log(health);

        if (health <= 0)
        {
            Destroy(enemy);
            Debug.Log("U hit enemy");
        }

    }

}
