using UnityEngine;

public class RespawnArea : MonoBehaviour
{
    [SerializeField] private float respawnDelay = 1f;

    private void OnTriggerEnter(Collider other)
    {
        CarRespawn car = other.GetComponentInParent<CarRespawn>();

        if (car != null)
        {
            car.RespawnAfterDelay(respawnDelay);
        }
    }
}