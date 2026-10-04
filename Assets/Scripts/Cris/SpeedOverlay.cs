using KartGame.KartSystems;
using UnityEngine;
using UnityEngine.UI;

public class SpeedOverlay : MonoBehaviour
{
    [SerializeField] private ArcadeKart kart;
    [SerializeField] private Image overlay;

    [Header("Speed")]
    [SerializeField] private float speedThreshold = 20f;

    [Header("Alpha")]
    [SerializeField] private int maxAlpha = 5;

    [Header("Timing")]
    [SerializeField] private float increaseInterval = 0.25f;
    [SerializeField] private float decreaseInterval = 0.1f;

    private int alphaValue = 0;

    private float increaseTimer = 0f;
    private float decreaseTimer = 0f;

    private void Update()
    {
        if (kart == null || overlay == null)
            return;

        // Treat the kart's TopSpeed as 30.
        float speed = kart.LocalSpeed() * 30f;

        if (speed > speedThreshold)
        {
            decreaseTimer = 0f;
            increaseTimer += Time.deltaTime;

            if (increaseTimer >= increaseInterval)
            {
                increaseTimer = 0f;

                if (alphaValue < maxAlpha)
                {
                    alphaValue++;
                    UpdateAlpha();
                }
            }
        }
        else
        {
            increaseTimer = 0f;
            decreaseTimer += Time.deltaTime;

            if (decreaseTimer >= decreaseInterval)
            {
                decreaseTimer = 0f;

                if (alphaValue > 0)
                {
                    alphaValue--;
                    UpdateAlpha();
                }
            }
        }
    }

    private void UpdateAlpha()
    {
        Color32 color = overlay.color;

        color.a = (byte)alphaValue;

        overlay.color = color;
    }
}