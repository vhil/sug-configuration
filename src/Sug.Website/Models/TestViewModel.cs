namespace Sug.Models
{
	using Helpfulcore.Ste.Extensions;
	using Helpfulcore.Ste.Model.Fields.Abstractions;
	using Helpfulcore.Ste.Mvc;

	public class TestViewModel : ViewModel
	{
		public TestViewModel(IViewModel viewModel) : base(viewModel)
		{
		}

		public ITextFieldWrapper TextField => this.RenderingItem.TextField("text");
		public ICheckboxFieldWrapper CheckboxField => this.RenderingItem.CheckboxField("checkbox");
		public IDateTimeFieldWrapper DateTimeField => this.RenderingItem.DateTimeField("datetime");
		public ILinkFieldWrapper LinkField => this.RenderingItem.LinkField("link");
		public IImageFieldWrapper ImageField => this.RenderingItem.ImageField("image");
		public IGeneralLinkFieldWrapper GeneralLinkField => this.RenderingItem.GeneralLinkField("general link");
		public IFileFieldWrapper FileField => this.RenderingItem.FileField("file");
		public IRichTextFieldWrapper RichTextField => this.RenderingItem.RichTextField("rich text");
		public INumberFieldWrapper NumberField => this.RenderingItem.NumberField("number");
		public IIntegerFieldWrapper IntegerField => this.RenderingItem.IntegerField("integer");
		public INameValueListFieldWrapper NameValueListField => this.RenderingItem.NameValueListField("Name value list");
		public INameLookupValueListFieldWrapper NameLookupValueField => this.RenderingItem.NameLookupValueField("Name lookup value list");
	}
}