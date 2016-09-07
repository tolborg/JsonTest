using UnityEngine;
using System.Collections;

public class AvatarListController : MonoBehaviour {

	public GameObject avatarListItemPrefab;
	public Avatar[] avatars;


	void Start() {

		TextAsset targetFile = Resources.Load<TextAsset>("Gamedata/avatars");
		avatars = JsonHelper.FromJson<Avatar>(targetFile.text);


		foreach (Avatar avatar in avatars) {
			GameObject avatarListItem = Instantiate(avatarListItemPrefab) as GameObject;
			AvatarListItemController avatarListItemController = avatarListItem.GetComponent<AvatarListItemController>();

			avatarListItemController.SetData(avatar);
			avatarListItem.transform.SetParent(transform);
		}


	}





}
