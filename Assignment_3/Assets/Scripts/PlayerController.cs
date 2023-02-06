/*
 * Chandler Wesoloski
 * PlayerController.cs
 * Assignment 3
 * Controls player movement and score
 */

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour, ISubject
{
    [SerializeField] private List<IObserver> observers = new List<IObserver>();
    private int score = 0;
    private Rigidbody rb;
    private float speed = 5;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.collider.CompareTag("PickUp"))
        {
            Destroy(col.gameObject);
            score++;
            NotifyObservers();
        }
    }

    public void NotifyObservers()
    {
        for(int i = 0; i < observers.Count; i++)
        {
            observers[i].ObserverUpdate(score);
        }
    }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void UnregisterObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

}
