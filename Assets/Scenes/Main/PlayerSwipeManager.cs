using UnityEngine;

public class PlayerSwipeManager : MonoBehaviour
{
    private Vector2 fingerDown;
    private Vector2 fingerUp;
    public bool detectSwipeOnlyAfterRelease = false;

    public float SWIPE_THRESHOLD = 0.1f;

    void FixedUpdate()
    {

        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                fingerUp = touch.position;
                fingerDown = touch.position;
            }

            //Detects Swipe while finger is still moving
            if (touch.phase == TouchPhase.Moved)
            {
                if (!detectSwipeOnlyAfterRelease)
                {
                    fingerDown = touch.position;
                    checkSwipe();
                }
            }

            //Detects swipe after finger is released
            if (touch.phase == TouchPhase.Ended)
            {
                fingerDown = touch.position;
                checkSwipe();
            }
        }
    }

    void checkSwipe()
    {
        float move = fingerDown.x - fingerUp.x;
        float distance = Mathf.Abs(move);
        if (distance > SWIPE_THRESHOLD)
        {
            if (move > 0)
            {
                OnSwipeRight(distance);
            }
            else if (move < 0)
            {
                OnSwipeLeft(distance);
            }
            fingerUp = fingerDown;
        }
    }

    //////////////////////////////////CALLBACK FUNCTIONS/////////////////////////////
    void OnSwipeLeft(float distance)
    {
        transform.position += transform.forward * 0.2f * distance * 0.1f;
    }

    void OnSwipeRight(float distance)
    {
        transform.position -= transform.forward * 0.2f * distance * 0.1f;
    }
}
