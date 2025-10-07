using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    [SerializeField] private TMP_Text _bouncesText;
    [SerializeField] private TMP_Text _brightnessText;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Rigidbody2D _rigidbody;

    private int _bounces;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // STEP 1
        _bounces++;

        _bouncesText.text = "Bounces: " + _bounces;

        float r = _spriteRenderer.color.r;
        float g = _spriteRenderer.color.g;
        float b = _spriteRenderer.color.b;

        // STEP 2
        r += 0.1f;

        // STEP 3
        if (r > 1.0f)
        {
            r = 0.0f;
        }

        // STEP 4
        g -= 0.1f;

        // STEP 5
        if (g < 0.0f)
        {
            g = 1.0f;
        }

        // STEP 6
        b *= 1.2f;

        // STEP 7
        if (b >= 1.0f)
        {
            b = 0.1f;
        }

        Color newColor = new Color(r, g, b);
        _spriteRenderer.color = newColor;

        Debug.Log(newColor);

        // STEP 8
        float brightness = (r + g + b) / 3;

        // STEP 9
        _brightnessText.text = "brightness = " + brightness;
    }
}
