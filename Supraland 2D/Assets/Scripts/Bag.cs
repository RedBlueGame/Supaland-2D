using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{
    public HoldableType Candidate;
    public HoldableType HeldObject;   
    private void OnTriggerStay2D(Collider2D collision)
    {
        Rigidbody2D rb;
        rb = collision.attachedRigidbody;

        if (rb != null)
        {
            HoldableType holdable;
            holdable = rb.GetComponent<HoldableType>();


            if ((holdable != null)&&(Candidate==null)&&(HeldObject==null))
            {
                holdable.ShowCanvas();
                Candidate = holdable;
            }



        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Rigidbody2D rb;
        rb = collision.attachedRigidbody;

        if (rb != null)
        {
            HoldableType holdable;
            holdable = rb.GetComponent<HoldableType>();


            if ((holdable != null)&&(holdable = Candidate))
            {
                holdable.HideCanvas();
                Candidate = null;
            }

        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)&&(Candidate!=null))
        {
            HeldObject = Candidate;
            Candidate.transform.parent = transform;
            Candidate.transform.localPosition = Vector3.zero;
            Candidate.GetComponent<Rigidbody2D>().simulated = false;
        }

      else  if (Input.GetKeyDown(KeyCode.E) && (HeldObject != null))
        {
            HeldObject.transform.parent = null;
            HeldObject.transform.localScale = Vector3.one;  
            HeldObject.GetComponent<Rigidbody2D>().simulated = true;
            HeldObject = null;
        }



    }






}