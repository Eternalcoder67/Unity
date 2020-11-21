public Rigidbody2D rb;

    private float xVel = 0f;

    public float friction = 0.9f;

    public float xSpeed = 0.01f;

    public Vector2 movement;

    private bool jump false;


    //On start
    void Start()
    {
        movement.x = 0;
        movement.y = 0;
    }

    //Value changes
    void Update()
    {
        // X AXIS CHANGES

        //If key "a" down
        if (Input.GetKey("a"))
        {
            xVel += -1 * xSpeed;
        }

        //If key "d" down
        if (Input.GetKey("d"))
        {
            xVel += 1 * xSpeed;
        }

        movement.x += xVel;
        xVel = xVel * friction;

        // Y AXIS CHANGES
        if (Input.GetKey("w"))
        {
            jump = true;
        }
    }
    
    //Acual movement
    void FixedUpdate()
    {
        rb.MovePosition(movement * Time.fixedDeltaTime);
    }
