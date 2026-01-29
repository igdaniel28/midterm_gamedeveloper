using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject explosionPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject explosion = Instantiate(
            explosionPrefab,
            transform.position,
            transform.rotation
        );

        Destroy(explosion, 0.1f); 
        Destroy(gameObject);
    }
}
