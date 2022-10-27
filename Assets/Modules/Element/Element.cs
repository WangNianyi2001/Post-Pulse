﻿using TMPro;
using UnityEngine;

namespace Game {
	[RequireComponent(typeof(Interactable))]
	public class Element : MonoBehaviour {
		public Interactable interactable;
		public Canvas canvas;
		public TMP_Text label;

		public string labelText = "Element";
		public string LabelText {
			get => label.text;
			set => labelText = label.text = value;
		}

		public bool active = true;
		public bool Active {
			get {
				return GetComponent<Interactable>().enabled;
			}
			set {
				active = value;
				interactable.enabled = active;
				interactable.user.enabled = active;
				canvas.enabled = active;
			}
		}

		protected virtual void Start() {
			LabelText = labelText;
			Active = active;
		}
	}
}