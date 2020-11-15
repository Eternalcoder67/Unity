//Collision

    void onCollisionEnter (Collision col)
    {
        if (col.gameObject.name == "Tilemap")
        {
            Debug.Log("Hit!");
        }
    }
    
    
    //Gravity
    yVel = yVel - gravity * Time.deltaTime;
        movement.y += yVel * gravity / 5;

        if (Input.GetKeyDown("w"))
        {
            if (yVel < 0)
            {
                yVel = 1 * gravity;
            }
        }

        else if (Input.GetKeyUp("w"))
        {
            yVel = 0;
        }
