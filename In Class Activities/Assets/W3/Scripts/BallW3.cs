using TMPro;
using UnityEngine;

public class BallW3: MonoBehaviour
{
    public SpriteRenderer ballRenderer;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _speedMultiplier = 1.1f;
    [SerializeField] private float _speedThreshold = 10.0f;
    [SerializeField] private float _brightnessIncrement = 0.1f; // 每次碰撞增加亮度

    // ------------------------------------------------------------------------
    // This method is called by Unity whenever the ball hits something.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // STEP 1 -------------------------------------------------------------
        _rigidbody.linearVelocity *= _speedMultiplier;
        // STEP 1 -------------------------------------------------------------

        // STEP 9 -------------------------------------------------------------
        // 让球颜色每次碰撞都更亮
        Color currentColor = ballRenderer.color;

        float r = currentColor.r + _brightnessIncrement;
        float g = currentColor.g + _brightnessIncrement;
        float b = currentColor.b + _brightnessIncrement;

        // 确保 RGB 不超过 1.0
        r = Mathf.Clamp(r, 0f, 1f);
        g = Mathf.Clamp(g, 0f, 1f);
        b = Mathf.Clamp(b, 0f, 1f);

        ballRenderer.color = new Color(r, g, b);
        // STEP 9 -------------------------------------------------------------
    }

    // STEP 8 -----------------------------------------------------------------
    // The GetColorMultiplier method creates a multiplier that will be used to
    //      make the balls brighter each time they bounce, IF they are moving
    //      at a certain speed.
    // Input: two floats - one for the X speed of the ball, one for the Y speed
    // Output: a multiplier number (with decimals)
    //
    private float GetColorMultiplier(float xSpeed, float ySpeed)
    {
        float avgSpeed = (xSpeed + ySpeed) / 2.0f;
        if (avgSpeed > _speedThreshold)
        {
            return 1.5f;
        }
        else
        {
            return 1.0f;
        }
    }
    // STEP 8 ------------------------------------------------------------------
}
