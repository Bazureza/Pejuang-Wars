using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed;
    public float maxX, minX, maxY, minY;
    public Vector2 direction;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(direction * Time.deltaTime * speed);
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, minX, maxX), Mathf.Clamp(transform.position.y, minY, maxY));
        direction = new Vector2(0, 0);
    }
    public void Movement(string direction)
    {
        switch (direction)
        {
            case "up":
            this.direction = Vector2.up;
            break;
            case "right":
                this.direction = Vector2.right;
            break;
            case "left":
                this.direction = Vector2.left;
                break;
            case "down":
                this.direction = Vector2.down;
                break;
        }
    }

}
