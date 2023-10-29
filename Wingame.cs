using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public Transform player; // Reference to the player's Transform
    public float interactionDistance = 2f; // The distance at which you can interact with the object

    private bool hasWon = false;

    private void Update()
    {
        // Check if 'V' key is pressed
        if (Input.GetKeyDown(KeyCode.V))
        {
            // Check if the player is close enough to the object
            float distance = Vector3.Distance(player.position, transform.position);
            if (distance <= interactionDistance && !hasWon)
            {
                // You win the game!
                Debug.Log("You win the game!");
                hasWon = true;
            }
        }
    }
}
