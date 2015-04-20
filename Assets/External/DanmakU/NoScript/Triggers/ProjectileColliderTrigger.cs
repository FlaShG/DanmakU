// Copyright (c) 2015 James Liu
//	
// See the LISCENSE file for copying permission.

using UnityEngine;
using System.Collections.Generic;

namespace DanmakU  {

	[RequireComponent(typeof(Collider2D)), AddComponentMenu("DanmakU/Triggers/Projectile Collider Trigger")]
	public class ProjectileColliderTrigger : DanmakuTrigger, IDanmakuCollider {

		[SerializeField]
		private List<string> tagFilter;

		#region IDanmakuCollider implementation
		public void OnDanmakuCollision (Danmaku proj) {
			string projTag = proj.Tag;
			for(int i = 0; i < tagFilter.Count; i++) {
				if(tagFilter[i] == projTag) {
					Trigger();
					break;
				}
			}
		}
		#endregion




	}
}
