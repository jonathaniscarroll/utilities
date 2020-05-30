using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
	[SerializeField]
	private Transform Target;
	public Transform target{
		get{
			return Target;
		} set{
			Target = value;
		}
	}
	
	[SerializeField]
	private Transform _transform;
	public Transform Transform{
		get{
			return _transform;
		} set{
			_transform = value;
		}
	}
	
	public float speed = 1;
	[TagSelector]
    public string tagToFollow;

    private void Start()
	{
		if(target==null && !string.IsNullOrEmpty(tagToFollow)){
			target = GameObject.FindWithTag(tagToFollow).transform;	
		}
        
    }
    private void Update()
    {
        if(target != null)
        {
        	Debug.Log("turning");
            Vector3 dir = target.position - Transform.position;
            //dir.y = 0; // keep the direction strictly horizontal
            Quaternion rot = Quaternion.LookRotation(dir);
            Transform.rotation = Quaternion.Slerp(Transform.rotation, rot, speed * Time.deltaTime);
        }

    }
}
