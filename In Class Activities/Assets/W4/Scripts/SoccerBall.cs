using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SoccerBall : MonoBehaviour
{
    [SerializeField] private TMP_Text _pointsText;
    [SerializeField] private TMP_Text _timeText;
    [SerializeField] private ParticleSystem _goalVFX;

    // STEP 5 & STEP 6 member variables
    private int _points = 0;               // STEP 5: track points
    private float _timeSinceLastGoal = 0f; // STEP 6: track time since last goal

    // STEP 1 -----------------------------------------------------------------
    // The OnTriggerEnter method is a collision method called by Unity that
    //      tells our object when it's hit a collider with Is Trigger checked.
    private void OnTriggerEnter(Collider other) // FIXED METHOD SIGNATURE
    {
        // STEP 2 -------------------------------------------------------------
        // Check if the collided object has tag "Goal"
        if (other.CompareTag("Goal"))
        {
            // STEP 3 ---------------------------------------------------------
            MadeGoal(); // call MadeGoal method when ball enters goal
        }
        else
        {
            // Optional: debug for other triggers
            Debug.Log("SoccerBall detected a collision with a trigger collider that is NOT Goal!");
        }
        // STEP 2 -------------------------------------------------------------
    }
    // STEP 1 -----------------------------------------------------------------

    // STEP 3 -----------------------------------------------------------------
    // Method called when a goal is made
    private void MadeGoal()
    {
        Debug.Log("SoccerBall entered the Goal!");

        // STEP 4: play the goal VFX
        if (_goalVFX != null)
        {
            _goalVFX.Play();
        }

        // STEP 5: update points
        _points += 1;
        if (_pointsText != null)
        {
            _pointsText.text = _points.ToString();
        }

        // STEP 6: reset timer
        _timeSinceLastGoal = 0f;
    }
    // STEP 3 -----------------------------------------------------------------

    // STEP 6 -----------------------------------------------------------------
    private void Update()
    {
        // Increase timer every frame
        _timeSinceLastGoal += Time.deltaTime;

        // Update UI
        if (_timeText != null)
        {
            _timeText.text = _timeSinceLastGoal.ToString("F1") + "s"; // format to 1 decimal
        }
    }
    // STEP 6 -----------------------------------------------------------------
}
