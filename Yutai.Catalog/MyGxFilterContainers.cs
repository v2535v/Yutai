using System;

namespace Yutai.Catalog
{
	internal class MyGxFilterContainers : IGxObjectFilter
	{
		public string Description
		{
			get
			{
				return "容器";
			}
		}

		public string Name
		{
			get
			{
				return "GxFilterContainers";
			}
		}

		public MyGxFilterContainers()
		{
		}

		public bool CanChooseObject(IGxObject igxObject_0, ref MyDoubleClickResult myDoubleClickResult_0)
		{
			return false;
		}

		public bool CanDisplayObject(IGxObject igxObject_0)
		{
			return false;
		}

		public bool CanSaveObject(IGxObject igxObject_0, string string_0, ref bool bool_0)
		{
			return false;
		}
	}
}