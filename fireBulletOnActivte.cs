using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class fireBulletOnActivte : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform spawnPoint;
    public GameObject bullett;
    public float firespeed = 20;
    public void FireBullett(ActivateEventArgs arg)
    {
        GameObject spawnedBullett = Instantiate(bullett);
        spawnedBullett.transform.position = spawnPoint.position;
        spawnedBullett.GetComponent<Rigidbody>().velocity = spawnPoint.forward * firespeed;
        Destroy(spawnedBullett, 5);
    }
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullett);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
