// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

public class Test {
	public static int Main() {
		string s = Environment.GetEnvironmentVariable ("COMPlus_GCLargePage");
		Console.WriteLine(s);
		return (s == "1") ? 100 : 1;
	}
}
