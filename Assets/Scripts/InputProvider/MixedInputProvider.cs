using UnityEngine;

public class MixedInputProvider : InputProvider
{
    public Joystick joystick;
    MixedInputProvider(Joystick joystick)
    {
        this.joystick = joystick;
    }

    public bool left()
    {
        return Input.GetKey(KeyCode.LeftArrow) || joystick.Horizontal < 0;
    }

    public bool right()
    {
        return Input.GetKey(KeyCode.RightArrow) || joystick.Horizontal > 0;
    }

    public float move()
    {
        var inputMove = Input.GetAxis("Horizontal");
        return inputMove != 0 ? inputMove : joystick.Horizontal;
    }

}