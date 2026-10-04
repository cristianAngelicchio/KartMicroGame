using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        CarRespawn car = other.GetComponentInParent<CarRespawn>();

        if (car != null)
        {
            Debug.Log("Checkpoint reached by: " + car.name);

            car.SetCheckpoint(
                respawnPoint.position,
                respawnPoint.rotation
            );
        }
    }
}