using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

[Serializable]
public class Avatar {
	public string avatarName;
}





public class AvatarListItemController : MonoBehaviour {

	public Text avatarName;


	public void SetData(Avatar avatar) {
		avatarName.text = avatar.avatarName;
	}


}
