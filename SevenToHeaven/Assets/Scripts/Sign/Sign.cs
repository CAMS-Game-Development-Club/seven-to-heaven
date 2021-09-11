using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign : MonoBehaviour
{
    [TextArea(2, 3)]
    public string signText;
    public float xLeft, xRight, yTop, yBottom;

    private BoxCollider2D box;

    // Initialize sign boundaries
    private void Awake() {
        GameManager.Instance.signs.Add(this);
        box = GetComponent<BoxCollider2D>();
        xLeft = transform.position.x - (box.size.x / 2);
        xRight = xLeft + box.size.x;
        yBottom = transform.position.y - (box.size.y / 2);
        yTop = yBottom + box.size.y;
    }
}
