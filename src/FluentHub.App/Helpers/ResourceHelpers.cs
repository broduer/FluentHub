using Windows.ApplicationModel.Resources;
using Microsoft.UI.Xaml.Markup;

namespace FluentHub.App.Helpers
{
	[MarkupExtensionReturnType(ReturnType = typeof(string))]
	public sealed class ResourceString : MarkupExtension
	{
		private static ResourceLoader resourceLoader = new ResourceLoader();

		public string Name { get; set; }

		protected override object ProvideValue()
			=> resourceLoader.GetString(Name);
	}
}
