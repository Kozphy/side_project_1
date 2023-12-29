using System.Collections.Generic;

namespace Side_project_1.Models.ViewModels
{
    // todo: think, fix, change structure
    public class HomeIndexVm
    {
        public List<ThumbnailImg> thumbnailImgs { get; set; }
    }
    public class ThumbnailImg
    {
        public string Title { get; set; }
        public string Location { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
    }

}
