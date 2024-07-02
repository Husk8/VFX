using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float timepass;

    private void Update()
    {
        timepass += Time.deltaTime;
        if (timepass >= 10)
        {
            transform.parent.gameObject.SetActive(false);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.transform.GetComponent<Rigidbody>() != null)
        {

            other.transform.GetComponent<Rigidbody>().AddForce(new Vector3(0, 2300, 0) * Time.deltaTime);
            other.transform.GetComponent<Rigidbody>().useGravity = false;
            if (timepass >= 10)
            {


                other.transform.GetComponent<Rigidbody>().useGravity = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.GetComponent<Rigidbody>() != null)
        {

            other.transform.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
