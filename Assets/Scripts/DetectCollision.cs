using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            Destroy(gameObject); // уничтожить животное
            Destroy(other.gameObject); // уничтожить projectile
        }
    }
}
