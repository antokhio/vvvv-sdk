using System;
using System.Collections.Generic;
using System.Text;

namespace VVVV.Nodes.jQuery
{
	public class JavaScriptVariableObject : JavaScriptObject
	{
		protected string FVariableName;

		private JavaScriptVariableObject()
		{

		}
		
		public JavaScriptVariableObject(string variableName)
		{
			FVariableName = variableName;
		}
		
		protected override string GetObjectScript(int indentSteps, bool breakInternalLines, bool breakAfter)
		{
			return FVariableName;
		}
	}
}
