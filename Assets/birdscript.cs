using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrenght;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (birdIsAlive && Input.GetKeyDown(KeyCode.Space))
        {
            myRigidBody.linearVelocity = Vector2.up * flapStrenght;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdIsAlive = false;
        Debug.Log(birdIsAlive);
        logic.gameOver();
    }
}
