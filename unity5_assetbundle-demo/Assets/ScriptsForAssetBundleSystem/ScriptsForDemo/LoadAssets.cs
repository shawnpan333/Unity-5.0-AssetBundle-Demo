﻿using UnityEngine;
using System.Collections;

public class LoadAssets : BaseLoader {

	public string assetBundleName = "cubewithscript.unity3d";
	public string assetName = "cubewithscript";

	// Use this for initialization
	IEnumerator Start () {

		yield return StartCoroutine(Initialize() );

		// Load asset.
		yield return StartCoroutine(Load (assetBundleName, assetName) );

		// Unload assetBundles.
		AssetBundleManager.ABM_07_UnloadAssetBundle(assetBundleName);
	}
}