using System;

namespace Yutai.Catalog
{
	public interface IGxObjectArray
	{
		int Count
		{
			get;
		}

		void Empty();

		void Insert(int int_0, IGxObject igxObject_0);

		IGxObject Item(int int_0);

		void Remove(int int_0);
	}
}