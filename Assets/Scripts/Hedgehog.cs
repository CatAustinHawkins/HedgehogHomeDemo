using UnityEngine;

public class Hedgehog : MonoBehaviour
{
    private Vector2 targetPos;
    public float speed;

    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(Input.GetMouseButton(0))
        {
            targetPos = new Vector2(mousePos.x, mousePos.y);
            if(targetPos.x < -0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            if (targetPos.x > 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, Time.deltaTime * speed);
    }
}
