using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SnakeController : MonoBehaviour {

    public List<Transform> Tails;
    [Range(0,3)] public float BonesDistance;
    public GameObject BonePrefab;
    [Range(0, 4)] public float Speed;
    private Transform _transform;
    public int k = 1;

    public Text ScoreText;
    public int Score = 0;


    public UnityEvent OnEat;

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        ScoreText.text = "Score: "+Score.ToString();
        MoveSnake(_transform.position+_transform.forward*Speed*k);

        float angel = Input.GetAxis("Horizontal")*4;
        _transform.Rotate(0, angel, 0);
    }

    private void MoveSnake(Vector3 newPosition)
    {
        float sqrDistanse = BonesDistance * BonesDistance;
        _transform.position = newPosition;
        Vector3 previosPosition = _transform.position;
        foreach (var bone in Tails)
        {
            if((bone.position - previosPosition).sqrMagnitude>sqrDistanse)
            {
                var temp = bone.position;
                bone.position = previosPosition;
                previosPosition = temp;
            } else
            {
                break;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Food")
        {
            Score++;
            Destroy(collision.gameObject);
            var bone = Instantiate(BonePrefab);
            Tails.Add(bone.transform);
            if (OnEat != null)
            {
                OnEat.Invoke();
            }

        }
    }
}
