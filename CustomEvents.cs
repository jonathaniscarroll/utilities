using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class StringListEvent:UnityEvent<List<string>>{
	
}

[System.Serializable]
public class FloatListEvent:UnityEvent<List<float>>{
	
}

[System.Serializable]
public class FloatEvent:UnityEvent<float>{
	
}

[System.Serializable]
public class IntEvent:UnityEvent<int>{
	
}
[System.Serializable]
public class BoolEvent:UnityEvent<bool>{
	
}

[System.Serializable]
public class StringEvent:UnityEvent<string>{
	
}
[System.Serializable]
public class IntBoolEvent : UnityEvent<int,bool>{
	
}

[System.Serializable]
public class AudioClipEvent : UnityEvent<AudioClip>{
	
}

[System.Serializable]
public class GameObjectEvent : UnityEvent<GameObject>{
	
}
[System.Serializable]
public class GameObjectListEvent : UnityEvent<List<GameObject>>{
	
}

[System.Serializable]
public class TransformEvent : UnityEvent<Transform>{
	
}

[System.Serializable]
public class TransformListEvent : UnityEvent<List<Transform>>{
	
}

[System.Serializable]
public class Vector3Event : UnityEvent<Vector3>{
	
}
[System.Serializable]
public class FloatStringEvent : UnityEvent<string,float>
{

}

[System.Serializable]
public class TextureEvent : UnityEvent<Texture2D>
{

}

[System.Serializable]
public class AudiosourceEvent : UnityEvent<AudioSource>
{

}

[System.Serializable]
public class IEnumeratorEvent: UnityEvent<IEnumerator>{
	
}
[System.Serializable]
public class GameObjectVector3Event : UnityEvent<GameObject,Vector3>{
	
}