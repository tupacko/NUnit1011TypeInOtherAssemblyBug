using NUnit.Framework;

using TheOtherAssembly;

namespace NUnit1011TypeInOtherAssemblyBug
{
	class TheTest
	{
		[TestCaseSource(typeof(TestCaseSources), nameof(TestCaseSources.TheNames))]
		public void ThisIsFoundAsNUnit1011Violation(string name)
		{

		}
	}
}
