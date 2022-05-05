using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slope : MonoBehaviour
{
    public LayerMask whatIsGround;

    [SerializeField] private float slopeCheckDistance;

    private CapsuleCollider2D c2d;
    private Vector2 colliderSize;

    private float slopeDownAngleOld;
    private float slopeDownAngle;
    private Vector2 slopeNormalPerp;

    public bool isOnSlope;

    public Ground ground;
    // Start is called before the first frame update
    void Start()
    {
        c2d = GetComponent<CapsuleCollider2D>();
        colliderSize = c2d.size;
    }

    // Update is called once per frame
    void Update()
    {
        SlopeCheck();
    }

    private void SlopeCheck()
    {
        Vector2 checkPos = transform.position - new Vector3(0.0f, colliderSize.y / 2);
        SlopeCheckVertical(checkPos);
    }

    private void SlopeCheckHorizontal(Vector2 checkPos)
    {

    }

    private void SlopeCheckVertical(Vector2 checkPos)
    {
        RaycastHit2D hit = Physics2D.Raycast(checkPos, Vector2.down, slopeCheckDistance, whatIsGround);
        if (hit)
        {
            slopeNormalPerp = Vector2.Perpendicular(hit.normal).normalized;
            slopeDownAngle = Vector2.Angle(hit.normal, Vector2.up);

            if (slopeDownAngle != slopeDownAngleOld)
            {
                ground.setOnGround();
                isOnSlope = true;
            }
            slopeDownAngleOld = slopeDownAngle;

            Debug.DrawRay(hit.point, slopeNormalPerp, Color.blue);
            Debug.DrawRay(hit.point, hit.normal, Color.red);
        }
    }

    public bool GetOnSlope()
    {
        return isOnSlope;
    }

    public float getSlopeNormalPerp()
    {
        return slopeNormalPerp.x;
    }
}