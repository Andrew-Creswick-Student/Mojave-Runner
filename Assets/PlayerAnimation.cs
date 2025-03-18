using UnityEngine;

// ToDo: This script requires the use of three components:
// Animator, Player, and Rigidbody2D
// Use the RequireComponent attribute to make sure the GameObject this script is attached to has these components.
[RequireComponent (typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Player))]
public class PlayerAnimation : MonoBehaviour
{
    // ToDo: This script needs a reference variable for each component:
    public Animator animator;
    public Rigidbody2D body;
    public Player player;

    public GameObject particlePrefab;

    // Start is called before the first frame update
    void Start()
    {
        // ToDo: Get a reference to each component using GetComponent
        animator = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
        player = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        // ToDo: Set the animator bool parameter "Falling" to the value of player.isFalling.
        animator.SetBool("Falling", player.isFalling);
        // ToDo: Set the animator float parameter "YVelocity" to the value of rigidbody2D.velocity.y
        animator.SetFloat("YVelocity", body.velocity.y);
    }
    public void Smoke()
    {
        Instantiate(particlePrefab, transform.position, Quaternion.identity);
    }
}