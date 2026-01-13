using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Максимальное здоровье игрока
    [SerializeField] private int maxHealth = 100;

    // Текущее здоровье игрока
    private int currentHealth;

    // Событие для отображения здоровья (например, обновление UI)
    public delegate void HealthChanged(int currentHealth, int maxHealth);
    public event HealthChanged OnHealthChanged;

    void Start()
    {
        // Устанавливаем здоровье на максимум при старте
        currentHealth = maxHealth;
        OnHealthChanged?.Invoke(currentHealth, maxHealth);
    }

    // Метод для получения урона
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // Ограничиваем здоровье от 0 до maxHealth
        
    }
}
