using Godot;
using System;
using System.Runtime.CompilerServices;
using GdUnit4.Exceptions;

namespace GodotTask.Tests;

public partial class EditorHintCheck : Node
{
#pragma warning disable CA2255
	[ModuleInitializer]
#pragma warning restore CA2255
	public static void Init()
	{
		try
		{
			GDTask.Delay(TimeSpan.Zero);
		}
		catch (InvalidOperationException)
		{
			return;
		}

		throw new TestFailedException("GDTask APIs should throw under editor environment!");
	}
}
