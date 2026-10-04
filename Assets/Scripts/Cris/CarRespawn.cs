using System.Collections;
using UnityEngine;

public class CarRespawn : MonoBehaviour
{
    [Header("Checkpoint")]
    private Vector3 checkpointPosition;
    private Quaternion checkpointRotation;

    [Header("Fade")]
    [SerializeField] private CanvasGroup fadeGroup;
    [SerializeField] private float fadeDuration = 0.25f;

    private Rigidbody rb;

    private bool isRespawning = false;
    [Header("Warning")]
    [SerializeField] private float warningBaseAlpha = 0.2f;
    [SerializeField] private float warningAlpha = 0.5f;
    [SerializeField] private float warningBlipDuration = 0.15f;
    [SerializeField] private int warningBlips = 2;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Starting position is the first checkpoint
        checkpointPosition = transform.position;
        checkpointRotation = transform.rotation;

        // Make sure the fade starts invisible
        if (fadeGroup != null)
            fadeGroup.alpha = 0f;
    }

    private void Update()
    {
        // Manual respawn
        if (Input.GetKeyDown(KeyCode.R) && !isRespawning)
        {
            StartCoroutine(RespawnSequence(0f));
        }
    }

    public void SetCheckpoint(Vector3 position, Quaternion rotation)
    {
        checkpointPosition = position;
        checkpointRotation = rotation;
    }

    public void RespawnAfterDelay(float delay)
    {
        if (!isRespawning)
        {
            StartCoroutine(RespawnSequence(delay));
        }
    }

    public void Respawn()
    {
        if (!isRespawning)
        {
            StartCoroutine(RespawnSequence(0f));
        }
    }

    private IEnumerator RespawnSequence(float delay)
    {
        isRespawning = true;

        // Wait before respawning
        if (delay > 0f)
            yield return StartCoroutine(WarningSequence(delay));

        // Fade to black
        yield return Fade(0f, 1f, fadeDuration);

        // Stop the car completely
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

            // Teleport using the Rigidbody
            rb.position = checkpointPosition;
            rb.rotation = checkpointRotation;

            // Make absolutely sure no movement carries over
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
        else
        {
            transform.position = checkpointPosition;
            transform.rotation = checkpointRotation;
        }

        // Fade back in
        yield return Fade(1f, 0f, fadeDuration);

        isRespawning = false;
    }

    private IEnumerator WarningSequence(float delay)
    {
        float interval = delay / warningBlips;

        // Start with the warning's baseline darkness
        fadeGroup.alpha = warningBaseAlpha;

        for (int i = 0; i < warningBlips; i++)
        {
            // Blip darker
            yield return Fade(warningBaseAlpha, warningAlpha, warningBlipDuration);

            // Return to baseline darkness, NOT zero
            yield return Fade(warningAlpha, warningBaseAlpha, warningBlipDuration);

            float remainingTime = interval - (warningBlipDuration * 2f);

            if (remainingTime > 0f)
                yield return new WaitForSeconds(remainingTime);
        }
    }

    private IEnumerator Fade(float startAlpha, float endAlpha, float duration)
    {
        if (fadeGroup == null)
            yield break;

        float elapsed = 0f;

        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;

            fadeGroup.alpha = Mathf.Lerp(
                startAlpha,
                endAlpha,
                elapsed / duration
            );

            yield return null;
        }

        fadeGroup.alpha = endAlpha;
    }
}
