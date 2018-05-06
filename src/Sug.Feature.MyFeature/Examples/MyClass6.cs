namespace Sug.Feature.MyFeature.Examples
{
	using System;
	using System.Collections.Generic;

	public class MyClass6
	{
		public MyClass6()
		{
			this.ItemNames = new Dictionary<Guid, string>();
		}

		public Dictionary<Guid, string> ItemNames { get; }

		public void AddItemName(string key, System.Xml.XmlNode node)
		{
			this.AddItemName(node);
		}

		public void AddItemName(System.Xml.XmlNode node)
		{
			var guid = Sitecore.Xml.XmlUtil.GetAttribute("guid", node);
			var name = Sitecore.Xml.XmlUtil.GetChildValue("name", node);
			this.ItemNames.Add(new Guid(guid), name);
		}
	}
}