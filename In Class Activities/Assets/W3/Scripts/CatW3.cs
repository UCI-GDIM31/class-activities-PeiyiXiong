using TMPro;
using UnityEngine;

public class CatW3 : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private Animator _animator;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    // The speed that the player moves at
    [SerializeField] private float _speed;
    // The velocity of the player's jump
    [SerializeField] private float _jump;
    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private TMP_Text _pointsText;
    [SerializeField] private TMP_Text _speechText;
    [SerializeField] private float _maxHealth = 5;
    [SerializeField] private bool _destroyCatWhenDead = true;

    private bool _facingLeft;
    private bool _isGrounded = true;
    private int _points = 0;
    private float _health;

    // ------------------------------------------------------------------------
    private void Start ()
    {
        _health = _maxHealth;
    }

    // ------------------------------------------------------------------------
    private void Update()
    {
        // Detect input to move player left/right
        _rigidbody.linearVelocity = new Vector2(
            Input.GetAxis("Horizontal") * _speed,
            _rigidbody.linearVelocity.y
        );

        // Detect input to jump
        if (Input.GetAxis("Vertical") > 0 && _isGrounded)
        {
            _isGrounded = false;

            _rigidbody.linearVelocity = new Vector2(
                _rigidbody.linearVelocity.x,
                _jump
            );
        }

        // Change character facing 
        if (Input.GetAxis("Horizontal") < 0 && !_facingLeft)
        {
            _spriteRenderer.flipX = true;
            _facingLeft = true;
        }
        else if (Input.GetAxis("Horizontal") > 0 && _facingLeft)
        {
            _spriteRenderer.flipX = false;
            _facingLeft = false;
        }

        // Set animation state parameters
        _animator.SetBool("walking", _rigidbody.linearVelocity.x != 0.0f);
    }

    // ------------------------------------------------------------------------
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Item"))
        {
            _points++;
            _pointsText.text = "points: " + _points;
            Destroy(other.gameObject);
        }
    }

    // ------------------------------------------------------------------------
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("ground"))
        {
            _isGrounded = true;
        }

        BallW3 ball = collision.gameObject.GetComponent<BallW3>();
        if (ball != null)
        {
            ChangeColor(ball);

            // STEP 2 ---------------------------------------------------------
            // Call DecreaseHealth method
            DecreaseHealth();
            // STEP 2 ---------------------------------------------------------

            // STEP 6 ---------------------------------------------------------
            // Destroy cat if health <= 0 and flag is true
            if (_health <= 0 && _destroyCatWhenDead)
            {
                DestroyCat();
                
            }
            
            // STEP 6 ---------------------------------------------------------
        }
    }

    // STEP 3 -----------------------------------------------------------------
    private void DecreaseHealth()
    {
        // Decrease health by 1
        _health -= 1;

        // Update health text
        _healthText.text = "health = " + _health;

        // STEP 5 -------------------------------------------------------------
        // Update speech text
        _speechText.text = GetHealthSpeechText();
        // STEP 5 -------------------------------------------------------------
    }
    // STEP 3 -----------------------------------------------------------------

    // STEP 4 -----------------------------------------------------------------
    private string GetHealthSpeechText()
    {
        if (_health < _maxHealth / 2)
        {
            return "OH NO!";
        }
        else
        {
            return "ouch";
        }
    }
    // STEP 4 -----------------------------------------------------------------

    // ------------------------------------------------------------------------
    private void ChangeColor(BallW3 ball)
    {
        // STEP 7 -------------------------------------------------------------
        _spriteRenderer.color = ball.ballRenderer.color;
        // STEP 7 -------------------------------------------------------------
    }
    
    // ------------------------------------------------------------------------
    private void DestroyCat()
    {
        Destroy(gameObject);
    }
}
