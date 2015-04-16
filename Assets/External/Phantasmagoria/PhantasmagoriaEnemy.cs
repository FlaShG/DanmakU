﻿// Copyright (C) 2015  James Liu
//	
//	This program is free software: you can redistribute it and/or modify
//	it under the terms of the GNU General Public License as published by
//	the Free Software Foundation, either version 3 of the License, or
//	(at your option) any later version.
//		
//	This program is distributed in the hope that it will be useful,
//	but WITHOUT ANY WARRANTY; without even the implied warranty of
//	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//	GNU General Public License for more details.
//			
//	You should have received a copy of the GNU General Public License
//	along with this program.  If not, see <http://www.gnu.org/licenses/>

using UnityEngine;
using System.Collections;
using UnityUtilLib;

namespace DanmakU.Phantasmagoria {
	public class PhantasmagoriaEnemy : BasicEnemy {

		[SerializeField]
		public GameObject onDeathSpawn;

		[SerializeField]
		private float specialBoost = 0.05f;

		protected override void OnDeath () {
			Field.SpawnGameObject (onDeathSpawn, transform.position, DanmakuField.CoordinateSystem.World);
			(Field.player as PhantasmagoriaPlayableCharacter).CurrentChargeCapacity += specialBoost;
		}
	}
}