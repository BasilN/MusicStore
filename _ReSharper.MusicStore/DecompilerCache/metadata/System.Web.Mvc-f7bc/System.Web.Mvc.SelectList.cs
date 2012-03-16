// Type: System.Web.Mvc.SelectList
// Assembly: System.Web.Mvc, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: c:\Program Files (x86)\Microsoft ASP.NET\ASP.NET MVC 3\Assemblies\System.Web.Mvc.dll

using System.Collections;

namespace System.Web.Mvc
{
	public class SelectList : MultiSelectList
	{
		public SelectList(IEnumerable items);
		public SelectList(IEnumerable items, object selectedValue);
		public SelectList(IEnumerable items, string dataValueField, string dataTextField);
		public SelectList(IEnumerable items, string dataValueField, string dataTextField, object selectedValue);
		public object SelectedValue { get; }
	}
}
