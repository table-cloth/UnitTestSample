using UnityEngine;
using UnityEditor;
using NUnit.Framework;

public class SampleCalcTest {

	[Test]
	public void EditorTest()
	{
		//Arrange
		var gameObject = new GameObject();

		//Act
		//Try to rename the GameObject
		var newGameObjectName = "My game object";
		gameObject.name = newGameObjectName;

		//Assert
		//The object has a new name
		Assert.AreEqual(newGameObjectName, gameObject.name);
	}

	[Test]
	public void GetRightValueWhenMultiply()
	{
		SimpleCalc calc = new SimpleCalc ();
		Assert.AreEqual (12, calc.Multiply (3, 4));
	}

	[Test]
	public void GetWrongValueWhenMultiply()
	{
		// test to fail test
		SimpleCalc calc = new SimpleCalc ();
		Assert.AreNotEqual (12, calc.Multiply (4, 5));
		return;
	}
}
