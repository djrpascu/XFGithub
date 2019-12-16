using Xamarin.Forms;

namespace XFGithub
{
    public class FileTypeDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate FileTemplate { get; set; }
        public DataTemplate ImageTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var id = ((Sample)item).Id;

            if (id % 2 == 0)
                return ImageTemplate;
            else
                return FileTemplate;
        }
    }

}