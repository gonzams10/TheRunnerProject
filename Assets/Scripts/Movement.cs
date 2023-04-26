using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Transform posRight;
    [SerializeField] private Transform posCenter;
    [SerializeField] private Transform posLeft;
    [SerializeField] private float moveSpeed;
    [SerializeField] private bool onCenter = true;
    [SerializeField] private bool onRight = false;
    [SerializeField] private bool onLeft = false;
    [SerializeField] private bool onToCenter = false;
    [SerializeField] private bool onToRight = false;
    [SerializeField] private bool onToLeft = false;
    [SerializeField] private float minTargetDistance;
    [SerializeField] private Transform actualPosition;



    // Update is called once per frame
    void Update()
    {
        Move();
    }


    private void Debug()
    {
        if (actualPosition = posCenter)
        {
            onCenter = true;
        }
    }
    public void Move()
    {
        if (onCenter && Input.GetKeyDown(KeyCode.A))

        {

            onToLeft = true;
        }

        if (onCenter && Input.GetKeyDown(KeyCode.D))
        {

            onToRight = true;
        }


        if (onLeft && Input.GetKeyDown(KeyCode.D))
        {

            onToCenter = true;
        }

        if (onRight && Input.GetKeyDown(KeyCode.A))
        {

            onToCenter = true;
        }
       if (onToLeft && onToRight  )
        {
           
                onToCenter = true;
                onToLeft = false;
                onToRight = false;
        } 
        if (Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.A))
        {
            onToCenter = true;
            onToLeft = false;
            onToRight = false;
        }




        if (onCenter && onToRight)
        {
            Vector3 distanteVector = posRight.position - transform.position;
            Vector3 velocityVector = distanteVector.normalized;

            if (distanteVector.magnitude > minTargetDistance)
            {
                transform.position += velocityVector * moveSpeed * Time.deltaTime;

            }
            else
            {
                onToRight = false;
                onCenter = false;
                onRight = true;
            }



        }

        if (onCenter && onToLeft)
        {
            Vector3 distanteVector = posLeft.position - transform.position;
            Vector3 velocityVector = distanteVector.normalized;

            if (distanteVector.magnitude > minTargetDistance)
            {
                transform.position += velocityVector * moveSpeed * Time.deltaTime;

            }
            else
            {
                onCenter = false;
                onToLeft = false;
                onLeft = true;
            }

        }

        if (onLeft && onToCenter)
        {
            Vector3 distanteVector = posCenter.position - transform.position;
            Vector3 velocityVector = distanteVector.normalized;

            if (distanteVector.magnitude > minTargetDistance)
            {
                transform.position += velocityVector * moveSpeed * Time.deltaTime;
            }
            else
            {
                onLeft = false;
                onToCenter = false;
                onCenter = true;
            }
        }

        if (onRight && onToCenter)
        {
            Vector3 distanteVector = posCenter.position - transform.position;
            Vector3 velocityVector = distanteVector.normalized;

            if (distanteVector.magnitude > minTargetDistance)
            {
                transform.position += velocityVector * moveSpeed * Time.deltaTime;

            }
            else
            {
                onToCenter = false;
                onRight = false;
                onCenter = true;
            }
        }




    }

}