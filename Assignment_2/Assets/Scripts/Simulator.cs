using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulator : MonoBehaviour
{
    [SerializeField] int score = 0;
    public float timeLimitSeconds = 120;
    public Camera camera;
    public GameObject cube;
    public GameObject entity;

    private RaycastHit hit;
    private string PickupTag = "Pickup";
    private bool isPlaying;

    // Start is called before the first frame update
    void Start()
    {
        isPlaying = true;
        camera = GetComponentInChildren<Camera>();
        StartCoroutine(SpawnEntities());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider.CompareTag(PickupTag))
                {
                    Instantiate(cube, hit.point, Quaternion.identity);
                }
            }
        }
    }

    public void UpdateScore(int _score)
    {
        score += _score;
    }

    IEnumerator SpawnEntities()
    {
        while (isPlaying)
        {
            int randx = Random.Range(-13, 13);
            int randy = Random.Range(-6, 8);

            Instantiate(entity, new Vector3(randx, randy, 4), Quaternion.identity);

            yield return new WaitForSeconds(.5f);

        }
    }
}
