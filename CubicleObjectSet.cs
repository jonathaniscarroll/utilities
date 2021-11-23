using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Sets/CubicleObject")]
public class CubicleObjectSet : RuntimeSet<CubicleObject>
{
	public List<CubicleObject> Inventory;
}
