using UnityEngine;

public class Collectible2D : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<RobotVacuum  >() != null)
        {

            Destroy(gameObject);
        }
    }
}
